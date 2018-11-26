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
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("INSERT INTO PECA(fabricante,preco,tipo,compatibilidade,descricao,addTorque,addPeso,addPotencia) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                peca.Fabricante,peca.Preco,peca.Tipo, peca.Compatibilidade, peca.Descricao, peca.AddTorque,peca.AddPeso,peca.AddPotencia);
            
            bd.ExecuteSQL(sql);
        }

        public void Deletar(string index)
        {
            String sql = string.Format("DELETE FROM PECA where codigo ="+ index +";");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            bd.ExecuteSQL(sql);
        }

        public void Atualizar(Pecas peca)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            String sql = string.Format("UPDATE PECA SET fabricante='{0}',preco='{1}',tipo='{2}',compatibilidade='{3}',descricao='{4}',addtorque='{5}',addPeso='{6}',addPotencia='{7}' where codigo ='{8}'",
                peca.Fabricante, peca.Preco, peca.Tipo, peca.Compatibilidade, peca.Descricao, peca.AddTorque, peca.AddPeso, peca.AddPotencia, peca.Codigo);

            bd.ExecuteSQL(sql);
           
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
                p.Fabricante = dr["fabricante"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Compatibilidade = dr["compatibilidade"].ToString();
                p.Tipo = dr["tipo"].ToString();
                p.Descricao = dr["descricao"].ToString();   
                p.AddTorque = double.Parse(dr["addTorque"].ToString());
                p.AddPeso = double.Parse(dr["addPeso"].ToString());
                p.AddPotencia = double.Parse(dr["addPotencia"].ToString());

                lista.Add(new Pecas(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque));
            }
                return lista;
        }
        public List<Pecas> Listar(string busca)
        {
            List<Pecas> lista = new List<Pecas>();
            Pecas p = new Pecas();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM PECA WHERE tipo like '%" + busca + "%' OR codigo like'%" + busca + "%' OR compatibilidade like' % " + busca + "%'", conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p.Codigo = Int32.Parse(dr["codigo"].ToString());
                p.Descricao = dr["descricao"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Fabricante = dr["fabricante"].ToString();
                p.Tipo = dr["tipo"].ToString();
                p.Compatibilidade = dr["compatibilidade"].ToString();
                p.AddPeso = double.Parse(dr["addPeso"].ToString());
                p.AddTorque = double.Parse(dr["addTorque"].ToString());
                p.AddPotencia = double.Parse(dr["addPotencia"].ToString());

                lista.Add(new Pecas(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque));

            }
            return lista;
        }
        public List<Pecas> ListaItens(List<int> cod)
        {
            List<Pecas> lista = new List<Pecas>();
            Pecas p = new Pecas();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM PECA WHERE tipo like '%" + cod, conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p.Codigo = Int32.Parse(dr["codigo"].ToString());
                p.Descricao = dr["descricao"].ToString();
                p.Preco = double.Parse(dr["preco"].ToString());
                p.Fabricante = dr["fabricante"].ToString();
                p.Tipo = dr["tipo"].ToString();
                p.Compatibilidade = dr["compatibilidade"].ToString();
                p.AddPeso = double.Parse(dr["addPeso"].ToString());
                p.AddTorque = double.Parse(dr["addTorque"].ToString());
                p.AddPotencia = double.Parse(dr["addPotencia"].ToString());

                lista.Add(new Pecas(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque));

            }
            return lista;
        }
    }
}
