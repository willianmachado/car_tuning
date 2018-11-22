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
    public partial class FormCadastroCarro : Form
    {
        CarroDAO c = new CarroDAO();

        public FormCadastroCarro()
        {
            InitializeComponent();
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            ControlaBotoes(false);
            limparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CarroDAO carroDAO = new CarroDAO();
            Carro carro = GetDTO();
            carroDAO.Salvar(carro);
            //dgvCarro.DataSource = c.carregar();

            dgCarroOriginal.DataSource = c.Carregar();
            try

            {
                MessageBox.Show("Cadastrado com sucesso!");
                ControlaBotoes(true);
                limparCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("DEU RUIM");

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
        private void FormCadastroCarro_Load(object sender, EventArgs e)
        {

            dgCarroOriginal.DataSource = c.Carregar();
        }



        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            }
            else
            {
                this.btNovo.Enabled = false;
                this.btNovo.ForeColor = Color.Gray;
                this.btExcluir.Enabled = false;
                this.btExcluir.ForeColor = Color.Gray;
                this.btEditar.Enabled = false;
                this.btEditar.ForeColor = Color.Gray;
                this.btSalvar.Enabled = true;
                this.btSalvar.ForeColor = Color.White;
                this.btLimpar.Enabled = true;
                this.btLimpar.ForeColor = Color.White;
                this.btPesquisar.Enabled = false;
                this.btPesquisar.ForeColor = Color.Gray;
            }
        }
        public void limparCampos()
        {
            txtAceleracao.Text = "";
            txtCod.Text = "";
            txtConsumo.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPeso.Text = "";
            txtPotencia.Text = "";
            txtRotacaoMax.Text = "";
            txtTorque.Text = "";
            txtVelMaxima.Text = "";
        }

        private Carro GetDTO()
        {
            Carro carro = new Carro();
            

            return carro;
        }

        private void setDTO(Carro carro)
        {
            
        }

    }
}
