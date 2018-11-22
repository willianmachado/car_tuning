using car_tuning.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.DAO
{
    class StageDAO
    {
        public void Salvar(Stage s)
        {
            String sql = string.Format("INSERT INTO Stage (cod," +
                "pesoIni, aceleracaoIni, torqueIni, potenciaIni, velocidade_MaxIni, consumoIni, rotacao_MaxIni," +
                "pesoFin, aceleracaoFin, torqueFin, potenciaFin, velocidade_MaxFin, consumoFin, rotacao_MaxFin) " +
                "VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}'," +
                "'{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}','{14}'," +
                "'{15}', '{16}', '{17}', '{18}','{19}','{20}')", s.Codigo);
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

    }
}
