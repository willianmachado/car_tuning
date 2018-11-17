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
        private string fabricante;
        private Double preco;
        private string compatibilidade;
        private string tipo;
        private string descricao;
        private Double addTorque;
        private Double addPeso;
        private Double addPotencia;

        public Pecas(int codigo, string fabricante, double preco, string compatibilidade, string tipo, string descricao, double addTorque, double addPeso, double addPotencia)
        {
            this.codigo = codigo;
            this.fabricante = fabricante;
            this.preco = preco;
            this.compatibilidade = compatibilidade;
            this.tipo = tipo;
            this.descricao = descricao;
            this.addTorque = addTorque;
            this.addPeso = addPeso;
            this.addPotencia = addPotencia;
        }
        public Pecas()
        {

        }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Compatibilidade { get => compatibilidade; set => compatibilidade = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double AddTorque { get => addTorque; set => addTorque = value; }
        public double AddPeso { get => addPeso; set => addPeso = value; }
        public double AddPotencia { get => addPotencia; set => addPotencia = value; }
    }

}