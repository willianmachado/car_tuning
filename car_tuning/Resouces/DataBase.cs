using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SS_Car___Auto_Mecanica.resources
{
    class DataBase
    {
        private static SQLiteConnection conexao;
        private static DataBase instance;
        private const string URL = "Data Source=car.db";
        public static string nomeBanco = "car.db";

        private DataBase()
        {
            // se não existe criar o BD
            if (!File.Exists(nomeBanco))
                GerarBD();

            conexao = new SQLiteConnection(URL);
        }

        public static DataBase GetInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        public SQLiteConnection GetConnection()
        {
            return conexao;
        }

        public void ExecuteSQL(string qry)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            SQLiteCommand comm = new SQLiteCommand(qry, conexao);
            comm.ExecuteNonQuery();
            conexao.Close();
        }


        private void GerarBD()
        {
            SQLiteConnection.CreateFile(nomeBanco);
            SQLiteConnection conn = new SQLiteConnection(URL);
            conn.Open();

            //cria tabela Cliente
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE `cliente` ( " +
                "`cpf` TEXT NOT NULL PRIMARY KEY UNIQUE, " +
                "`nome` TEXT NOT NULL, " +
                "`telefone` TEXT, ");

            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
            }


            //cria tabela Fornecedor


            sql.Clear();
            sql.AppendLine("CREATE TABLE `funcionario` ( " +
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

            conn.Close();
            //cria tabela Peca

            sql.Clear();
            sql.AppendLine("CREATE TABLE `peca` ( " +
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

            conn.Close();
            //cria tabela Veiculo
            sql.Clear();
            sql.AppendLine("CREATE TABLE `carro` ( " +
                " `placa` TEXT NOT NULL PRIMARY KEY UNIQUE," +
                " `modelo` TEXT," +
                " `marca` TEXT," +
                " `cor` TEXT," +
                " `ano` TEXT," +
                " `cpfCliente` TEXT );" +
                "FOREIGN KEY('cpfCliente') REFERENCES 'cliente'('cpf') )");
            

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados TABELA CARRO: " + ex.Message);
            }

            conn.Close();

            //cria tabela serviço
            sql.Clear();
            sql.AppendLine("CREATE TABLE 'servico' ( " +
                "`cod` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                "`placaCarro` TEXT NOT NULL, " +
                "`codPeca` INTEGER NOT NULL, " +
                "`valorTotal` INTEGER NOT NULL," +
                "'cpfFuncionaio' INTEGER NOT NULL " +
                "`cpfCliente` INTEGER NOT NULL, " +
                " FOREIGN KEY(`placaCarro`) REFERENCES `carro`(`placa`), " +
                "FOREIGN KEY(`cpfFuncionario`) REFERENCES `funcionario`(`cpf`), " +
                "FOREIGN KEY(`cpfCliente`) REFERENCES `cliente`(`cpf`) )");
            

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados tabela ORCAMENTO: " + ex.Message);
            }

            conn.Close();
        }
    }
}
