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
        public DataSet ExecuteQuery(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            SQLiteCommand comm = new SQLiteCommand(qry, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            connection.Close();
            return ds;
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
                    " 'pesoIni' INTEGER," +
                    " 'velocidade_maxIni' INTEGER," +
                    " 'potenciaIni' INTEGER," +
                    " 'aceleracaoIni' INTEGER," +
                    " 'torqueIni' INTEGER," +
                    " 'consumoIni' INTEGER," +
                    " 'rotacao_maxIni' INTEGER," +
                    " 'pesoFin' INTEGER," +
                    " 'velocidade_maxFin' INTEGER," +
                    " 'potenciaFin' INTEGER," +
                    " 'aceleracaoFin' INTEGER," +
                    " 'torqueFin' INTEGER," +
                    " 'consumoFin' INTEGER," +
                    " 'rotacao_maxFin' INTEGER," +
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
                        " `fabricante` TEXT," +
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


                
                
                //cria tabela CARRO ORIGINAL
                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `CARRO_ORIGINAL` ( " +


                    " 'codigo' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                    " 'modelo' TEXT," +
                    " 'marca' TEXT," +
                    " 'peso' INTEGER," +
                    " 'velocidade_max' INTEGER," +
                    " 'potencia' INTEGER," +
                    " 'aceleracao' INTEGER," +
                    " 'torque' INTEGER," +
                    " 'consumo' INTEGER," +
                    " 'rotacao_max' INTEGER," +
                    " FOREIGN KEY(`marca`) REFERENCES `MARCA`(`Nome`));");


                cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados TABELA CARRO ORIGINAL: " + ex.Message);
                    }


                //cria tabela Veiculo
                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `CARRO` ( " +
                    " `placa` TEXT NOT NULL PRIMARY KEY," +
                    " `ano` TEXT," +
                    " `modelo` TEXT," +
                    " `marca` TEXT," +
                    " 'peso' INTEGER," +
                    " 'velocidade_max' INTEGER," +
                    " 'potencia' INTEGER," +
                    " 'aceleracao' INTEGER," +
                    " 'torque' INTEGER," +
                    " 'consumo' INTEGER," +
                    " 'rotacao_max' INTEGER, " +
                    " `cpfCliente` TEXT NOT NULL ," +
                    "FOREIGN KEY('marca') REFERENCES 'CARRO_ORIGINAL'('marca'), " +
                    "FOREIGN KEY('modelo') REFERENCES 'CARRO_ORIGINAL'('modelo'), " +
                    "FOREIGN KEY('peso') REFERENCES 'CARRO_ORIGINAL'('peso'), " +
                    "FOREIGN KEY('velocidade_max') REFERENCES 'CARRO_ORIGINAL'('velocidade_max'), " +
                    "FOREIGN KEY('potencia') REFERENCES 'CARRO_ORIGINAL'('potencia'), " +
                    "FOREIGN KEY('aceleracao') REFERENCES 'CARRO_ORIGINAL'('aceleracao'), " +
                    "FOREIGN KEY('torque') REFERENCES 'CARRO_ORIGINAL'('torque'), " +
                    "FOREIGN KEY('consumo') REFERENCES 'CARRO_ORIGINAL'('consumo'), " +
                    "FOREIGN KEY('rotacao_max') REFERENCES 'CARRO_ORIGINAL'('rotacao_max'), " +
                    "FOREIGN KEY('cpfCliente') REFERENCES 'CLIENTE'('cpf'));");

                cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados TABELA CARRO: " + ex.Message);
                }
                //cria tabela marca

                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `MARCA` (`Nome` TEXT NOT NULL PRIMARY KEY UNIQUE);"
                   );

                cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados TABELA MARCA: " + ex.Message);
                }

            }
        }
    }
}
