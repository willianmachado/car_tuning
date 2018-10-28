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

        private void iTalk_GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar7_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar6_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar4_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar3_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar5_Click(object sender, EventArgs e)
        {

        }

        private void mephProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label18_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label12_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label11_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label9_Click(object sender, EventArgs e)
        {

        }

        private void lbAno_Click(object sender, EventArgs e)
        {

        }

        private void lbMarca_Click(object sender, EventArgs e)
        {

        }

        private void lbModelo_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label10_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label21_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label19_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label17_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label16_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label15_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label14_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label13_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label5_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_Label8_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label7_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label6_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label4_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label3_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void scPanel_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
