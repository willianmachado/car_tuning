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
    class CarroOriginalDAO
    {
        
        private const string Data = "Data Source = car.db";

        public void Salvar(Modelo.CarroOriginal carro)
        {
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            String qry = string.Format("INSERT INTO CARRO_ORIGINAL (modelo,marca,peso,velocidade_max,potencia,aceleracao,torque,consumo,rotacao_max) VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}')", 
                carro.Modelo,carro.Marca,carro.Peso,carro.VelocidadeMax,carro.Potencia,carro.Aceleracao,carro.Torque,carro.Consumo,carro.RotacaoMax);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            bd.ExecuteSQL(qry);
            conn.Close();
        }

        public void Deletar(int index)
        {
            String sql = string.Format("DELETE CARRO_ORIGINAL WHERE codigo='" + index + "';");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public void Atualizar(Modelo.CarroOriginal carro)
        {
            String sql = string.Format("UPDATE CARRO_ORIGINAL SET modelo='{0}',marca='{1}',peso='{2}',velocidade_max='{3}',potencia='{4}',aceleracao='{5}',torque='{6}',consumo='{7}',rotacao_max='{8}'", carro.Modelo, carro.Marca, carro.Peso, carro.VelocidadeMax, carro.Potencia, carro.Aceleracao, carro.Torque, carro.Consumo, carro.RotacaoMax);
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        
        public List<CarroOriginal> Carregar()
        {
            List<CarroOriginal> lista = new List<CarroOriginal>();
            CarroOriginal co = new CarroOriginal();
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CARRO_ORIGINAL", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                co.Cod = Double.Parse(dr["codigo"].ToString());
                co.Modelo = dr["modelo"].ToString();
                co.Marca = dr["marca"].ToString();
                co.Peso = Double.Parse(dr["peso"].ToString());
                co.VelocidadeMax = Double.Parse(dr["velocidade_max"].ToString());
                co.Potencia = Double.Parse(dr["potencia"].ToString());
                co.Aceleracao = Double.Parse(dr["aceleracao"].ToString());
                co.Torque = Double.Parse(dr["torque"].ToString());
                co.Consumo = Double.Parse(dr["consumo"].ToString());
                co.RotacaoMax = Double.Parse(dr["rotacao_max"].ToString());

                lista.Add(new CarroOriginal(co.Cod, co.Modelo,co.Marca,co.Peso,co.Aceleracao, co.Torque,co.Potencia, co.VelocidadeMax,co.Consumo,co.RotacaoMax));
            }
            return lista;
            
        }
        public List<CarroOriginal> BuscaNome(string cpf)
        {
            List<CarroOriginal> lista = new List<CarroOriginal>();

            return lista;
        }
        

    }
}
