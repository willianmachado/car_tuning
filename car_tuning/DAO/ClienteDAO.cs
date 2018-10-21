using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning
{
    class ClienteDAO
    {
        private long cpf;
        private string nome, telefone;

        public ClienteDAO(long cpf, string nome, string telefone)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public long Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
