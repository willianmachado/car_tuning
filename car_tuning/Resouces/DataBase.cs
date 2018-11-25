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
                //criar tabela marca
                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `Marca` ( " +
                    "`codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                    " `Nome` TEXT )");

                cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados TABELA Marca: " + ex.Message);
                }
                //cria tabela Carro
                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `CARRO`(" +
                    " `placa` TEXT NOT NULL UNIQUE, " +
                    "`modelo` TEXT," +
                    " `ano` TEXT, " +
                    "`marca` TEXT, " +
                    "`cpfCli` TEXT," +
                    "`peso` INTEGER, " +
                    "`potencia` INTEGER, " +
                    "`velocidadeMax` INTEGER," +
                    "`torque` INTEGER, " +
                    "`aceleracao` INTEGER, " +
                    "`consumo` INTEGER, " +
                    "`rotacao` INTEGER, " +
                    " 'foto' TEXT," +
                    " FOREIGN KEY(`marca`) REFERENCES `Marca`(`nome`)," +
                    " FOREIGN KEY(`cpfCli`) REFERENCES `Cliente`(`cpf`)," +
                    " PRIMARY KEY(`placa`) );");

                cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados TABELA CARRO: " + ex.Message);
                }

                //cria tabela serviço
                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `Servico` (" +
                    " `codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                    " `cpfcliente` TEXT," +
                    " `placaCarro` TEXT," +
                    " `cpfFunc` TEXT," +
                    " `valorTotal` REAL," +
                    " FOREIGN KEY(`cpfcliente`) REFERENCES `Cliente`(`cpf`)," +
                    " FOREIGN KEY(`cpfFunc`) REFERENCES `Funcionario`(`cpf`)," +
                    " FOREIGN KEY(`placaCarro`) REFERENCES `Carro`(`placa`) );");


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
                        "`codigo` INTEGER NOT NULL AUTOINCREMENT UNIQUE, " +
                        "`fabricante` TEXT, " +
                        "`preco` REAL, " +
                        "`compatibilidade` TEXT, " +
                        "`tipo` TEXT, `descricao` TEXT, " +
                        "`addTorque` REAL, " +
                        "`addPeso` REAL, " +
                        "`addPotencia` REAL," +
                        " PRIMARY KEY(`codigo`) );");


                    cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados tabela PECA: " + ex.Message);
                    }
                //cria tabela ServPeca

                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `SERVPECA`(" +
                    " `cadSev` INTEGER," +
                    " `codPeca` INTEGER," +
                    " `quantidade` INTEGER, " +
                    "FOREIGN KEY(`cadSev`) REFERENCES `Servico`(`codigo`), " +
                    "FOREIGN KEY(`codPeca`) REFERENCES `pecas`(`codigo`) );");


                cmd = new SQLiteCommand(sql.ToString(), conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar banco de dados tabela ServPeca: " + ex.Message);
                }



                //cria tabela Stage
                sql.Clear();
                sql.AppendLine("CREATE TABLE IF NOT EXISTS `STAGE`("+
                            	"`cod`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,"+
                                "`pesoIni`	REAL," +
                                "`velocidade_maxIni`	REAL," +
                                "`potenciaIni`	REAL," +
                                "`aceleracaoIni`	REAL," +
                                "`torqueIni`	REAL," +
                                "`consumoIni`	REAL," +
                                "`rotacao_maxIni`	REAL," +
                                "`pesoFin`	REAL," +
                                "`velocidade_maxFin`	REAL," +
                                "`potenciaFin`	REAL," +
                                "`aceleracaoFin`	REAL," +
                                "`torqueFin`	REAL," +
                                "`consumoFin`	REAL," +
                                "`rotacao_maxFin`	REAL, " +
                                "`codServ`	INTEGER,"+
                                "FOREIGN KEY(`codServ`) REFERENCES `Servico`(`codigo`));");


                cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados TABELA : STAGE" + ex.Message);
                    }


                
                

            }
        }
    }
}
