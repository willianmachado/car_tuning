using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Carro : CarroOriginal
    {
        public Carro(double cod, string modelo, string marca, double peso, double aceleracao, double torque, double potencia, double velocidadeMax, double consumo, double rotacaoMax) : base(cod, modelo, marca, peso, aceleracao, torque, potencia, velocidadeMax, consumo, rotacaoMax)
        {

        }
   

        private string ano;
        private string placa;
        private int cod;
        private string cpfClinte;
        private double peso;

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

        public int Cod1
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

        public double Peso1
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

        public Carro(string ano, string placa, int cod, string cpfClinte, double peso)
        {
            this.Ano = ano;
            this.Placa = placa;
            this.Cod1 = cod;
            this.CpfClinte = cpfClinte;
            this.Peso1 = peso;
        }

        public Carro()
        {
        }
    }
}