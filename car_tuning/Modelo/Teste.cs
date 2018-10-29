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

        public Teste(int codigo, int codCliente, int codCarro, double consumo, double torque, double potencia, double velocidadeMax, double zeroAcem)
        {
            this.codigo = codigo;
            CodCliente = codCliente;
            CodCarro = codCarro;
            this.consumo = consumo;
            this.torque = torque;
            this.potencia = potencia;
            this.velocidadeMax = velocidadeMax;
            this.zeroAcem = zeroAcem;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int CodCliente1
        {
            get
            {
                return CodCliente;
            }

            set
            {
                CodCliente = value;
            }
        }

        public int CodCarro1
        {
            get
            {
                return CodCarro;
            }

            set
            {
                CodCarro = value;
            }
        }

        public double Consumo
        {
            get
            {
                return consumo;
            }

            set
            {
                consumo = value;
            }
        }

        public double Torque
        {
            get
            {
                return torque;
            }

            set
            {
                torque = value;
            }
        }

        public double Potencia
        {
            get
            {
                return potencia;
            }

            set
            {
                potencia = value;
            }
        }

        public double VelocidadeMax
        {
            get
            {
                return velocidadeMax;
            }

            set
            {
                velocidadeMax = value;
            }
        }

        public double ZeroAcem
        {
            get
            {
                return zeroAcem;
            }

            set
            {
                zeroAcem = value;
            }
        }
    }
}
