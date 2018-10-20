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
            this.codigo = codigo;
            this.cpf = cpf;
            this.nome = nome;
            this.telefone = telefone;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
