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
        private string CpfCliente;
        private string PlacaCarro;
        private string CpfFuncionario;
        private double valorTotal;
        

        
        public Servico()
        {

        }

        public Servico(int codigo, string cpfCliente, string placaCarro, string cpfFuncionario, double valorTotal)
        {
            this.codigo = codigo;
            CpfCliente = cpfCliente;
            PlacaCarro = placaCarro;
            CpfFuncionario = cpfFuncionario;
            this.valorTotal = valorTotal;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string CpfCliente1 { get => CpfCliente; set => CpfCliente = value; }
        public string PlacaCarro1 { get => PlacaCarro; set => PlacaCarro = value; }
        public string CpfFuncionario1 { get => CpfFuncionario; set => CpfFuncionario = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
