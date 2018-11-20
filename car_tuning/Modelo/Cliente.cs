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
        // private List<Carro> carros = new List<Carro>();


        public Cliente(string cpf, string nome, string telefone, string email)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
        
        public Cliente()
        {

        }


        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

       


    }
}