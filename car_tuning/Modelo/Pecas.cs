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

        public double Preco
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

        public string Compatibilidade
        {
            get
            {
                return compatibilidade;
            }

            set
            {
                compatibilidade = value;
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public double AddTorque
        {
            get
            {
                return addTorque;
            }

            set
            {
                addTorque = value;
            }
        }

        public double AddPeso
        {
            get
            {
                return addPeso;
            }

            set
            {
                addPeso = value;
            }
        }

        public double AddPotencia
        {
            get
            {
                return addPotencia;
            }

            set
            {
                addPotencia = value;
            }
        }

        public Pecas(int codigo, string descricao, double preco,  string fabricante, string tipo, string compatibilidade,  double addPeso, double addPotencia, double addTorque)
        {
            this.Codigo = codigo;
            this.Fabricante = fabricante;
            this.Preco = preco;
            this.Compatibilidade = compatibilidade;
            this.Tipo = tipo;
            this.Descricao = descricao;
            this.AddTorque = addTorque;
            this.AddPeso = addPeso;
            this.AddPotencia = addPotencia;
        }
        public Pecas()
        {

        }
        
    }

}