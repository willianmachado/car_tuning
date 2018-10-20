using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class TesteDAO
    {
        private int cod, peso, consumo, potencia, torque;
        private string placa_carro;

        public TesteDAO(int cod, string placa_carro, int peso, int consumo, int potencia, int torque)
        {
            this.Cod = cod;
            this.Placa_carro = placa_carro;
            this.Peso = peso;
            this.Consumo = consumo;
            this.Potencia = potencia;
            this.Torque = torque;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Placa_carro { get => placa_carro; set => placa_carro = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Consumo { get => consumo; set => consumo = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public int Torque { get => torque; set => torque = value; }
    }
}
