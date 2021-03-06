﻿using car_tuning.DAO;
using car_tuning.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
        }

        public void fillMarca()
        {
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
           
            Carro carro = GetDTO();

            if (txtCpf.Text != "")
            {
                if (btSalvar.Text == "Salvar")
                {
                    c.Salvar(carro);
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                else
                {
                    c.Atualizar(carro);
                    MessageBox.Show("Atualizado com Sucesso!");
                    btSalvar.Text = "Salvar";
                }

              
                    Fill();
                    ControlaBotoes(true);
                    limparCampos();
               
            }

            else
            {
                MessageBox.Show(this, "Favor preencher os dados ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            limparCampos();

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != "")
            {
                btSalvar.Text = "Atualizar";

                ControlaBotoes(false);
                txtCpf.Enabled = false;

            }

            else
            {
                MessageBox.Show("Clique duplo para editar");

            }
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

            carro.Placa = txtPlaca.Text;
            carro.CpfCliente = txtCpf.Text;
            carro.Ano = txtAno.Text;
            carro.Marca = txtMarca.Text.Trim();
            carro.Modelo = txtModelo.Text;
            carro.Peso = 0;
            carro.Potencia = 0;
            carro.VelocidadeMax = 0;
            carro.Torque = 0;
            carro.Aceleracao = 0;
            carro.Consumo = 0;
            carro.RotacaoMax = 0;

    

            return carro;
        }

        private void setDTO(Carro carro)
        {
            
            txtAno.Text = carro.Ano.ToString();
            txtPlaca.Text = carro.Placa.ToString();
            txtMarca.Text = carro.Marca.ToString();
            txtModelo.Text = carro.Modelo.ToString();
            txtCpf.Text = carro.CpfCliente.ToString();
            txtAceleracao.Text = carro.Aceleracao.ToString();
            txtPeso.Text = carro.Peso.ToString();
            txtPotencia.Text = carro.Potencia.ToString();
            txtRotacaoMax.Text = carro.RotacaoMax.ToString();
            txtTorque.Text = carro.Torque.ToString();
            txtVelocidadeMax.Text = carro.VelocidadeMax.ToString();
            txtConsumo.Text = carro.Consumo.ToString();




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
        string fp = @"C:\Users\wdragon8\Documents\LP2\car_tuning\car_tuning\IMG\";
        private void btnBuscaIMG_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(fp))
            {
                Directory.CreateDirectory(fp);
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "c:\\";
                open.Filter = "Image Files(*.jpg|*.jpg|All Files(*.*)|*.*)";
                open.FilterIndex = 1;
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        System.IO.File.Copy(open.FileName, @fp + txtPlaca.Text + ".jpg");
                        pBox.Image = Image.FromFile(@fp + txtPlaca.Text + ".jpg");
                    }
                }
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "c:\\";
                open.Filter = "Image Files(*.jpg|*.jpg|All Files(*.*)|*.*)";
                open.FilterIndex = 1;
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        System.IO.File.Copy(open.FileName, @fp + txtPlaca.Text + ".jpg");
                        pBox.Image = Image.FromFile(@fp + txtPlaca.Text + ".jpg");
                    }
                }
            }
        }

        private void NovaMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.StartPosition = FormStartPosition.CenterScreen;
            formMarca.Show(this);
            Fill();
            fillMarca();
        }

        private void txtMarca_Click(object sender, EventArgs e)
        {
            fillMarca();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            List<Carro> carros;
            carros = c.Listar(txtPesquisa.Text);
            dgvCarro.Rows.Clear();

            foreach (Carro c in carros)
                dgvCarro.Rows.Add(c.Placa, c.CpfCliente, c.Ano, c.Marca, c.Modelo, c.Peso, c.Potencia, c.VelocidadeMax, c.Torque, c.Aceleracao, c.Consumo, c.RotacaoMax);

        }

        private void dgvCarro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fill();
            if (e.RowIndex >= 0)
            {
                txtPlaca.Text = dgvCarro.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCpf.Text = dgvCarro.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAno.Text = dgvCarro.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMarca.Text = dgvCarro.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtModelo.Text = dgvCarro.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPeso.Text = dgvCarro.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPotencia.Text = dgvCarro.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtVelocidadeMax.Text = dgvCarro.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtTorque.Text = dgvCarro.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtAceleracao.Text = dgvCarro.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtConsumo.Text = dgvCarro.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtRotacaoMax.Text = dgvCarro.Rows[e.RowIndex].Cells[11].Value.ToString();
                try
                {
                    pBox.Image = Image.FromFile(@fp + txtPlaca.Text + ".jpg");
                }
                catch
                {

                }

            }
        }

        private void txtCpf_Click(object sender, EventArgs e)
        {
            
            fillCliente();
        }

        public void fillCliente()
        {
            List<Cliente> clientes;
            ClienteDAO clienteDAO = new ClienteDAO();
            txtCpf.Items.Clear();

            clientes = clienteDAO.Carregar();
            foreach (Cliente c in clientes)
            {
                txtCpf.Items.Add(c.Cpf);

            }



        }
    }
    
}
    
