using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class PecasDAO
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(Pecas peca)
        {
            String sql = string.Format("INSERT INTO PECA(codigo,descricao,tipo,compatibilidade,addTorque,fabricante,addPeso,addPotencia) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',)", peca.Codigo,peca.Descricao,peca.Tipo,peca.Compatibilidade,peca.AddTorque,peca.Fabricante,peca.AddPeso,peca.AddPotencia);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }

        public void Deletar(int index)
        {
            String sql = string.Format("DELETE FROM PECA where codigo = '" + index + "");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public void atualizar(Pecas peca)
        {
            String sql = string.Format("codigo='{0}',descricao='{1}',tipo='{2}',compatibilidade='{3}',addTorque='{4}',fabricante='{5}',addPeso='{6}',addPotencia='{7}'", peca.Codigo, peca.Descricao, peca.Tipo, peca.Compatibilidade, peca.AddTorque, peca.Fabricante, peca.AddPeso, peca.AddPotencia);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        
        public List<Pecas> Carregar()
        {
            List<Pecas> lista = new List<Pecas>();
            Pecas p = new Pecas();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM PECA", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p.Codigo = Int32.Parse(dr["codigo"].ToString());
                p.Descricao = dr["descricao"].ToString();
                p.Tipo = dr["tipo"].ToString();
                p.Compatibilidade = dr["compatibilidade"].ToString();
                p.AddTorque = Int32.Parse(dr["addTorque"].ToString());
                p.Fabricante = dr["fabricante"].ToString();
                p.AddPeso = Int32.Parse(dr["addPeso"].ToString());
                p.AddPotencia = Int32.Parse(dr["addPotencia"].ToString());
            }
                return lista;
        }
    }
}
