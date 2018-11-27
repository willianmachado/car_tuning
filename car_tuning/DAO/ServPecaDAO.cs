using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class ServPecaDAO
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(ServPeca sv)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("INSERT INTO SERVPECA(codSev,codPeca,quantidade) VALUES ('{0}','{1}','{2}')",sv.CodServ1,sv.CodPeca1,sv.Quantidade);
            bd.ExecuteSQL(sql);
        }

        public void Deletar(int id)
        {
            String sql = string.Format("");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public void atualizar(Cliente cliente)
        {
            String sql = string.Format("");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public List<ServPeca> Carregar()
        {
            List<ServPeca> lista = new List<ServPeca>();
            ServPeca s = new ServPeca();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM SERVPECA", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s.CodPeca1 = int.Parse(dr["codPeca"].ToString());
                s.CodServ1 = int.Parse(dr["codSev"].ToString());
                s.Quantidade = int.Parse(dr["quantidade"].ToString());

                lista.Add(new ServPeca(s.CodServ1,s.CodPeca1,s.Quantidade));
            }

            return lista;

        }
        /*
        public List<Cliente> BuscaNome(string cpf)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;


            return lista;
        }
        */
    }
}
