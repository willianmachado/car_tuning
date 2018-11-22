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
        private string placa;
        private string molelo;
        private string cpfCliente;
        private int CodMarca;
        

        public Carro()
        {


        }

        public Carro(string ano, string placa, string molelo, string cpfCliente, int codMarca)
        {
            this.ano = ano;
            this.placa = placa;
            this.molelo = molelo;
            this.cpfCliente = cpfCliente;
            CodMarca = codMarca;
        }

        public string Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Molelo { get => molelo; set => molelo = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public int CodMarca1 { get => CodMarca; set => CodMarca = value; }

    }
}