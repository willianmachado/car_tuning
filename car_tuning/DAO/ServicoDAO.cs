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

            String sql = string.Format("INSERT INTO SERVICO (codigo,placaCarro,valorTotal,cpfFuncionario,cpfCliente) " +
                "VALUES('{0}', '{1}', '{2}', '{3}','{4}')",s.Codigo,s.PlacaCarro1,s.ValorTotal,s.CpfFuncionario1,s.CpfCliente1);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
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
