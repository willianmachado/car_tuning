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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }



        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa form = new FormPesquisa();
            form.ShowDialog();
        }

        private void btLimpar_Click( object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
