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

        public int Codigo { get => codigo; set => codigo = value; }
        public int CodCliente1 { get => CodCliente; set => CodCliente = value; }
        public int CodCarro1 { get => CodCarro; set => CodCarro = value; }
        public int CodFuncionario1 { get => CodFuncionario; set => CodFuncionario = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
