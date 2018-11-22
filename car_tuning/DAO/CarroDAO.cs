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
        public void Salvar(Carro c)
        {
            //Salvar CarroDAO
                DataBase bd = DataBase.GetInstance();
                bd.GetConnection();

            
            string qry = string.Format("INSERT INTO CARRO (cpfCliente, modelo, marca, placa, ano, peso, velocidade_max, potencia, aceleracao, torque, consumo, rotacao_max)" +
                " VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}', '{10}','{11}')",
               c.CpfCliente, c.Modelo, c.Marca, c.Placa, c.Ano, c.Peso, c.VelocidadeMax, c.Potencia, c.Aceleracao, c.Torque, c.Consumo, c.RotacaoMax);

            bd.ExecuteSQL(qry);

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
        
        public List<Carro> Carregar()
        {
            List<Carro> lista = new List<Carro>();
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
                
                c.CpfCliente = dr["cpfCliente"].ToString();
                c.Placa = dr["placa"].ToString();
                c.Ano = dr["ano"].ToString();
                c.Marca = dr["marca"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.Peso = Double.Parse(dr["peso"].ToString());
                c.Potencia = Int32.Parse(dr["potencia"].ToString());
                c.VelocidadeMax = Int32.Parse(dr["velocidade_max"].ToString());
                c.Torque = Int32.Parse(dr["torque"].ToString());
                c.Aceleracao = Int32.Parse(dr["aceleracao"].ToString());
                c.Consumo = Int32.Parse(dr["consumo"].ToString());
                c.RotacaoMax = Int32.Parse(dr["rotacao_max"].ToString());

                   lista.Add(new Carro(c.CpfCliente, c.Placa, c.Ano, c.Marca, c.Modelo, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax));
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
