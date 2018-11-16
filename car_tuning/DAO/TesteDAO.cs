using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class TesteDAO
    {
        public void Salvar(Cliente cliente)
        {
            String sql = string.Format("");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
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
        public List<Cliente> listAll()
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;


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
