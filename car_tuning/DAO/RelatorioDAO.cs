using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using car_tuning.Controle;

namespace car_tuning.DAO
{
    class RelatorioDAO
    {

        private const string Data = "Data Source = car.db";
        private const string conexao = "Data Source=car.db";

        public void geraView()
        {
            
            SQLiteConnection conn = new SQLiteConnection(conexao);
            conn.Open();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE view IF NOT EXISTS NotaFiscal as select se.codigo as codigoServ, c.nome as nomeCli, c.CPF as cpfCli, f.nome as nomeFunc," +
                " f.cpf as cpfFunc, ca.modelo, ca.placa, ca.marca, p.tipo,p.codigo as codPeca, p.fabricante, p.preco, p.compatibilidade," +
                " p.descricao, p.addTorque, p.addPeso, p.addPotencia, sp.quantidade, se.valorTotal,s.potenciaIni," +
                " s.pesoIni,s.aceleracaoIni,s.velocidade_maxIni, s.torqueIni, s.consumoIni, s.rotacao_maxIni, pesoFin, s.velocidade_maxFin," +
                " s.potenciaFin, s.aceleracaoFin, s.torqueFin, s.consumoFin, s.rotacao_maxFin from Servico se," +
                " CLIENTE c, FUNCIONARIO f, SERVPECA sp, PECA p, CARRO ca, STAGE s  on c.CPF = se.cpfcliente AND f.cpf = se.cpfFunc " +
                "AND sp.codSev = se.codigo AND sp.codPeca = p.codigo AND ca.placa = se.placaCarro AND se.codigo = s.codServ ");

            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar view Nota Fiscal: " + ex.Message);
            }




        }





        public List<NotaF> Carregar()
        {
            geraView();


            List<NotaF> lista = new List<NotaF>();

            NotaF nf = new NotaF();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from NotaFiscal", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nf.PlacaC = dr["placa"].ToString();
                nf.MarcaC = dr["marca"].ToString();
                nf.ModeloC = dr["modelo"].ToString();

                nf.CpfCli = (dr["cpfCli"].ToString());
                nf.NomeCli = dr["nomeCli"].ToString();

                nf.CpfFunc = (dr["cpfFunc"].ToString());
                nf.NomeFunc = dr["nomeFunc"].ToString();


                nf.CodigoP = Int32.Parse(dr["codPeca"].ToString());
                nf.FabricanteP = dr["fabricante"].ToString();
                nf.PrecoP = double.Parse(dr["preco"].ToString());
                nf.CompatibilidadeP = dr["compatibilidade"].ToString();
                nf.TipoP = dr["tipo"].ToString();
                nf.DescricaoP = dr["descricao"].ToString();
                nf.AddTorqueP = double.Parse(dr["addTorque"].ToString());
                nf.AddPesoP = double.Parse(dr["addPeso"].ToString());
                nf.AddPotenciaP = double.Parse(dr["addPotencia"].ToString());

                nf.QuantidadeP = int.Parse(dr["quantidade"].ToString());

                nf.PesoIni = double.Parse(dr["pesoIni"].ToString());
                nf.PotenciaIni = double.Parse(dr["potenciaIni"].ToString());
                nf.Velocidade_maxIni = double.Parse(dr["velocidade_maxIni"].ToString());
                nf.TorqueIni = double.Parse(dr["torqueIni"].ToString());
                nf.AceleracaoIni = double.Parse(dr["aceleracaoIni"].ToString());
                nf.ConsumoIni = double.Parse(dr["consumoIni"].ToString());
                nf.Rotacao_maxIni = double.Parse(dr["rotacao_maxIni"].ToString());

                nf.PesoFin = double.Parse(dr["pesoFin"].ToString());
                nf.PotenciaFin = double.Parse(dr["potenciaFin"].ToString());
                nf.Velocidade_maxFin = double.Parse(dr["velocidade_maxFin"].ToString());
                nf.TorqueFin = double.Parse(dr["torqueFin"].ToString());
                nf.AceleracaoFin = double.Parse(dr["consumoFin"].ToString());
                nf.ConsumoFin = double.Parse(dr["consumoFin"].ToString());
                nf.Rotacao_maxFin = double.Parse(dr["rotacao_maxFin"].ToString());

                nf.CodServico1 = Int32.Parse(dr["codigoServ"].ToString());
                nf.ValorTotal = double.Parse(dr["valorTotal"].ToString());

                lista.Add(new NotaF(nf.PlacaC, nf.ModeloC, nf.MarcaC, nf.CpfCli, nf.NomeCli, nf.CpfFunc, 
                    nf.NomeFunc, nf.CodigoP, nf.FabricanteP, nf.PrecoP, nf.CompatibilidadeP, nf.TipoP,
                    nf.DescricaoP, nf.AddTorqueP, nf.AddPesoP, nf.AddPotenciaP, nf.QuantidadeP, 
                    nf.PesoIni, nf.PotenciaIni, nf.Velocidade_maxIni, nf.TorqueIni, nf.AceleracaoIni, nf.ConsumoIni,
                    nf.Rotacao_maxIni,nf.PesoFin, nf.PotenciaFin, nf.Velocidade_maxFin, nf.TorqueFin, nf.AceleracaoFin,
                    nf.ConsumoFin, nf.Rotacao_maxFin, nf.CodServico1,nf.ValorTotal));

            }
            return lista;
        }




        public List<NotaF> ListaCodigo(string codigo)
        {
            geraView();


            List<NotaF> lista = new List<NotaF>();

            NotaF nf = new NotaF();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from NotaFiscal where codigoServ ="+ codigo, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nf.PlacaC = dr["placa"].ToString();
                nf.MarcaC = dr["marca"].ToString();
                nf.ModeloC = dr["modelo"].ToString();

                nf.CpfCli = (dr["cpfCli"].ToString());
                nf.NomeCli = dr["nomeCli"].ToString();

                nf.CpfFunc = (dr["cpfFunc"].ToString());
                nf.NomeFunc = dr["nomeFunc"].ToString();


                nf.CodigoP = Int32.Parse(dr["codPeca"].ToString());
                nf.FabricanteP = dr["fabricante"].ToString();
                nf.PrecoP = double.Parse(dr["preco"].ToString());
                nf.CompatibilidadeP = dr["compatibilidade"].ToString();
                nf.TipoP = dr["tipo"].ToString();
                nf.DescricaoP = dr["descricao"].ToString();
                nf.AddTorqueP = double.Parse(dr["addTorque"].ToString());
                nf.AddPesoP = double.Parse(dr["addPeso"].ToString());
                nf.AddPotenciaP = double.Parse(dr["addPotencia"].ToString());

                nf.QuantidadeP = int.Parse(dr["quantidade"].ToString());

                nf.PesoIni = double.Parse(dr["pesoIni"].ToString());
                nf.PotenciaIni = double.Parse(dr["potenciaIni"].ToString());
                nf.Velocidade_maxIni = double.Parse(dr["velocidade_maxIni"].ToString());
                nf.TorqueIni = double.Parse(dr["torqueIni"].ToString());
                nf.AceleracaoIni = double.Parse(dr["aceleracaoIni"].ToString());
                nf.ConsumoIni = double.Parse(dr["consumoIni"].ToString());
                nf.Rotacao_maxIni = double.Parse(dr["rotacao_maxIni"].ToString());

                nf.PesoFin = double.Parse(dr["pesoFin"].ToString());
                nf.PotenciaFin = double.Parse(dr["potenciaFin"].ToString());
                nf.Velocidade_maxFin = double.Parse(dr["velocidade_maxFin"].ToString());
                nf.TorqueFin = double.Parse(dr["torqueFin"].ToString());
                nf.AceleracaoFin = double.Parse(dr["consumoFin"].ToString());
                nf.ConsumoFin = double.Parse(dr["consumoFin"].ToString());
                nf.Rotacao_maxFin = double.Parse(dr["rotacao_maxFin"].ToString());

                nf.CodServico1 = Int32.Parse(dr["codigoServ"].ToString());
                nf.ValorTotal = double.Parse(dr["valorTotal"].ToString());

                lista.Add(new NotaF(nf.PlacaC, nf.ModeloC, nf.MarcaC, nf.CpfCli, nf.NomeCli, nf.CpfFunc,
                    nf.NomeFunc, nf.CodigoP, nf.FabricanteP, nf.PrecoP, nf.CompatibilidadeP, nf.TipoP,
                    nf.DescricaoP, nf.AddTorqueP, nf.AddPesoP, nf.AddPotenciaP, nf.QuantidadeP,
                    nf.PesoIni, nf.PotenciaIni, nf.Velocidade_maxIni, nf.TorqueIni, nf.AceleracaoIni, nf.ConsumoIni,
                    nf.Rotacao_maxIni, nf.PesoFin, nf.PotenciaFin, nf.Velocidade_maxFin, nf.TorqueFin, nf.AceleracaoFin,
                    nf.ConsumoFin, nf.Rotacao_maxFin, nf.CodServico1, nf.ValorTotal));

            }
            return lista;
        }

        public List<NotaF> ListaVendas()
        {
            geraView();


            List<NotaF> lista = new List<NotaF>();

            NotaF nf = new NotaF();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("select  codigoServ,nomeCli,cpfCli,placa,nomeFunc,count(codigoServ) as quantidade,valorTotal from NotaFiscal group by codigoServ", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nf.PlacaC = dr["placa"].ToString();

                nf.CpfCli = (dr["cpfCli"].ToString());
                nf.NomeCli = dr["nomeCli"].ToString();
    
                nf.NomeFunc = dr["nomeFunc"].ToString();

                nf.QuantidadeP = int.Parse(dr["quantidade"].ToString());

                nf.CodServico1 = Int32.Parse(dr["codigoServ"].ToString());

                nf.ValorTotal = double.Parse(dr["valorTotal"].ToString());

                lista.Add(new NotaF(nf.PlacaC, nf.ModeloC, nf.MarcaC, nf.CpfCli, nf.NomeCli, nf.CpfFunc,
                    nf.NomeFunc, nf.CodigoP, nf.FabricanteP, nf.PrecoP, nf.CompatibilidadeP, nf.TipoP,
                    nf.DescricaoP, nf.AddTorqueP, nf.AddPesoP, nf.AddPotenciaP, nf.QuantidadeP,
                    nf.PesoIni, nf.PotenciaIni, nf.Velocidade_maxIni, nf.TorqueIni, nf.AceleracaoIni, nf.ConsumoIni,
                    nf.Rotacao_maxIni, nf.PesoFin, nf.PotenciaFin, nf.Velocidade_maxFin, nf.TorqueFin, nf.AceleracaoFin,
                    nf.ConsumoFin, nf.Rotacao_maxFin, nf.CodServico1, nf.ValorTotal));

            }
            return lista;
        }
        public List<NotaF> RankVendas()
        {
            geraView();


            List<NotaF> lista = new List<NotaF>();

            NotaF nf = new NotaF();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("select  nome as nomeFunc,cpfFunc,sum(valorTotal) as valor from Servico,FUNCIONARIO where cpfFunc=cpf  group by cpfFunc order by valor desc", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                nf.CpfFunc = (dr["cpfFunc"].ToString());
                nf.NomeFunc = dr["nomeFunc"].ToString();


                nf.ValorTotal = double.Parse(dr["valor"].ToString());

                lista.Add(new NotaF(nf.PlacaC, nf.ModeloC, nf.MarcaC, nf.CpfCli, nf.NomeCli, nf.CpfFunc,
                    nf.NomeFunc, nf.CodigoP, nf.FabricanteP, nf.PrecoP, nf.CompatibilidadeP, nf.TipoP,
                    nf.DescricaoP, nf.AddTorqueP, nf.AddPesoP, nf.AddPotenciaP, nf.QuantidadeP,
                    nf.PesoIni, nf.PotenciaIni, nf.Velocidade_maxIni, nf.TorqueIni, nf.AceleracaoIni, nf.ConsumoIni,
                    nf.Rotacao_maxIni, nf.PesoFin, nf.PotenciaFin, nf.Velocidade_maxFin, nf.TorqueFin, nf.AceleracaoFin,
                    nf.ConsumoFin, nf.Rotacao_maxFin, nf.CodServico1, nf.ValorTotal));

            }
            return lista;
        }

        public List<NotaF> ListaEvolucao(string placa)
        {
            geraView();


            List<NotaF> lista = new List<NotaF>();

            NotaF nf = new NotaF();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from NotaFiscal where placa like '%"+placa+"%' group by codigoServ", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nf.PlacaC = dr["placa"].ToString();
                nf.MarcaC = dr["marca"].ToString();
                nf.ModeloC = dr["modelo"].ToString();

                nf.CpfCli = (dr["cpfCli"].ToString());
                nf.NomeCli = dr["nomeCli"].ToString();

                nf.CpfFunc = (dr["cpfFunc"].ToString());
                nf.NomeFunc = dr["nomeFunc"].ToString();


                nf.CodigoP = Int32.Parse(dr["codPeca"].ToString());
                nf.FabricanteP = dr["fabricante"].ToString();
                nf.PrecoP = double.Parse(dr["preco"].ToString());
                nf.CompatibilidadeP = dr["compatibilidade"].ToString();
                nf.TipoP = dr["tipo"].ToString();
                nf.DescricaoP = dr["descricao"].ToString();
                nf.AddTorqueP = double.Parse(dr["addTorque"].ToString());
                nf.AddPesoP = double.Parse(dr["addPeso"].ToString());
                nf.AddPotenciaP = double.Parse(dr["addPotencia"].ToString());

                nf.QuantidadeP = int.Parse(dr["quantidade"].ToString());

                nf.PesoIni = double.Parse(dr["pesoIni"].ToString());
                nf.PotenciaIni = double.Parse(dr["potenciaIni"].ToString());
                nf.Velocidade_maxIni = double.Parse(dr["velocidade_maxIni"].ToString());
                nf.TorqueIni = double.Parse(dr["torqueIni"].ToString());
                nf.AceleracaoIni = double.Parse(dr["aceleracaoIni"].ToString());
                nf.ConsumoIni = double.Parse(dr["consumoIni"].ToString());
                nf.Rotacao_maxIni = double.Parse(dr["rotacao_maxIni"].ToString());

                nf.PesoFin = double.Parse(dr["pesoFin"].ToString());
                nf.PotenciaFin = double.Parse(dr["potenciaFin"].ToString());
                nf.Velocidade_maxFin = double.Parse(dr["velocidade_maxFin"].ToString());
                nf.TorqueFin = double.Parse(dr["torqueFin"].ToString());
                nf.AceleracaoFin = double.Parse(dr["consumoFin"].ToString());
                nf.ConsumoFin = double.Parse(dr["consumoFin"].ToString());
                nf.Rotacao_maxFin = double.Parse(dr["rotacao_maxFin"].ToString());

                nf.CodServico1 = Int32.Parse(dr["codigoServ"].ToString());
                nf.ValorTotal = double.Parse(dr["valorTotal"].ToString());

                lista.Add(new NotaF(nf.PlacaC, nf.ModeloC, nf.MarcaC, nf.CpfCli, nf.NomeCli, nf.CpfFunc,
                    nf.NomeFunc, nf.CodigoP, nf.FabricanteP, nf.PrecoP, nf.CompatibilidadeP, nf.TipoP,
                    nf.DescricaoP, nf.AddTorqueP, nf.AddPesoP, nf.AddPotenciaP, nf.QuantidadeP,
                    nf.PesoIni, nf.PotenciaIni, nf.Velocidade_maxIni, nf.TorqueIni, nf.AceleracaoIni, nf.ConsumoIni,
                    nf.Rotacao_maxIni, nf.PesoFin, nf.PotenciaFin, nf.Velocidade_maxFin, nf.TorqueFin, nf.AceleracaoFin,
                    nf.ConsumoFin, nf.Rotacao_maxFin, nf.CodServico1, nf.ValorTotal));

            }
            return lista;
        }

        public List<NotaF> ListaPecaVenda()
        {
            geraView();


            List<NotaF> lista = new List<NotaF>();

            NotaF nf = new NotaF();

            DataBase bd = DataBase.GetInstance();
            bd.GetConnection();
            SQLiteConnection conn = new SQLiteConnection(Data);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SQLiteCommand cmd = new SQLiteCommand("select tipo,codPeca,fabricante,descricao,preco,count(quantidade)as quantidade from NotaFiscal group by tipo order by quantidade desc ", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                


                nf.CodigoP = Int32.Parse(dr["codPeca"].ToString());
                nf.FabricanteP = dr["fabricante"].ToString();
                nf.PrecoP = double.Parse(dr["preco"].ToString());
                nf.TipoP = dr["tipo"].ToString();
                nf.DescricaoP = dr["descricao"].ToString();
               

                nf.QuantidadeP = int.Parse(dr["quantidade"].ToString());

                

                lista.Add(new NotaF(nf.PlacaC, nf.ModeloC, nf.MarcaC, nf.CpfCli, nf.NomeCli, nf.CpfFunc,
                    nf.NomeFunc, nf.CodigoP, nf.FabricanteP, nf.PrecoP, nf.CompatibilidadeP, nf.TipoP,
                    nf.DescricaoP, nf.AddTorqueP, nf.AddPesoP, nf.AddPotenciaP, nf.QuantidadeP,
                    nf.PesoIni, nf.PotenciaIni, nf.Velocidade_maxIni, nf.TorqueIni, nf.AceleracaoIni, nf.ConsumoIni,
                    nf.Rotacao_maxIni, nf.PesoFin, nf.PotenciaFin, nf.Velocidade_maxFin, nf.TorqueFin, nf.AceleracaoFin,
                    nf.ConsumoFin, nf.Rotacao_maxFin, nf.CodServico1, nf.ValorTotal));

            }
            return lista;
        }
    }
}
