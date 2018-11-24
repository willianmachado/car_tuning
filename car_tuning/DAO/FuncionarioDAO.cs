using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
namespace car_tuning.Modelo
{
    class FuncionarioDAO
    {
        //private Database bd;
        //public FuncionarioDAO()
        //{
        //    DataBase bd = Database.GetInstance();
        //}

        // public void banco()
        //{
        //    bd = Database.GetInstance();
        // }
        private const string Data = "Data Source = car.db";

        public void Salvar(Funcionario f)
        {
            DataBase bd = DataBase.GetInstance();

            bd.GetConnection();

            string qry = string.Format("INSERT INTO FUNCIONARIO(cpf, nome, telefone) VALUES ('{0}', '{1}', '{2}')",f.Cpf,f.Nome,f.Telefone);
            bd.ExecuteSQL(qry);
            
        }

        public void Deletar(string index)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            string qry = string.Format("DELETE FROM FUNCIONARIO where cpf = '" + index + "';");
            bd.ExecuteSQL(qry);

        }
        public void atualizar(Funcionario f)
        {
            
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("UPDATE FUNCIONARIO SET nome='{0}',telefone='{1}' where cpf='{2}'",f.Nome,f.Telefone,f.Cpf);
            
        }
        public List<Funcionario> Carregar()
        {
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario f = new Funcionario();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM FUNCIONARIO", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                f.Cpf = (dr["cpf"].ToString());
                f.Nome = dr["nome"].ToString();
                f.Telefone = dr["telefone"].ToString();
                lista.Add(new Funcionario(f.Cpf, f.Nome, f.Telefone));
            }
            return lista;

        }
        public List<Funcionario> Listar(string busca)
        {
            
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario f = new Funcionario();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM FUNCIONARIO WHERE nome like'%" + busca + "%' OR cpf LIKE'%" + busca + "%'", conn);


            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                f.Cpf = (dr["cpf"].ToString());
                f.Nome = dr["nome"].ToString();
                f.Telefone = dr["telefone"].ToString();
                lista.Add(new Funcionario(f.Cpf, f.Nome, f.Telefone));
            }
            return lista;
        }
    }
}
