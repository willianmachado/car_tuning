using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using car_tuning.View;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
namespace car_tuning.Controle
{
    class NotaF
    {
        private string placaC, modeloC, marcaC, cpfCli, nomeCli, cpfFunc, nomeFunc;
        private int codigoP;
        private string fabricanteP;
        private Double precoP;
        private string compatibilidadeP;
        private string tipoP;
        private string descricaoP;
        private Double addTorqueP;
        private Double addPesoP;
        private Double addPotenciaP;
        private int quantidadeP;

        private int CodServico;
        private double valorTotal;

        private double pesoIni, velocidade_maxIni, potenciaIni, aceleracaoIni, torqueIni, consumoIni, rotacao_maxIni;
        private double pesoFin, velocidade_maxFin, potenciaFin, aceleracaoFin, torqueFin, consumoFin, rotacao_maxFin;
        

        public NotaF()
        {

        }

        public NotaF(string placaC, string modeloC, string marcaC, string cpfCli, string nomeCli, string cpfFunc, string nomeFunc, int codigoP, string fabricanteP, double precoP, string compatibilidadeP, string tipoP, string descricaoP, double addTorqueP, double addPesoP, double addPotenciaP, int quantidadeP, double pesoIni, double potenciaIni, double velocidade_maxIni, double torqueIni, double aceleracaoIni, double consumoIni, double rotacao_maxIni, double pesoFin, double potenciaFin, double velocidade_maxFin, double torqueFin, double aceleracaoFin, double consumoFin, double rotacao_maxFin, int codServico1, double valorTotal)
        {
            this.placaC = placaC;
            this.modeloC = modeloC;
            this.marcaC = marcaC;
            this.cpfCli = cpfCli;
            this.nomeCli = nomeCli;
            this.cpfFunc = cpfFunc;
            this.nomeFunc = nomeFunc;
            this.codigoP = codigoP;
            this.fabricanteP = fabricanteP;
            this.precoP = precoP;
            this.compatibilidadeP = compatibilidadeP;
            this.tipoP = tipoP;
            this.descricaoP = descricaoP;
            this.addTorqueP = addTorqueP;
            this.addPesoP = addPesoP;
            this.addPotenciaP = addPotenciaP;
            this.quantidadeP = quantidadeP;
            this.pesoIni = pesoIni;
            this.potenciaIni = potenciaIni;
            this.velocidade_maxIni = velocidade_maxIni;
            this.torqueIni = torqueIni;
            this.aceleracaoIni = aceleracaoIni;
            this.consumoIni = consumoIni;
            this.rotacao_maxIni = rotacao_maxIni;
            this.pesoFin = pesoFin;
            this.potenciaFin = potenciaFin;
            this.velocidade_maxFin = velocidade_maxFin;
            this.torqueFin = torqueFin;
            this.aceleracaoFin = aceleracaoFin;
            this.consumoFin = consumoFin;
            this.rotacao_maxFin = rotacao_maxFin;
            CodServico1 = codServico1;
            this.valorTotal = valorTotal;
        }

        public string PlacaC { get => placaC; set => placaC = value; }
        public string ModeloC { get => modeloC; set => modeloC = value; }
        public string MarcaC { get => marcaC; set => marcaC = value; }
        public string CpfCli { get => cpfCli; set => cpfCli = value; }
        public string NomeCli { get => nomeCli; set => nomeCli = value; }
        public string CpfFunc { get => cpfFunc; set => cpfFunc = value; }
        public string NomeFunc { get => nomeFunc; set => nomeFunc = value; }
        public int CodigoP { get => codigoP; set => codigoP = value; }
        public string FabricanteP { get => fabricanteP; set => fabricanteP = value; }
        public double PrecoP { get => precoP; set => precoP = value; }
        public string CompatibilidadeP { get => compatibilidadeP; set => compatibilidadeP = value; }
        public string TipoP { get => tipoP; set => tipoP = value; }
        public string DescricaoP { get => descricaoP; set => descricaoP = value; }
        public double AddTorqueP { get => addTorqueP; set => addTorqueP = value; }
        public double AddPesoP { get => addPesoP; set => addPesoP = value; }
        public double AddPotenciaP { get => addPotenciaP; set => addPotenciaP = value; }
        public int QuantidadeP { get => quantidadeP; set => quantidadeP = value; }
        public int CodServico1 { get => CodServico; set => CodServico = value; }
        public double PesoIni { get => pesoIni; set => pesoIni = value; }
        public double Velocidade_maxIni { get => velocidade_maxIni; set => velocidade_maxIni = value; }
        public double PotenciaIni { get => potenciaIni; set => potenciaIni = value; }
        public double AceleracaoIni { get => aceleracaoIni; set => aceleracaoIni = value; }
        public double TorqueIni { get => torqueIni; set => torqueIni = value; }
        public double ConsumoIni { get => consumoIni; set => consumoIni = value; }
        public double Rotacao_maxIni { get => rotacao_maxIni; set => rotacao_maxIni = value; }
        public double PesoFin { get => pesoFin; set => pesoFin = value; }
        public double Velocidade_maxFin { get => velocidade_maxFin; set => velocidade_maxFin = value; }
        public double PotenciaFin { get => potenciaFin; set => potenciaFin = value; }
        public double AceleracaoFin { get => aceleracaoFin; set => aceleracaoFin = value; }
        public double TorqueFin { get => torqueFin; set => torqueFin = value; }
        public double ConsumoFin { get => consumoFin; set => consumoFin = value; }
        public double Rotacao_maxFin { get => rotacao_maxFin; set => rotacao_maxFin = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
