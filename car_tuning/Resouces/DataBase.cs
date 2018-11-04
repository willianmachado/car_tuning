using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace car_tuning
{
    class DataBase
    {
        private static SQLiteConnection connection;
        private static DataBase instance;
        private const string conexao = "Data Source=car.db";
        public static string nomeBanco = "car.db";

        public DataBase()
        {
                // se não existe criar o BD
                if (!File.Exists(nomeBanco))
                GerarBD();

            connection = new SQLiteConnection(conexao);
        }

        public static DataBase GetInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        public SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(conexao);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            return connection;
        }

        public void ExecuteSQL(string qry)
        {

            SQLiteConnection conn = new SQLiteConnection(conexao);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            

            SQLiteCommand cmd = new SQLiteCommand(qry.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de BD " + ex.Message);
            }

            conn.Close();
        }


        public void GerarBD()
        {
            if (!File.Exists(nomeBanco))
            {
                SQLiteConnection.CreateFile(nomeBanco);
                SQLiteConnection conn = new SQLiteConnection(conexao);
                conn.Open();

                //cria tabela Cliente
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `CLIENTE` ( " +
                    "`CPF` TEXT NOT NULL PRIMARY KEY UNIQUE, " +
                    "`NOME` TEXT NOT NULL, " +
                    "`TEL` TEXT, " +
                    "'EMAIL' TEXT);");

                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
                }

                                  
                    //cria tabela Funcionario


                    sql.Clear();
                    sql.AppendLine("CREATE TABLE IF NOT EXISTS `FUNCIONARIO` ( " +
                        "`cpf`	TEXT NOT NULL PRIMARY KEY UNIQUE," +
                        "`nome`	TEXT NOT NULL," +
                        "`telefone`	TEXT); ");


                    cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
                    }


                //cria tabela serviço
                sql.Clear();
                sql.AppendLine("CREATE TABLE 'SERVICO' ( " +
                    "`cod` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                    "`placaCarro` TEXT NOT NULL, " +
                    "`codPeca` INTEGER NOT NULL, " +
                    "`valorTotal` INTEGER NOT NULL," +
                    "`cpfFuncionario` TEXT NOT NULL, " +
                    "`cpfCliente` TEXT NOT NULL, " +
                    "FOREIGN KEY(`placaCarro`) REFERENCES `CARRO`(`placa`), " +
                    "FOREIGN KEY('cpfFuncionario') REFERENCES 'FUNCIONARIO'('cpf'), " +
                    "FOREIGN KEY('cpfCliente') REFERENCES 'CLIENTE'('cpf') );");


                cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados tabela SERVICO: " + ex.Message);
                }


                //cria tabela Peca

                sql.Clear();
                    sql.AppendLine("CREATE TABLE IF NOT EXISTS `PECA` ( " +
                        " `codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                        " `descricao` TEXT NOT NULL, " +
                        " `tipo` TEXT NOT NULL, `valor` NUMERIC NOT NULL, " +
                        " `compatibilidade` TEXT," +
                        " `addTorque` INTEGER, " +
                        " `addPeso` INTEGER, " +
                        " `addPotencia` INTEGER); ");


                    cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados tabela PECA: " + ex.Message);
                    }


                    //cria tabela Veiculo
                    sql.Clear();
                    sql.AppendLine("CREATE TABLE IF NOT EXISTS `CARRO` ( " +
                        " `placa` TEXT NOT NULL PRIMARY KEY UNIQUE," +
                        " `modelo` TEXT," +
                        " `marca` TEXT," +
                        " `cor` TEXT," +
                        " `ano` TEXT," +
                        " `cpfCliente` TEXT NOT NULL ," +
                        "FOREIGN KEY('cpfCliente') REFERENCES 'CLIENTE'('cpf') );");


                    cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados TABELA CARRO: " + ex.Message);
                    }

                

                MessageBox.Show("Banco de dados CRIADO");
                conn.Close();
            }
        }
    }
}
