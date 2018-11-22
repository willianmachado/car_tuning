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
        private string cpfCliente;

        public Carro(string ano, string placa, string cpfCliente)
        {
            this.Ano = ano;
            this.Placa = placa;
            this.CpfCliente = cpfCliente;
        }

        public Carro (string cpfCliente, string placa, string ano, string marca, string modelo, double peso, double potencia, double aceleracao, double velocidadeMax, double torque, double consumo, double rotacaoMax) : base (modelo, marca, peso, potencia, aceleracao, velocidadeMax, torque, consumo, rotacaoMax)
        {

        }

        public Carro()
        {


        }        

        public string Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
    }
}