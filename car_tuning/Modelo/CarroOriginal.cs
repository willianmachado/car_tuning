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
        private int cod, peso, aceleracao, torque, potencia, velocidadeMax, consumo, rotacaoMax;

        public CarroOriginal(string modelo, string marca, int cod, int peso, int aceleracao, int torque, int potencia, int velocidadeMax, int consumo, int rotacaoMax)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.cod = cod;
            this.peso = peso;
            this.aceleracao = aceleracao;
            this.torque = torque;
            this.potencia = potencia;
            this.velocidadeMax = velocidadeMax;
            this.consumo = consumo;
            this.rotacaoMax = rotacaoMax;
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

        public int Cod
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

        public int Peso
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

        public int Aceleracao
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

        public int Torque
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

        public int Potencia
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

        public int VelocidadeMax
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

        public int Consumo
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

        public int RotacaoMax
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
