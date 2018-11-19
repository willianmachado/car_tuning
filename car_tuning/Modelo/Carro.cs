using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Carro : CarroOriginal

    {
        
        private string ano;
        private string placa;
        private int codigo;
        private string cpfClinte;
        private double peso;
        
        
        
        public Carro()
        {

        }

        public Carro(string modelo, string marca, double peso, double aceleracao, double torque, double potencia, double velocidadeMax, double consumo, double rotacaoMax) : base(modelo, marca, peso, aceleracao, torque, potencia, velocidadeMax, consumo, rotacaoMax)
        {
        }

        public string Ano
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
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

        public string CpfClinte
        {
            get
            {
                return cpfClinte;
            }

            set
            {
                cpfClinte = value;
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
    }
}