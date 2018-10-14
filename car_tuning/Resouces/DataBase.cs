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
        private const string URL = "Data Source=sscar.db";
        public static string nomeBanco = "sscar.db";

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
                "`codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                "`nome` TEXT NOT NULL, " +
                "`cpf` TEXT NOT NULL UNIQUE, " +
                "`celular` TEXT, " +
                "`telefone` TEXT, " +
                "`email` TEXT NOT NULL," +
                " `endereco` TEXT, " +
                "`bairro` TEXT," +
                " `cep` TEXT NOT NULL," +
                " `estado` TEXT," +
                " `numero` INTEGER, " +
                "`cidade` TEXT )");

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
            sql.AppendLine("CREATE TABLE `fornecedor` (`codigo`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                "`nome`	TEXT NOT NULL," +
                "`cnpj`	TEXT NOT NULL UNIQUE,`celular`	TEXT," +
                "`telefone`	TEXT," +
                "`email`	TEXT); ");
            

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
                "`codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                " `nome` TEXT NOT NULL, `codigoPartNumber` TEXT NOT NULL UNIQUE," +
                " `quantidade` REAL NOT NULL, `preco` NUMERIC NOT NULL, " +
                "`codVeiculos` TEXT, `fabricante` TEXT," +
                " `cnpjFornecedor` TEXT NOT NULL, " +
                "FOREIGN KEY(`cnpjFornecedor`) REFERENCES `fornecedor`(`cnpj`)); ");
            

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
            sql.AppendLine("CREATE TABLE `veiculo` ( " +
                "`codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                " `placa` TEXT NOT NULL UNIQUE," +
                " `modelo` TEXT," +
                " `fabricante` TEXT," +
                " `cor` TEXT," +
                " `ano` TEXT," +
                " `cpfCliente` TEXT );");
            

            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados TABELA VELICULO: " + ex.Message);
            }

            conn.Close();

            //cria tabela Orcamento
            sql.Clear();
            sql.AppendLine("CREATE TABLE 'orcamento' ( `codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                "`cpfCliente` INTEGER NOT NULL, `data` DATE NOT NULL, `codPartNum` INTEGER NOT NULL, " +
                "`palacaVeiculo` INTEGER NOT NULL, `nomeProd` INTEGER NOT NULL, " +
                "`status` TEXT, `valor` NUMERIC," +
                " FOREIGN KEY(`codPartNum`) REFERENCES `peca`(`codigoPartNumber`), " +
                "FOREIGN KEY(`palacaVeiculo`) REFERENCES `veiculo`(`placa`), " +
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
            sql.Clear();
            sql.AppendLine("CREATE TABLE 'carrinho' ( `codigo` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                "`codigoOrc` INTEGER NOT NULL, `quatidade` REAL, `codigoPeca` INTEGER NOT NULL, " +
                "FOREIGN KEY(`codigoOrc`) REFERENCES `orcamento`(`codigo`)," +
                " FOREIGN KEY(`codigoPeca`) REFERENCES `peca`(`codigo`) )");


            cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados tabela carrinho: " + ex.Message);
            }

            conn.Close();
        }
    }
}
