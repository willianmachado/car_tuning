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
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtAno.Enabled = false;
            
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
            txtEmail.Text = "";
            txtAno.Text = "";
            txtModelo.Text = " ";
            txtPlaca.Text = "";
            txtMarca.Text = " ";



        }

        public void ControlaBotoes(bool statusBtNovo)
        {
            //Habilita e desabilita os botoes de acordo com a atual situação do cadastro
            if (statusBtNovo == true)
            {
                this.btNovo.Enabled = true;
                this.btNovo.ForeColor = Color.White;
                this.btExcluir.Enabled = true;
                this.btExcluir.ForeColor = Color.White;
                this.btEditar.Enabled = true;
                this.btEditar.ForeColor = Color.White;
                this.btSalvar.Enabled = false;
                this.btSalvar.ForeColor = Color.Gray;
                this.btLimpar.Enabled = false;
                this.btLimpar.ForeColor = Color.Gray;
                this.btPesquisar.Enabled = true;
                this.btPesquisar.ForeColor = Color.White;

                this.txtNome.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtTelefone.Enabled = false;
                this.txtAno.Enabled = false;
                this.txtMarca.Enabled = false;
                this.txtModelo.Enabled = false;

            }
            else
            {
                this.btNovo.Enabled = false;
                this.btNovo.ForeColor = Color.Gray;
                this.btExcluir.Enabled = false;
                this.btExcluir.ForeColor = Color.Gray;
                this.btEditar.Enabled = false;
                this.btEditar.ForeColor = Color.Gray;
                this.txtCpf.Enabled = true;
                this.btSalvar.Enabled = true;
                this.btSalvar.ForeColor = Color.White;
                this.btLimpar.Enabled = true;
                this.btLimpar.ForeColor = Color.White;
                this.btPesquisar.Enabled = false;
                this.btPesquisar.ForeColor = Color.Gray;

                this.txtNome.Enabled = true;
                this.txtEmail.Enabled = true;
                this.txtTelefone.Enabled = true;
                this.txtAno.Enabled = true;
                this.txtMarca.Enabled = true;
                this.txtModelo.Enabled = true;
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }
    }
}
