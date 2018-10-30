using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_tuning
{
    public partial class FormServico : Form
    {
        public FormServico()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }
    }
}
