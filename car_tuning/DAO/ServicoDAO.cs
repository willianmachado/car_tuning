using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class ServicoDAO
    {
        public void Salvar(Servico s)
        {

            String sql = string.Format("INSERT INTO SERVICO (cod,placaCarro,codPeca,valorTotal,cpfFuncionario,cpfCliente" +
                "pesoIni, aceleracaoIni, torqueIni, potenciaIni, velocidade_MaxIni, consumoIni, rotacao_MaxIni," +
                "pesoFin, aceleracaoFin, torqueFin, potenciaFin, velocidade_MaxFin, consumoFin, rotacao_MaxFin) " +
                "VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}'," +
                "'{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}','{14}'," +
                "'{15}', '{16}', '{17}', '{18}','{19}','{20}')",s.Codigo,s.PlacaCarro1);
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
