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
        private int CpfCliente;
        private int PlacaCarro;
        private int CpfFuncionario;
        private double valorTotal;
        private double  pesoIni, aceleracaoIni, torqueIni, potenciaIni, velocidadeMaxIni, consumoIni, rotacaoMaxIni;
        private double  pesoFin, aceleracaoFin, torqueFin, potenciaFin, velocidadeMaxFin, consumoFin, rotacaoMaxFin;

        
        public Servico()
        {

        }

        public Servico(int codigo, int cpfCliente, int placaCarro, int cpfFuncionario, double valorTotal)
        {
            this.codigo = codigo;
            CpfCliente = cpfCliente;
            PlacaCarro = placaCarro;
            CpfFuncionario = cpfFuncionario;
            this.valorTotal = valorTotal;
        }

        public double PesoIni { get => pesoIni; set => pesoIni = value; }
        public double AceleracaoIni { get => aceleracaoIni; set => aceleracaoIni = value; }
        public double TorqueIni { get => torqueIni; set => torqueIni = value; }
        public double PotenciaIni { get => potenciaIni; set => potenciaIni = value; }
        public double VelocidadeMaxIni { get => velocidadeMaxIni; set => velocidadeMaxIni = value; }
        public double ConsumoIni { get => consumoIni; set => consumoIni = value; }
        public double RotacaoMaxIni { get => rotacaoMaxIni; set => rotacaoMaxIni = value; }
        public double PesoFin { get => pesoFin; set => pesoFin = value; }
        public double AceleracaoFin { get => aceleracaoFin; set => aceleracaoFin = value; }
        public double TorqueFin { get => torqueFin; set => torqueFin = value; }
        public double PotenciaFin { get => potenciaFin; set => potenciaFin = value; }
        public double VelocidadeMaxFin { get => velocidadeMaxFin; set => velocidadeMaxFin = value; }
        public double ConsumoFin { get => consumoFin; set => consumoFin = value; }
        public double RotacaoMaxFin { get => rotacaoMaxFin; set => rotacaoMaxFin = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int CpfCliente1 { get => CpfCliente; set => CpfCliente = value; }
        public int PlacaCarro1 { get => PlacaCarro; set => PlacaCarro = value; }
        public int CpfFuncionario1 { get => CpfFuncionario; set => CpfFuncionario = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
