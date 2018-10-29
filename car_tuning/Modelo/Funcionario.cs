using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Funcionario
    {
        private int codigo;
        private string cpf;
        private string nome;
        private string telefone;

        public Funcionario(int codigo, string cpf, string nome, string telefone)
        {
            this.Codigo = codigo;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
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
    }
        
}
