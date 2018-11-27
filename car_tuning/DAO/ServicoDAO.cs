using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class ServicoDAO
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(Servico s)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("INSERT INTO SERVICO (placaCarro,valorTotal,cpfFunc,cpfcliente) " +
                "VALUES('{0}', '{1}', '{2}', '{3}')",s.PlacaCarro1,s.ValorTotal,s.CpfFuncionario1,s.CpfCliente1);
            bd.ExecuteSQL(sql);
        }

        public int BuscaCodigo()
        {
            int cod;
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("select max (codigo) from Servico", conn);
            cod = Convert.ToInt32(cmd.ExecuteScalar());
            return cod;
        }

        public void Deletar(int cod)
        {
            String sql = string.Format("");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public void atualizar(Servico s)
        {
            String sql = string.Format("");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public List<Servico> Listar(int busca)
        {
            
            List<Servico> lista = new List<Servico>();
            Servico s = new Servico();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM SERVICO WHERE codigo = '{0}'" + busca, conn);


            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s.Codigo = int.Parse(dr["codigo"].ToString());
                s.PlacaCarro1 = dr["placaCarro"].ToString();
                s.CpfCliente1 = dr["cpfcliente"].ToString();
                s.CpfFuncionario1 = dr["cpfFunc"].ToString();
                s.ValorTotal = double.Parse(dr["valorTotal"].ToString());
                lista.Add(new Servico(s.Codigo,s.CpfCliente1,s.CpfFuncionario1,s.PlacaCarro1,s.ValorTotal));
            }
            return lista;
         }
        public List<Servico> Carregar()
        {
            List<Servico> lista = new List<Servico>();
            Servico s = new Servico();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM SERVICO", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s.Codigo = Int32.Parse(dr["codigo"].ToString());
                s.CpfCliente1 = dr["cpfcliente"].ToString();
                s.CpfFuncionario1 = dr["cpfFunc"].ToString();
                s.PlacaCarro1 = dr["placaCarro"].ToString();
                s.ValorTotal = double.Parse(dr["valorTotal"].ToString());
                lista.Add(new Servico(s.Codigo, s.CpfCliente1, s.CpfFuncionario1, s.PlacaCarro1, s.ValorTotal));
            }
                return lista;

        }
        public List<Cliente> BuscaNome(string cpf)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;


            return lista;
        }
    }
}
