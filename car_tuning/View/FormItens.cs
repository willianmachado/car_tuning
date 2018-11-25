using car_tuning.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_tuning.View
{
    public partial class FormItens : Form
    {
        public FormItens()
        {
            InitializeComponent();
        }
        private void FillPecas()
        {
            PecasDAO pecasDAO = new PecasDAO();
            List<Pecas> pecas;
            pecas = pecasDAO.Carregar();
            dgvPecasServ.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvPecasServ.Rows.Add(p.Codigo, p.Compatibilidade, p.Tipo, p.Fabricante, p.Preco, p.Descricao, p.AddTorque, p.AddPotencia, p.AddPeso);

            }

        }

        private void dgvPecasServ_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
