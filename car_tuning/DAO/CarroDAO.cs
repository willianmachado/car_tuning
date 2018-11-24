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

            
            string qry = string.Format("INSERT INTO CARRO (placa, modelo, ano, marca, cpfCli, peso, potencia, velocidadeMax, torque, aceleracao, consumo, rotacao)" +
                " VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                c.Placa,c.Modelo,c.Ano, c.Marca, c.CpfCliente, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax);

            bd.ExecuteSQL(qry);

        }

        public void Deletar(int index)
        {
            String sql = string.Format("DELETE CARRO WHERE codigo='" + index + "';");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
        }
        public void Atualizar(Carro c)
        {
            String sql = string.Format("UPDATE CARRO SET modelo = '{0}', ano = '{1}', marca = '{2}', peso = '{3}', potencia = '{4}'" +
                ", velocidadeMax = '{5}', torque = '{6}', aceleracao = '{7}', consumo = '{8}', rotacao = '{9}'' WHERE placa = '{10}' ",
                 c.Modelo, c.Ano, c.Marca, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax, c.Placa); 

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
                c.CpfCliente = dr["cpfCli"].ToString();
                c.Placa = dr["placa"].ToString();
                c.Ano = dr["ano"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.Marca = dr["marca"].ToString();
                c.Marca = dr["peso"].ToString();
                c.Marca = dr["potencia"].ToString();
                c.Marca = dr["velocidadeMax"].ToString();
                c.Marca = dr["torque"].ToString();
                c.Marca = dr["aceleracao"].ToString();
                c.Marca = dr["consumo"].ToString();
                c.Marca = dr["rotacao"].ToString();
                

                lista.Add(new Carro(c.Ano, c.Placa, c.Modelo, c.CpfCliente, c.Marca, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax));
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
                
                //carro.Cod = Double.Parse(dr[""].ToString());
                //carro.Codigo
                carro.Ano = dr[""].ToString();
                
            }


            return carro;
        }
    }
}
