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

        private void limparCampos()
        {
            //Limpar os campos já preenchidos

            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtAno.Text = "";

            
        }

            
        private void ControlaBotoes(bool statusBtNovo)
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

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.Title = "marcas-carro";
            fdlg.InitialDirectory = @"D:\ADS\LP2\marcas-e-modelos";
            fdlg.FileName = txtMarca.Text;
            fdlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtModelo.Text = fdlg.FileName;
                //Import();

                Application.DoEvents();
            }
        }
    }
}
