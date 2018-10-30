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
    public partial class FormCarro : Form
    {
        FormCliente f = new FormCliente();

        public FormCarro() 
        {
            InitializeComponent();
            this.f.ControlaBotoes(true);
        }
        

        private void txtAno_TextChanged_1(object sender, EventArgs e)
        {
            lbAno.Text = txtAno.Text;
        }
        
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

            lbMarca.Text = txtMarca.Text;
        }    


        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                MessageBox.Show("Selecione a Marca do carro");
                lbModelo.Text = txtModelo.Text;
            }

            else
            {

                lbMarca.Visible = true;
                lbModelo.Text = txtModelo.Text;
                lbModelo.Visible = true;
                imgCarro.Visible = true;
                lbAno.Visible = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Designar apenas numeros para o txtAno
                if (!char.IsDigit(e.KeyChar))

                {

                    e.Handled = true;

                }
            }


        private void btNovo_Click(object sender, EventArgs e)
        {
            this.f.ControlaBotoes(false);
            limparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            this.f.ControlaBotoes(true);
            limparCampos();

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.f.ControlaBotoes(true);
            btEditar.Enabled = true;
            btSalvar.Enabled = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        public void limparCampos()
        {
            txtCpf.Text = "";
            txtMarca.Text = "";
            txtAno.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }
        

          
    }
}
