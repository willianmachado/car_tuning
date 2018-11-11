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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.ShowDialog();
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            FormPesquisa form = new FormPesquisa();
            form.ShowDialog();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario form = new FormFuncionario();
            form.ShowDialog();
        }

        private void btPecas_Click(object sender, EventArgs e)
        {
            FormPecas form = new FormPecas();
            form.ShowDialog();
        }

        private void btServicos_Click(object sender, EventArgs e)
        {
            FormServico form = new FormServico();
            form.ShowDialog();
        }
                
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio();
            form.ShowDialog();
            form.StartPosition = FormStartPosition.CenterParent;
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
           
            progressBar1.Value = 50;
            iTalk_ProgressBar1.Value = 75;
            progressBar2.Value = 90;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            iTalk_ProgressBar1.Value = 0;
            progressBar2.Value = 0;
        }
    }
}
