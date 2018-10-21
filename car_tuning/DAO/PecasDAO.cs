using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class PecasDAO
    {
        private int cod, addpotencia, addtorque, addpeso;
        private string descricao, tipo, compatibilidade;
        private double valor;

        public PecasDAO(int cod, int addpotencia, int addtorque, int addpeso, string descricao, string tipo, string compatibilidade, double valor)
        {
            this.Cod = cod;
            this.Addpotencia = addpotencia;
            this.Addtorque = addtorque;
            this.Addpeso = addpeso;
            this.Descricao = descricao;
            this.Tipo = tipo;
            this.Compatibilidade = compatibilidade;
            this.Valor = valor;
        }

        public int Cod { get => cod; set => cod = value; }
        public int Addpotencia { get => addpotencia; set => addpotencia = value; }
        public int Addtorque { get => addtorque; set => addtorque = value; }
        public int Addpeso { get => addpeso; set => addpeso = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Compatibilidade { get => compatibilidade; set => compatibilidade = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
