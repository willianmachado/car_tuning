using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class CarroOriginal
    {

        private string modelo, marca;
        private double cod, peso, aceleracao, torque, potencia, velocidadeMax, consumo, rotacaoMax;

        public CarroOriginal(double cod, string modelo, string marca, double peso, double aceleracao, double torque, double potencia, double velocidadeMax, double consumo, double rotacaoMax)
        {
            this.cod = cod;
            this.modelo = modelo;
            this.marca = marca;
            this.peso = peso;
            this.aceleracao = aceleracao;
            this.torque = torque;
            this.potencia = potencia;
            this.velocidadeMax = velocidadeMax;
            this.consumo = consumo;
            this.rotacaoMax = rotacaoMax;
        }
        public CarroOriginal()
        {

        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public double Cod
        {
            get
            {
                return cod;
            }

            set
            {
                cod = value;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public double Aceleracao
        {
            get
            {
                return aceleracao;
            }

            set
            {
                aceleracao = value;
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

        public double RotacaoMax
        {
            get
            {
                return rotacaoMax;
            }

            set
            {
                rotacaoMax = value;
            }
        }

        
    }
       
}
