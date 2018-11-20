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
        private string cpfCliente;
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

        public string CpfCliente
        {
            get
            {
                return cpfCliente;
            }

            set
            {
                cpfCliente = value;
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

        public Carro(string ano, string placa, int cod, string cpfCliente, double peso)
        {
            this.Ano = ano;
            this.Placa = placa;
            this.Cod = cod;
            this.CpfCliente = cpfCliente;
            this.Peso = peso;
        }

        public Carro()
        {
        }
    }
}