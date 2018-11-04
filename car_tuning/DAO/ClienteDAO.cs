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
        
       

        public void Deletar(int id)
        {

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

            SQLiteConnection conn = new SQLiteConnection("Data Source = car.db");
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

        public void Salvar(Cliente c)
        {
            List<Cliente> lista = new List<Cliente>();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection("Data Source = car.db");
            if (conn.State == ConnectionState.Closed)
                conn.Open();


            string qry = string.Format("INSERT INTO CLIENTE(CPF, NOME, TEL, EMAIL) VALUES ('{0}', '{1}', '{2}', '{3}')", c.Cpf, c.Nome, c.Telefone, c.Email);

            bd.ExecuteSQL(qry);

        }
    }
}
