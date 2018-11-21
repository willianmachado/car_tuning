using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class CarroDAO
    {
        private const string Data = "Data Source = car.db";
        public void Salvar(Carro carro)
        {
            //Salvar CarroDAO
                DataBase bd = DataBase.GetInstance();
                bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string qry = string.Format("INSERT INTO CARRO (peso,velocidade_max,potencia,aceleracao,torque,consumo,rotacao_max) VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}')",
                carro.Peso, carro.VelocidadeMax, carro.Potencia, carro.Aceleracao, carro.Torque, carro.Consumo, carro.RotacaoMax);

            bd.ExecuteSQL(qry);
            conn.Close();

        }

        public void Deletar(int index)
        {
            String sql = string.Format("DELETE CARRO WHERE codigo='" + index + "';");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public void Atualizar(Carro carro)
        {
            String sql = string.Format("UPDATE CARRO SET modelo='{0}',marca='{1}',peso='{2}',velocidade_max='{3}',potencia='{4}',aceleracao='{5}',torque='{6}',consumo='{7}',rotacao_max='{8}'", carro.Modelo, carro.Marca, carro.Peso, carro.VelocidadeMax, carro.Potencia, carro.Aceleracao, carro.Torque, carro.Consumo, carro.RotacaoMax);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        
        public List<CarroOriginal> Carregar()
        {
            List<CarroOriginal> lista = new List<CarroOriginal>();
            Carro c = new Carro();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CARRO", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c.Modelo = dr["modelo"].ToString();
                c.Marca = dr["marca"].ToString();
                c.Peso = Double.Parse(dr["peso"].ToString());
                c.VelocidadeMax = Int32.Parse(dr["velocidade_max"].ToString());
                c.Potencia = Int32.Parse(dr["potencia"].ToString());
                c.Aceleracao = Int32.Parse(dr["aceleracao"].ToString());
                c.Torque = Int32.Parse(dr["torque"].ToString());
                c.Consumo = Int32.Parse(dr["consumo"].ToString());
                c.RotacaoMax = Int32.Parse(dr["rotacao_max"].ToString());

                 lista.Add(new Carro(c.Cod, c.Modelo, c.Marca, c.Peso, c.Aceleracao, c.Torque, c.Potencia, c.VelocidadeMax, c.Consumo, c.RotacaoMax));
            }
            return lista;

        }

        public Carro BuscaPlaca(string placa)
        {
            string qry = "select * CARRO where placa=" + placa;
            DataBase bd = DataBase.GetInstance();
            DataSet ds = bd.ExecuteQuery(qry);
            Carro carro = new Carro();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                carro.Aceleracao = Double.Parse(dr[""].ToString());
                carro.Peso = Double.Parse(dr[""].ToString());
                carro.Torque = Double.Parse(dr[""].ToString());
                carro.RotacaoMax = Double.Parse(dr[""].ToString());
                carro.Potencia = Double.Parse(dr[""].ToString());
                //carro.Cod = Double.Parse(dr[""].ToString());
                //carro.Codigo
                carro.Ano = dr[""].ToString();
                carro.Modelo = dr[""].ToString();
                carro.Placa = dr[""].ToString();
                carro.Marca = dr[""].ToString();
            }


            return carro;
        }
    }
}
