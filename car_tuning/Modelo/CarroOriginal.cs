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
        private double peso, aceleracao, torque, potencia, velocidadeMax, consumo, rotacaoMax;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Aceleracao { get => aceleracao; set => aceleracao = value; }
        public double Torque { get => torque; set => torque = value; }
        public double Potencia { get => potencia; set => potencia = value; }
        public double VelocidadeMax { get => velocidadeMax; set => velocidadeMax = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public double RotacaoMax { get => rotacaoMax; set => rotacaoMax = value; }

        public CarroOriginal (string modelo, string marca, double peso, double aceleracao, double torque, double potencia, double velocidadeMax, double consumo, double rotacaoMax)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Peso = peso;
            this.Aceleracao = aceleracao;
            this.Torque = torque;
            this.Potencia = potencia;
            this.VelocidadeMax = velocidadeMax;
            this.Consumo = consumo;
            this.RotacaoMax = rotacaoMax;
        }
        public CarroOriginal()
        {

        }

      

        
    }
       
}
