using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Pecas
    {
        private int codigo;
        private string nome;

        private string fabricante;
        private float preco;
        private string codVeiculos;
        private string codPartNum;
        private string tipo;
        private float status;

        public Pecas(int codigo, string nome, string fabricante, float preco, string codVeiculos, string codPartNum, string tipo, float status)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.fabricante = fabricante;
            this.preco = preco;
            this.codVeiculos = codVeiculos;
            this.codPartNum = codPartNum;
            this.tipo = tipo;
            this.status = status;
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

        public string Fabricante
        {
            get
            {
                return fabricante;
            }

            set
            {
                fabricante = value;
            }
        }

        public float Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public string CodVeiculos
        {
            get
            {
                return codVeiculos;
            }

            set
            {
                codVeiculos = value;
            }
        }

        public string CodPartNum
        {
            get
            {
                return codPartNum;
            }

            set
            {
                codPartNum = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public float Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }

}