using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Carro
    {
        private string ano;
        private string fabricante;
        private Cliente cliente;
        private string placa;
        private string modelo;
        private int codigo;
        private string cpfClinte;
        private double peso;

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; } 
        public string Ano { get => ano; set => ano = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string CpfClinte { get => cpfClinte; set => cpfClinte = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}
