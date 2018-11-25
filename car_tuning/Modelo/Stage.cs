using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Stage
    {
        private int codigo;
        private int CodServ;
        private double pesoIni, velocidade_maxIni, potenciaIni, aceleracaoIni, torqueIni, consumoIni, rotacao_maxIni;
        private double pesoFin, velocidade_maxFin, potenciaFin, aceleracaoFin, torqueFin, consumoFin, rotacao_maxFin;

        public Stage()
        {

        }
        public Stage(double pesoIni, double velocidade_maxIni, double potenciaIni, double aceleracaoIni, double torqueIni, double consumoIni, double rotacao_maxIni, double pesoFin, double velocidade_maxFin, double potenciaFin, double aceleracaoFin, double torqueFin, double consumoFin, double rotacao_maxFin, int codServ)
        {
            CodServ = codServ;
            this.pesoIni = pesoIni;
            this.velocidade_maxIni = velocidade_maxIni;
            this.potenciaIni = potenciaIni;
            this.aceleracaoIni = aceleracaoIni;
            this.torqueIni = torqueIni;
            this.consumoIni = consumoIni;
            this.rotacao_maxIni = rotacao_maxIni;
            this.pesoFin = pesoFin;
            this.velocidade_maxFin = velocidade_maxFin;
            this.potenciaFin = potenciaFin;
            this.aceleracaoFin = aceleracaoFin;
            this.torqueFin = torqueFin;
            this.consumoFin = consumoFin;
            this.rotacao_maxFin = rotacao_maxFin;
        }
        public int Codigo { get => codigo; set => codigo = value; }
        public int CodServ1 { get => CodServ; set => CodServ = value; }
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
    }
}
