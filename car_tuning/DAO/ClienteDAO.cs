using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using car_tuning.Modelo;

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
            
            
            string qry = string.Format("INSERT INTO CLIENTE(CPF, NOME, TEL, EMAIL) VALUES ('{0}', '{1}', '{2}', '{3}')", c.Cpf, c.Nome, c.Telefone, c.Email);
            
            bd.ExecuteSQL(qry);
           
        }


        public void Deletar(string index)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();


            string qry = string.Format("DELETE FROM CLIENTE WHERE CPF = '" + index + "';");

            bd.ExecuteSQL(qry);
        }

        public void Atualizar(Cliente c)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();


            string qry = string.Format("UPDATE CLIENTE SET NOME = '{0}', TEL = '{1}', EMAIL = '{2}' WHERE CPF = '{3}'", c.Nome, c.Telefone, c.Email, c.Cpf);

            bd.ExecuteSQL(qry);
        }
                
        public Cliente BuscaCPF(string cpf)
        {
            string qry = "select * from CLIENTE where cpf= " + cpf;
            Cliente cliente = new Cliente();
            DataBase bd = DataBase.GetInstance();
            DataSet ds = bd.ExecuteQuery(qry);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                cliente.Cpf = dr["cpf"].ToString();
                cliente.Nome = dr["nome"].ToString();
                cliente.Telefone = dr["tel"].ToString();
                cliente.Email = dr["email"].ToString();
            }
            return cliente;
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
