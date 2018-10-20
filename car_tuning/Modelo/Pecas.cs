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


        public Pecas()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public float Preco { get => preco; set => preco = value; }
        public string CodVeiculos { get => codVeiculos; set => codVeiculos = value; }
        public string CodPartNum { get => codPartNum; set => codPartNum = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Status { get => status; set => status = value; }
    }
}
