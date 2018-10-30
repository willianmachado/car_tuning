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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            ControlaBotoes(true);
            
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            limparCampos();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            ControlaBotoes(false);
            limparCampos();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            btEditar.Enabled = true;
            btSalvar.Enabled = false;
        }

        public void limparCampos()
        {
            //Limpar os campos já preenchidos

            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtAno.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtMarca.Text = "";



        }

        public void ControlaBotoes(bool statusBtNovo)
        {
            //Habilita e desabilita os botoes de acordo com a atual situação do cadastro
            if (statusBtNovo == true)
            {
                btNovo.Enabled = true;
                btNovo.ForeColor = Color.White;
                btExcluir.Enabled = true;
                btExcluir.ForeColor = Color.White;
                btEditar.Enabled = true;
                btEditar.ForeColor = Color.White;
                btSalvar.Enabled = false;
                btSalvar.ForeColor = Color.Gray;
                btLimpar.Enabled = false;
                btLimpar.ForeColor = Color.Gray;
                btPesquisar.Enabled = true;
                btPesquisar.ForeColor = Color.White;

            }
            else
            {
                btNovo.Enabled = false;
                btNovo.ForeColor = Color.Gray;
                btExcluir.Enabled = false;
                btExcluir.ForeColor = Color.Gray;
                btEditar.Enabled = false;
                btEditar.ForeColor = Color.Gray;
                txtCpf.Enabled = true;
                btSalvar.Enabled = true;
                btSalvar.ForeColor = Color.White;
                btLimpar.Enabled = true;
                btLimpar.ForeColor = Color.White;
                btPesquisar.Enabled = false;
                btPesquisar.ForeColor = Color.Gray;
            }
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
                     
             
            
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            lbAno.Text = txtAno.Text;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            lbMarca.Text = txtMarca.Text;
        }

        private void txtModelo_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
