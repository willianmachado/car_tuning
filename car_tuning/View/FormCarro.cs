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
    public partial class FormCarro : Form
    {

        CarroDAO c = new CarroDAO();

        public FormCarro() 
        {
            InitializeComponent();
        }
        

        private void txtAno_TextChanged_1(object sender, EventArgs e)
        {

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
                lbModelo.Text = txtMarca.Text;
            }

            else
            {

                lbMarca.Visible = true;
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
            ControlaBotoes(false);
            limparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CarroDAO carroDAO = new CarroDAO();
            Carro carro = new Carro();
            if (txtCpf.Text != "")
            {
                carroDAO.Salvar(carro);
                //dgvCarro.DataSource = c.carregar();
            }
            else
            {
                MessageBox.Show(this, "Favor preencher os campos ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            limparCampos();

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            btEditar.Enabled = true;
            btSalvar.Enabled = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroCarro form = new FormCadastroCarro();
            form.Show();
        }

        private void btnCadVeiNovo_Click(object sender, EventArgs e)
        {
            FormCadastroCarro formCadCarro = new FormCadastroCarro();
            formCadCarro.ShowDialog(this);
            formCadCarro.StartPosition = FormStartPosition.CenterParent;
        }

        private Carro GetDTO()
        {
            Carro carro = new Carro();
            carro.Aceleracao = Double.Parse(txtAceleracao.Text);
            carro.Consumo = Double.Parse(txtConsumo.Text);
            carro.Peso = Double.Parse(txtPeso.Text);
            carro.Potencia = Double.Parse(txtPotencia.Text);
            carro.VelocidadeMax = Double.Parse(txtVelMaxima.Text);
            carro.Torque = Double.Parse(txtTorque.Text);
            carro.Aceleracao = Double.Parse(txtAceleracao.Text);
            carro.RotacaoMax = Double.Parse(txtRotacaoMax.Text);
            return carro;
        }

        private void setDTO(Carro carro)
        {
            txtAceleracao.Text = carro.Aceleracao.ToString();
            txtConsumo.Text = carro.Consumo.ToString();
            txtPeso.Text = carro.Peso.ToString();
            txtPotencia.Text = carro.Potencia.ToString();
            txtVelMaxima.Text = carro.VelocidadeMax.ToString();
            txtTorque.Text = carro.Torque.ToString();
            txtAceleracao.Text = carro.Aceleracao.ToString();
            txtRotacaoMax.Text = carro.RotacaoMax.ToString();
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
            txtConsumo.Text = "";
            txtCpf.Text = "";
            txtMarca.Text = "";
            txtPeso.Text = "";
            txtPotencia.Text = "";
            txtRotacaoMax.Text = "";
            txtTorque.Text = "";
            txtVelMaxima.Text = "";

        }

        private void pbPeso_Validated(object sender, EventArgs e)
        {
            
            int peso = 0;
            peso = int.Parse(txtPeso.Text);

            if (peso != 0 && peso < 2801)
            {
                pbPeso.Value = peso;
            }

            if (peso > 2800)
            {
                MessageBox.Show("O peso deve ser inferior a 2800 kg");
                txtPeso.Text = "0";
                peso = 1;
            }
        }
    }
}
