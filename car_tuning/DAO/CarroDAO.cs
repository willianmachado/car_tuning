using System;
using car_tuning.View;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                c.Placa, c.Modelo, c.Ano, c.Marca, c.CpfCliente, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax);

            bd.ExecuteSQL(qry);

        }

        public void Deletar(string index)
        {
            String qry = string.Format("DELETE FROM CARRO WHERE placa='" + index + "';");
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            bd.ExecuteSQL(qry);
        }
        public void Atualizar(Carro c)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            string sql = string.Format("UPDATE CARRO SET modelo = '{0}', ano = '{1}', marca = '{2}', peso = '{3}', potencia = '{4}', velocidadeMax = '{5}', torque = '{6}', aceleracao = '{7}', consumo = '{8}', rotacao = '{9}' WHERE placa = '{10}'",
                 c.Modelo, c.Ano, c.Marca, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax, c.Placa);

            
            bd.ExecuteSQL(sql);
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
                c.Placa = dr["placa"].ToString();
                c.CpfCliente = dr["cpfCli"].ToString();
                c.Ano = dr["ano"].ToString();
                c.Marca = dr["marca"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.Peso = int.Parse(dr["peso"].ToString());
                c.Potencia = int.Parse(dr["potencia"].ToString());
                c.VelocidadeMax = int.Parse(dr["velocidadeMax"].ToString());
                c.Torque = int.Parse(dr["torque"].ToString());
                c.Aceleracao = int.Parse(dr["aceleracao"].ToString());
                c.Consumo = int.Parse(dr["consumo"].ToString());
                c.RotacaoMax = int.Parse(dr["rotacao"].ToString());


                  lista.Add(new Carro(c.Placa, c.CpfCliente, c.Ano, c.Marca, c.Modelo, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax));
            }
            return lista;

        }

        public List<Carro> Listar(string busca)
        {
            List<Carro> lista = new List<Carro>();
            Carro c = new Carro();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CARRO WHERE cpfCli like '%" + busca + "%' OR placa LIKE'%" + busca + "%'", conn);

            SQLiteDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                c.Placa = dr["placa"].ToString();
                c.CpfCliente = dr["cpfCli"].ToString();
                c.Ano = dr["ano"].ToString();
                c.Marca = dr["marca"].ToString();
                c.Modelo = dr["modelo"].ToString();
                c.Peso = int.Parse(dr["peso"].ToString());
                c.Potencia = int.Parse(dr["potencia"].ToString());
                c.VelocidadeMax = int.Parse(dr["velocidadeMax"].ToString());
                c.Torque = int.Parse(dr["torque"].ToString());
                c.Aceleracao = int.Parse(dr["aceleracao"].ToString());
                c.Consumo = int.Parse(dr["consumo"].ToString());
                c.RotacaoMax = int.Parse(dr["rotacao"].ToString());

                lista.Add(new Carro(c.Placa, c.CpfCliente, c.Ano, c.Marca, c.Modelo, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax));

            }
            return lista;

        }

        public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        //public Image Base64ToImage(string base64String)
        public Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        public void SaveImage(byte[] imagem, string placa)
        {
            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();

            SQLiteConnection con = new SQLiteConnection(Data);
            SQLiteCommand cmd = con.CreateCommand();

            cmd.CommandText = String.Format("INSERT INTO CARRO (foto) VALUES ('{0}') where placa ='" + placa + "';'");
            SQLiteParameter param = new SQLiteParameter("'{0}'", System.Data.DbType.Binary);
            param.Value = imagem;
            cmd.Parameters.Add(param);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc1)
            {
                MessageBox.Show(exc1.Message);
            }
            con.Close();
        }
        
        void LoadImage()
        {
            Carro c = new Carro();
            FormCarro form = new FormCarro();

            string query = "SELECT foto FROM CARRO WHERE placa =" + c.Placa;

            SQLiteConnection con = new SQLiteConnection(Data);
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();
            try
            {
                IDataReader rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        byte[] a = (System.Byte[])rdr[0];
                        form.imgCarro.Image = ByteToImage(a);
                    }
                }
                catch (Exception exc) { MessageBox.Show(exc.Message); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
        }

    }


}


