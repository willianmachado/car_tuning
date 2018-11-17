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
        /*
        public Carro(string modelo, string marca, int cod, int peso, int aceleracao, int torque, int potencia, int velocidadeMax, int consumo, int rotacaoMax) : base(modelo, marca, cod, peso, aceleracao, torque, potencia, velocidadeMax, consumo, rotacaoMax)
        {
        }
        */
        public Carro()
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