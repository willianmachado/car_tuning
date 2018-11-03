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
            this.Modelo = modelo;
            this.Marca = marca;
            this.Cod = cod;
            this.Peso = peso;
            this.Aceleracao = aceleracao;
            this.Torque = torque;
            this.Potencia = potencia;
            this.VelocidadeMax = velocidadeMax;
            this.Consumo = consumo;
            this.RotacaoMax = rotacaoMax;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Cod { get => cod; set => cod = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Aceleracao { get => aceleracao; set => aceleracao = value; }
        public int Torque { get => torque; set => torque = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public int VelocidadeMax { get => velocidadeMax; set => velocidadeMax = value; }
        public int Consumo { get => consumo; set => consumo = value; }
        public int RotacaoMax { get => rotacaoMax; set => rotacaoMax = value; }
    }
}
