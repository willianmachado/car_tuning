using car_tuning.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning
{
    class Cliente
    {

        private string cpf;
        private string nome;
        private string telefone;
        private string email;

        public Cliente()
        {
        }

        // private Carro carro;

        public Cliente(string cpf, string nome, string telefone, string email)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            //this.Carro = carro;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
       // internal Carro Carro { get => carro; set => carro = value; }
    }
}