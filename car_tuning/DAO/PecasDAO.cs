using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class PecasDAO
    {
        
        public void Salvar(Cliente cliente)
        {
            String sql = string.Format("INSERT INTO ");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }

        public void Deletar(int id)
        {
            String sql = string.Format("DELETE FROM  ");
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
