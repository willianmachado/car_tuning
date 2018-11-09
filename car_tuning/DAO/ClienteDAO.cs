using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace car_tuning
{
    class ClienteDAO : DataBase
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(Cliente c)
        {
            //Salvar um Cliente DAO
            
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            
            string qry = string.Format("INSERT INTO CLIENTE(CPF, NOME, TEL, EMAIL) VALUES ('{0}', '{1}', '{2}', '{3}')", c.Cpf, c.Nome, c.Telefone, c.Email);

            bd.ExecuteSQL(qry);
            conn.Close();
        }


        public void Deletar(string index)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string qry = string.Format("DELETE FROM CLIENTE WHERE CPF = '" + index + "';");

            bd.ExecuteSQL(qry);
            conn.Close();
        }

        public void Atualizar(Cliente cliente)
        {

        }
                
        public List<Cliente> BuscaNome(string cpf)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;


            return lista;
        }

        public List<Cliente> Carregar()
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente c = new Cliente();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CLIENTE", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
           

            while (dr.Read())
            {
                c.Cpf = (dr["CPF"].ToString());
                c.Nome = dr["NOME"].ToString();
                c.Email = dr["EMAIL"].ToString();
                c.Telefone = dr["TEL"].ToString();

               lista.Add(new Cliente(c.Cpf, c.Nome, c.Telefone, c.Email));
            }

            return lista;
        }

       
    }
}
