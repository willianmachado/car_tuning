using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.Modelo
{
    class ServPeca
    {
        private int CodServ;
        private int CodPeca;
        private int quantidade;

        public ServPeca()
        {

        }

        public ServPeca(int codServ, int codPeca, int quantidade)
        {
            CodServ = codServ;
            CodPeca = codPeca;
            this.quantidade = quantidade;
        }

        public int CodServ1 { get => CodServ; set => CodServ = value; }
        public int CodPeca1 { get => CodPeca; set => CodPeca = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
