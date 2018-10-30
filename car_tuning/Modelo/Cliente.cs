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
        private int codigo;
        private string cpf;
        private string nome;
        private string telefone;
        private string email;
        private Carro carro;

        public Cliente(int codigo, string cpf, string nome, string telefone, string email)
        {
            this.Codigo = codigo;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
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
