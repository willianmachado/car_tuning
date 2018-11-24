using car_tuning.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.DAO
{
    class MarcaDAO
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(Marca m)
        {
            
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("INSERT INTO Marca (Nome) VALUES('{0}')", m.Nome);
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
        public int BuscaCodMarca(string nome)
        {
            int marca;
            Marca m = new Marca();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Marca WHERE Nome like " + nome, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            
                m.Codigo = Int32.Parse((dr["codigo"].ToString()));
                

                marca = m.Codigo;
               

            return marca;
        }
        public List<Marca> Carregar()
        {
            List<Marca> lista = new List<Marca>();
            Marca m = new Marca();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Marca", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                m.Nome = dr["NOME"].ToString();
                lista.Add(new Marca(m.Nome));
            }
            return lista;
        }

    }
}
