using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Carro 
    {
        private string ano, placa, modelo, cpfCliente, marca;
        private int peso, potencia, velocidadeMax, torque, aceleracao, consumo, rotacaoMax;

        public Carro()
        {


        }

        public Carro(string placa, string cpfCliente, string ano, string marca, string modelo, int peso, int potencia, int velocidadeMax, int torque, int aceleracao, int consumo, int rotacaoMax)
        {
           
            this.Placa = placa;
            this.CpfCliente = cpfCliente;
            this.Ano = ano;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Peso = peso;
            this.Potencia = potencia;
            this.VelocidadeMax = velocidadeMax;
            this.Torque = torque;
            this.Aceleracao = aceleracao;
            this.Consumo = consumo;
            this.RotacaoMax = rotacaoMax;
        }

        public string Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public int VelocidadeMax { get => velocidadeMax; set => velocidadeMax = value; }
        public int Torque { get => torque; set => torque = value; }
        public int Aceleracao { get => aceleracao; set => aceleracao = value; }
        public int Consumo { get => consumo; set => consumo = value; }
        public int RotacaoMax { get => rotacaoMax; set => rotacaoMax = value; }
    }
}