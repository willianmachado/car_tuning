using car_tuning.DAO;
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
        MarcaDAO m = new MarcaDAO();
        public FormCarro()
        {
            InitializeComponent();
            ControlaBotoes(true);
            Fill();
        }
        
        public void Fill()
        {
            List<Carro> cars;
            cars = c.Carregar();
            dgvCarro.Rows.Clear();

            foreach (Carro c in cars)
            {
                dgvCarro.Rows.Add(c.Placa, c.CpfCliente, c.Ano, c.Marca, c.Modelo, c.Peso, c.Potencia, c. VelocidadeMax, c. Torque, c.Aceleracao, c.Consumo, c.RotacaoMax);

                
            }


            List<Marca> marcas;
            MarcaDAO marca = new MarcaDAO();
            txtMarca.Items.Clear();
            
            marcas = marca.Carregar();
            
            foreach (Marca m in marcas)
                txtMarca.Items.Add(m.Nome);


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
            txtEnable(true);
            limparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CarroDAO carroDAO = new CarroDAO();
            Carro carro = GetDTO();
            carroDAO.Salvar(carro);
            Fill();

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

            if (txtCpf.Text == "")
            {
                MessageBox.Show(this, "Clique duplo para excluir", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            if (MessageBox.Show(" Deseja excluir o carro selecionado? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ClienteDAO clienteDAO = new ClienteDAO();
                string index = (dgvCarro.CurrentRow.Cells[0].Value.ToString());


                Carro carro = GetDTO();
                c.Deletar(index);

                Fill();
                MessageBox.Show("Carro excluido");
                limparCampos();
            }
        }
        
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }
        
        private Carro GetDTO()
        {
            Carro carro = new Carro();

            carro.CpfCliente = txtCpf.Text;
            carro.Placa = txtPlaca.Text;
            carro.Ano = txtAno.Text;
            carro.Marca = txtMarca.Text.Trim();
            carro.Modelo = txtModelo.Text;
            carro.Peso = int.Parse(txtPeso.Text);
            carro.Potencia = int.Parse(txtPotencia.Text);
            carro.VelocidadeMax = int.Parse(txtVelocidadeMax.Text);
            carro.Torque = int.Parse(txtTorque.Text);
            carro.Aceleracao = int.Parse(txtAceleracao.Text);
            carro.Consumo = int.Parse(txtConsumo.Text);
            carro.RotacaoMax = int.Parse(txtRotacaoMax.Text);



            return carro;
        }

        private void setDTO(Carro carro)
        {
            
            txtAno.Text = carro.Ano.ToString();
            txtPlaca.Text = carro.Placa.ToString();
            //txtMarca.Text = carro.Marca.ToString();
           // txtModelo.Text = carro.Modelo.ToString();
            txtCpf.Text = carro.CpfCliente.ToString();
            
            
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
                txtEnable(false);

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
                txtEnable(true);
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
            txtVelocidadeMax.Text = "";
            txtConsumo.Text = "";
            txtAno.Text = "";
            txtPlaca.Text = "";
            txtModelo.Text = "";
            pbAceleracao.Value = 0;
            pbConsumo.Value = 0;
            pbPeso.Value = 0;
            pbPotencia.Value = 0;
            pbRotacao.Value = 0;
            pbTorque.Value = 0;
            pbVelocidadeMax.Value = 0;
            
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            pbFill();
        }

        private void txtConsumo_TextChanged(object sender, EventArgs e)
        {
            pbFill();
        }

        private void pbFill()
        {

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

            if (txtVelocidadeMax.Text != "" && velocidade < 401)

                try
                {
                    velocidade = int.Parse(txtVelocidadeMax.Text);
                    pbVelocidadeMax.Value = velocidade;
                }
                catch
                {
                    MessageBox.Show("A velocidade máxima registrada é 400km/h");
                    txtVelocidadeMax.Text = "";
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

        private void txtEnable(bool status)
        {
            if (status == true)
            {
                txtAceleracao.Enabled = true;
                txtAno.Enabled = true;
                txtConsumo.Enabled = true;
                txtCpf.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                txtPeso.Enabled = true;
                txtPlaca.Enabled = true;
                txtPotencia.Enabled = true;
                txtRotacaoMax.Enabled = true;
                txtTorque.Enabled = true;
                txtVelocidadeMax.Enabled = true;
            }
            else
            {
                txtAceleracao.Enabled = false;
                txtAno.Enabled = false;
                txtConsumo.Enabled = false;
                txtCpf.Enabled = false;
                txtMarca.Enabled = false;
                txtModelo.Enabled = false;
                txtPeso.Enabled = false;
                txtPlaca.Enabled = false;
                txtPotencia.Enabled = false;
                txtRotacaoMax.Enabled = false;
                txtTorque.Enabled = false;
                txtVelocidadeMax.Enabled = false;
            }
        }

        private void btnBuscaIMG_Click(object sender, EventArgs e)
        {
            if (SfdCarro.ShowDialog() == DialogResult.OK)
            {
                
                imgCarro.Image = Image.FromFile(SfdCarro.FileName);
                imgCarro.Show();
                
            }
        }

        private void NovaMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.StartPosition = FormStartPosition.CenterScreen;
            formMarca.Show(this);
            Fill();
        }

        private void txtMarca_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCarro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPlaca.Text = dgvCarro.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCpf.Text = dgvCarro.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAno.Text = dgvCarro.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMarca.Text = dgvCarro.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtModelo.Text = dgvCarro.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPeso.Text = dgvCarro.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPotencia.Text = dgvCarro.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTorque.Text = dgvCarro.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtVelocidadeMax.Text = dgvCarro.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtAceleracao.Text = dgvCarro.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtConsumo.Text = dgvCarro.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtRotacaoMax.Text = dgvCarro.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }
    }
    
}
    
