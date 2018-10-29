using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class CarroOriginal
    {
        private string ano;
        private string fabricante;
        private int CodCliente;

        private string placa;
        private string modelo;
        private int codigo;
        private string cpfClinte;
        private double peso;


        public CarroOriginal(string ano, string fabricante, int codCliente, string placa, string modelo, int codigo, string cpfClinte, double peso)
        {
            this.Ano = ano;
            this.Fabricante = fabricante;
            this.CodCliente1 = codCliente;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Codigo = codigo;
            this.CpfClinte = cpfClinte;
            this.Peso = peso;
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

        public string Fabricante
        {
            get
            {
                return fabricante;
            }

            set
            {
                fabricante = value;
            }
        }

        public int CodCliente1
        {
            get
            {
                return CodCliente;
            }

            set
            {
                CodCliente = value;
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
