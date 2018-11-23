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
                ")", s.Codigo,s.PesoIni,s.AceleracaoIni,s.TorqueIni,s.PotenciaIni,s.Velocidade_maxIni,s.ConsumoIni,s.Rotacao_maxIni,s.AceleracaoFin,s.TorqueFin,s.PotenciaFin,s.Velocidade_maxFin,s.ConsumoFin,s.Rotacao_maxFin);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }

        public void Deletar(int id)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("DELETE FROM STAGE WHERE CPF = '" + id + "';");
            bd.ExecuteSQL(sql);

        }
        public void atualizar(Stage s)
        {
            
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("UPDATE STAGE SET " +
                "pesoIni = '{0}', aceleracaoIni = '{1}', torqueIni = '{2}', potenciaIni = '{3}', velocidade_MaxIni = '{4}', consumoIni = '{5}', rotacao_MaxIni = '{6}'," +
                "pesoFin = '{7}', aceleracaoFin = '{8}', torqueFin = '{9}', potenciaFin = '{10}', velocidade_MaxFin = '{11}', consumoFin = '{12}', rotacao_MaxFin = '{13}' WHERE Codigo = '{14}'", s.PesoIni, s.AceleracaoIni, s.TorqueIni, s.PotenciaIni, s.Velocidade_maxIni, s.ConsumoIni, s.Rotacao_maxIni, s.AceleracaoFin, s.TorqueFin, s.PotenciaFin, s.Velocidade_maxFin, s.ConsumoFin, s.Rotacao_maxFin, s.Codigo);
           
        }

    }
}
