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
        private void Fill()
        {
            CarroDAO carroDAO = new CarroDAO();
            List<Carro> carros;
            //carros = carroDAO.Carregar();
            dgvCarro.Rows.Clear();
            //foreach (Carro c in carros)
            //    dgvCarro.Rows.Add();
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
            Carro carro = GetDTO();
            carroDAO.Salvar(carro);
            //dgvCarro.DataSource = c.carregar();

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
            carro.Consumo = Double.Parse(txtPeso.Text);
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
            txtPeso.Text = carro.Consumo.ToString();
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
            txtPeso.Text = "";
            txtCpf.Text = "";
            txtMarca.Text = "";
            txtPeso.Text = "";
            txtPotencia.Text = "";
            txtRotacaoMax.Text = "";
            txtTorque.Text = "";
            txtVelMaxima.Text = "";
            txtConsumo.Text = "";
            pbAceleracao.Value = 0;
            pbConsumo.Value = 0;
            pbPeso.Value = 0;
            pbPotencia.Value = 0;
            pbRotacao.Value = 0;
            pbTorque.Value = 0;
            pbVelocidadeMax.Value = 0;
            
        }

        private void pbFill() {

            int peso = 0;
            int consumo = 0;
            int aceleracao = 0;
            int velocidade = 0;
            int rotacao = 0;
            int torque = 0;
            int potencia = 0;

            if (txtConsumo.Text != "" && consumo < 41)

                try
                {
                    consumo = int.Parse(txtConsumo.Text);
                    pbConsumo.Value = consumo;
                }
                catch
                {
                    MessageBox.Show("O consumo deve ser até 40 km/L");
                    txtConsumo.Text = "";
                    consumo = 1;
                    pbConsumo.Value = consumo;
                }

            if (txtPeso.Text != "" && peso < 2801)

                try
                {
                    peso = int.Parse(txtPeso.Text);
                    pbPeso.Value = peso;
                }
                catch
                {
                    MessageBox.Show("O peso deve ser até 2800 kg");
                    txtPeso.Text = "";
                    peso = 1;
                    pbPeso.Value = peso;
                }

           

            if (txtAceleracao.Text != "" && aceleracao < 31)

                try
                {
                    aceleracao = int.Parse(txtAceleracao.Text);
                    pbAceleracao.Value = aceleracao;
                }
                catch
                {
                    MessageBox.Show("A aceleração deve ser entre 1 e 30 seg");
                    txtAceleracao.Text = "";
                    aceleracao = 1;
                    pbAceleracao.Value = aceleracao;
                }

            if (txtVelMaxima.Text != "" && velocidade < 401)

                try
                {
                    velocidade = int.Parse(txtVelMaxima.Text);
                    pbVelocidadeMax.Value = velocidade;
                }
                catch
                {
                    MessageBox.Show("A velocidade máxima registrada é 400km/h");
                    txtVelMaxima.Text = "";
                    velocidade = 1;
                }

            if (txtRotacaoMax.Text != "" && rotacao < 10001)

                try
                {
                    rotacao = int.Parse(txtRotacaoMax.Text);
                    pbRotacao.Value = rotacao;
                }
                catch
                {
                    MessageBox.Show("Rotação max = 10000");
                    txtRotacaoMax.Text = "";
                    rotacao = 1;
                }

            if (txtTorque.Text != "" && torque < 101)

                try
                {
                    torque = int.Parse(txtTorque.Text);
                    pbTorque.Value = torque;
                }
                catch
                {
                    MessageBox.Show("O torque deve ser até 101 kg");
                    txtTorque.Text = "";
                    torque = 1;
                
                }

            if (txtPotencia.Text != "" && potencia < 1201)

                try
                {
                    potencia = int.Parse(txtPotencia.Text);
                    pbPotencia.Value = potencia;
                }
                catch
                {
                    MessageBox.Show("A potencia maxima registrada é 1200cv");
                    txtPotencia.Text = "";
                    potencia = 1;
                }

            lbAceleracao.Text = aceleracao.ToString();
            lbConsumo.Text = consumo.ToString();
            lbPeso.Text = peso.ToString();
            lbPotencia.Text = potencia.ToString();
            lbRotacao.Text = rotacao.ToString();
            lbTorque.Text = torque.ToString();
            lbVelocidade.Text = velocidade.ToString();
            

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            pbFill();
        }

        private void txtConsumo_TextChanged(object sender, EventArgs e)
        {
            pbFill();
        }

       
    }
    
}
    
