using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Carro : CarroOriginal
    {

        public Carro()
        {

        }

        public Carro (string cpfCliente, string placa, string ano, string marca, string modelo, double peso, double potencia, double aceleracao, double velocidadeMax, double torque, double consumo, double rotacaoMax) : base (modelo, marca, peso, potencia, aceleracao, velocidadeMax, torque, consumo, rotacaoMax)
        {

        }

        private string ano;
        private string placa;
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

       
    }
}