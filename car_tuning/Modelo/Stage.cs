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
