using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class CarroDAO
    {
        private long cpf_cliente;
        private int ano;
        private string placa, marca, modelo;

        public CarroDAO(long cpf_cliente, int ano, string placa, string marca, string modelo)
        {
            this.Cpf_cliente = cpf_cliente;
            this.Ano = ano;
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public long Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
