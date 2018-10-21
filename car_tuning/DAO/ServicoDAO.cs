using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class ServicoDAO
    {
        private int cod;
        private string placa_carro, cod_preca, valor_total;
        private long cpf_funcionario, cpf_cliente;

        public ServicoDAO(int cod, string placa_carro, string cod_preca, string valor_total, long cpf_funcionario, long cpf_cliente)
        {
            this.Cod = cod;
            this.Placa_carro = placa_carro;
            this.Cod_preca = cod_preca;
            this.Valor_total = valor_total;
            this.Cpf_funcionario = cpf_funcionario;
            this.Cpf_cliente = cpf_cliente;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Placa_carro { get => placa_carro; set => placa_carro = value; }
        public string Cod_preca { get => cod_preca; set => cod_preca = value; }
        public string Valor_total { get => valor_total; set => valor_total = value; }
        public long Cpf_funcionario { get => cpf_funcionario; set => cpf_funcionario = value; }
        public long Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }
    }
}
