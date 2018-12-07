using car_tuning.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.DAO
{
    class StageDAO
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(Stage s)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            String sql = string.Format("INSERT INTO STAGE (pesoIni, aceleracaoIni, torqueIni, potenciaIni, velocidade_MaxIni, consumoIni, rotacao_MaxIni," +
            "pesoFin, aceleracaoFin, torqueFin, potenciaFin, velocidade_MaxFin, consumoFin, rotacao_MaxFin,codServ) " +
            "VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}'," +
            "'{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}','{14}'" +
            ")", s.PesoIni, s.AceleracaoIni, s.TorqueIni, s.PotenciaIni, s.Velocidade_maxIni, s.ConsumoIni, s.Rotacao_maxIni,s.PesoFin, s.AceleracaoFin,s.TorqueFin,s.PotenciaFin,s.Velocidade_maxFin,s.ConsumoFin,s.Rotacao_maxFin,s.CodServ1);
            
            bd.ExecuteSQL(sql);
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
        public List<Stage> Carregar()
        {
            List<Stage> lista = new List<Stage>();
            Stage s = new Stage();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM STAGE", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                s.PesoIni = double.Parse(dr["pesoIni"].ToString());
                s.PotenciaIni = double.Parse(dr["potenciaIni"].ToString());
                s.Velocidade_maxIni = double.Parse(dr["velocidade_maxIni"].ToString());
                s.TorqueIni = double.Parse(dr["torqueIni"].ToString());
                s.AceleracaoIni = double.Parse(dr["aceleracaoIni"].ToString());
                s.ConsumoIni = double.Parse(dr["consumoIni"].ToString());
                s.Rotacao_maxIni = double.Parse(dr["rotacao_maxIni"].ToString());

                s.PesoFin = double.Parse(dr["pesoFin"].ToString());
                s.PotenciaFin = double.Parse(dr["potenciaFin"].ToString());
                s.Velocidade_maxFin = double.Parse(dr["velocidade_maxFin"].ToString());
                s.TorqueFin = double.Parse(dr["torqueFin"].ToString());
                s.AceleracaoFin = double.Parse(dr["consumoFin"].ToString());
                s.ConsumoFin = double.Parse(dr["consumoFin"].ToString());
                s.Rotacao_maxFin = double.Parse(dr["rotacao_maxFin"].ToString());

                s.CodServ1 = Int32.Parse(dr["codServ"].ToString());

                lista.Add(new Stage(s.PesoIni, s.PotenciaIni, s.Velocidade_maxIni, s.TorqueIni, s.AceleracaoIni, s.ConsumoIni, s.Rotacao_maxIni,
                                    s.PesoFin, s.PotenciaFin, s.Velocidade_maxFin, s.TorqueFin, s.AceleracaoFin, s.ConsumoFin, s.Rotacao_maxFin, s.CodServ1));

            }

            return lista;

        }

        public List<Stage> BuscaServ(string codServ)
        {
            List<Stage> lista = new List<Stage>();
            Stage st = new Stage();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from STAGE where codServ like " + codServ, conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                st.PesoIni = double.Parse(dr["pesoIni"].ToString());
                st.PotenciaIni = double.Parse(dr["potenciaIni"].ToString());
                st.Velocidade_maxIni = double.Parse(dr["velocidade_maxIni"].ToString());
                st.TorqueIni = double.Parse(dr["torqueIni"].ToString());
                st.AceleracaoIni = double.Parse(dr["aceleracaoIni"].ToString());
                st.ConsumoIni = double.Parse(dr["consumoIni"].ToString());
                st.Rotacao_maxIni = double.Parse(dr["rotacao_maxIni"].ToString());

                st.PesoFin = double.Parse(dr["pesoFin"].ToString());
                st.PotenciaFin = double.Parse(dr["potenciaFin"].ToString());
                st.Velocidade_maxFin = double.Parse(dr["velocidade_maxFin"].ToString());
                st.TorqueFin = double.Parse(dr["torqueFin"].ToString());
                st.AceleracaoFin = double.Parse(dr["consumoFin"].ToString());
                st.ConsumoFin = double.Parse(dr["consumoFin"].ToString());
                st.Rotacao_maxFin = double.Parse(dr["rotacao_maxFin"].ToString());

                st.CodServ1 = Int32.Parse(dr["codServ"].ToString());
                lista.Add(new Stage(st.PesoIni,  st.Velocidade_maxIni, st.PotenciaIni, st.AceleracaoIni, st.TorqueIni,  st.ConsumoIni, st.Rotacao_maxIni, st.PesoFin,  st.Velocidade_maxFin, st.PotenciaFin, st.AceleracaoFin, st.TorqueFin,  st.ConsumoFin, st.Rotacao_maxFin, st.CodServ1));

            }
            return lista;
        }


    }
}
