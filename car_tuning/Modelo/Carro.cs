﻿using System;
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
        private string modelo;
        private string cpfCliente;
        private string marca;
        

        public Carro()
        {


        }

        public Carro(string ano, string placa, string modelo, string cpfCliente, string marca)
        {
            this.ano = ano;
            this.placa = placa;
            this.modelo = modelo;
            this.cpfCliente = cpfCliente;
            this.marca = marca;
        }

        public string Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Molelo { get => modelo; set => modelo = value; }
        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string Marca { get => marca; set => marca = value; }

    }
}