using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class Servico
    {
        private int codigo;
        private int CodCliente;
        private int CodCarro;
        private int CodFuncionario;
        private double valorTotal;

        public Servico(int codigo, int codCliente, int codCarro, int codFuncionario, double valorTotal)
        {
            this.codigo = codigo;
            CodCliente = codCliente;
            CodCarro = codCarro;
            CodFuncionario = codFuncionario;
            this.valorTotal = valorTotal;
        }
        public Servico()
        {

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

        public int CodCliente1
        {
            get
            {
                return CodCliente;
            }

            set
            {
                CodCliente = value;
            }
        }

        public int CodCarro1
        {
            get
            {
                return CodCarro;
            }

            set
            {
                CodCarro = value;
            }
        }

        public int CodFuncionario1
        {
            get
            {
                return CodFuncionario;
            }

            set
            {
                CodFuncionario = value;
            }
        }

        public double ValorTotal
        {
            get
            {
                return valorTotal;
            }

            set
            {
                valorTotal = value;
            }
        }
    }
}
