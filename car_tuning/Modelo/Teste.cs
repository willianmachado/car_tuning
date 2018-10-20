using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Teste
    {
        private int codigo;
        private int CodCliente;
        private int CodCarro;
        private double consumo;
        private double torque;
        private double potencia;
        private double velocidadeMax;
        private double zeroAcem;

        public int Codigo { get => codigo; set => codigo = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public double Torque { get => torque; set => torque = value; }
        public double Potencia { get => potencia; set => potencia = value; }
        public double VelocidadeMax { get => velocidadeMax; set => velocidadeMax = value; }
        public double ZeroAcem { get => zeroAcem; set => zeroAcem = value; }
        public int CodCliente1 { get => CodCliente; set => CodCliente = value; }
        public int CodCarro1 { get => CodCarro; set => CodCarro = value; }
    }
}
