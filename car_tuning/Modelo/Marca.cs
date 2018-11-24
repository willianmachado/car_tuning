using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Marca
    {
        private int codigo;
        private string nome;

        public Marca()
        {

        }

        public Marca(int codigo)
        {
            this.codigo = codigo;
        }

        public Marca(int codigo,string nome)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
