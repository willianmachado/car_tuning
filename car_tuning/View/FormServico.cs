using car_tuning.DAO;
using car_tuning.Modelo;
using car_tuning.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_tuning
{
    public partial class FormServico : Form
    {
        

        public FormServico()
        {
            InitializeComponent();
            ControlaBotoes(true);
            dgvCarrinho.Visible = false;
            
        }
        private void FillPecas()
        {
            PecasDAO pecasDAO = new PecasDAO();
            List<Pecas> pecas;
            pecas = pecasDAO.Carregar();
            dgvPecasServ.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvPecasServ.Rows.Add(p.Codigo,p.Compatibilidade,p.Tipo,p.Fabricante,p.Preco,p.Descricao,p.AddTorque,p.AddPotencia,p.AddPeso);

            }

        }
        public void addItens()
        {
            //PecasDAO pecasDAO = new PecasDAO();
            //FormPesquisa pesquisa = new FormPesquisa();
            //List<Pecas> pecas;
            //List<int> itens = new List<int>();




            



            //pecas = pecasDAO. Carregar();
            //dgvCarrinho.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvCarrinho.Rows.Add(p.Codigo, p.Compatibilidade, p.Tipo, p.Fabricante, p.Preco, p.Descricao, p.AddTorque, p.AddPotencia, p.AddPeso);

            }


        }

        private void dgvCarrinho_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pecas.Remove(pecasDAO.Listar(dgvPecasServ.Rows[e.RowIndex].Cells[0].Value.ToString());
            //= pecasDAO.Listar(dgvPecasServ.Rows[e.RowIndex].Cells[0].Value.ToString());
            //dgvCarrinho.Rows.Remove();
            //Cells[0].Value.ToString();
        }
        PecasDAO pecasDAO = new PecasDAO();
        List<Pecas> pecas;
        List<int> itens = new List<int>();
        double preco=0; 
        private void dgvPecasServ_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            pecas = pecasDAO.Listar(dgvPecasServ.Rows[e.RowIndex].Cells[0].Value.ToString());
            itens.Add(int.Parse(dgvPecasServ.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()));
            preco += double.Parse(dgvPecasServ.Rows[e.RowIndex].Cells[4].Value.ToString());
            dgvPecasServ.CurrentRow.Cells[0].Style.BackColor = Color.Yellow;
            foreach (Pecas p in pecas)
            {

                dgvCarrinho.Rows.Add(p.Codigo, p.Tipo, p.Fabricante, p.Preco, p.Descricao);
                
            }
            //dgvCarrinho.Rows[e.RowIndex].Cells[5].Value = 1;
            rtValor.Text = preco.ToString();
        }
        private void Loading()
        {
            View.FormLoading f  = new View.FormLoading();
            f.ShowDialog();

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo cancelar o serviço? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Iniciar Serviço?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Serviço Concluído");
            }
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
        private void btSalvar_Click(object sender, EventArgs e)
        {
            StageDAO stageDAO = new StageDAO();
            Stage stage = getDTO();
            stageDAO.Salvar(stage);
            
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            

        }
        public void fillCliente()
        {
            List<Cliente> clientes;
            ClienteDAO clienteDAO = new ClienteDAO();
            txtCliente.Items.Clear();

            clientes = clienteDAO.Carregar();
            foreach (Cliente c in clientes)
                txtCliente.Items.Add(c.Cpf);
        }
        public void fillCarro()
        {
            List<Carro> carros;
            CarroDAO cDAO = new CarroDAO();
            txtCarro.Items.Clear();
            carros = cDAO.Carregar();
            foreach (Carro ca in carros)
                txtCarro.Items.Add(ca.Placa);
        }
        public void fillFuncionario()
        {
            List<Funcionario> funcionarios;
            FuncionarioDAO fDAO = new FuncionarioDAO();
            txtFunc.Items.Clear();
            funcionarios = fDAO.Carregar();
            foreach (Funcionario f in funcionarios)
                txtFunc.Items.Add(f.Cpf);
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
                this.txtCod.Enabled = true;
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
            txtCod.Text = "";
            txtCarro.Text = "";
            txtCliente.Text = "";
            txtFunc.Text = "";
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Executar o Serviço? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //para chamar o splash
                Thread t = new Thread((new ThreadStart(Loading)));
                ////inicializar a thread
                t.Start();
                Thread.Sleep(2000);
                t.Abort();

                MessageBox.Show("Serviço encaminhado com sucesso!");
            }

            else
            {
                MessageBox.Show("Serviço cancelado");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o Serviço? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
        }


        private Stage getDTO()
        {
            Stage stage = new Stage();
            stage.CodServ1 = int.Parse(txtCod.Text);
            stage.PesoIni = double.Parse(txtPesoIni.Text);
            stage.PotenciaIni = double.Parse(txtPotenciaIni.Text);
            stage.Velocidade_maxIni = double.Parse(txtVeloMaxIni.Text);
            stage.TorqueIni = double.Parse(txtTorqueIni.Text);
            stage.AceleracaoIni = double.Parse(txtAceleIni.Text);
            stage.ConsumoIni = double.Parse(txtConsumoIni.Text);
            stage.Rotacao_maxIni = double.Parse(txtRotMaxIni.Text);

            stage.PesoFin = double.Parse(txtPesoFin.Text);
            stage.PotenciaFin = double.Parse(txtPotenciaFin.Text);
            stage.Velocidade_maxFin = double.Parse(txtVelocMaxFin.Text);
            stage.TorqueFin = double.Parse(txtTorqueFin.Text);
            stage.AceleracaoFin = double.Parse(txtAceleFin.Text);
            stage.ConsumoFin = double.Parse(txtConsumoFin.Text);
            stage.Rotacao_maxFin = double.Parse(txtRotaMaxFin.Text);

            return stage;
        }

        private void setDTO(Servico s)
        {

        }

        private void txtCliente_Click(object sender, EventArgs e)
        {
            fillCliente();
        }

        private void txtFunc_Click(object sender, EventArgs e)
        {
            fillFuncionario();
        }

        private void txtCarro_Click(object sender, EventArgs e)
        {
            fillCarro();
        }

        private void btnBuscarPeca_Click(object sender, EventArgs e)
        {
            dgvCarrinho.Visible = true;
            FillPecas();
            
        }

        private void btnRemoverPeca_Click(object sender, EventArgs e)
        {
            dgvCarrinho.Visible = false;
        }


        /*
        private void pbFill()
        {

            int peso = 0;
            int consumo = 0;
            int aceleracao = 0;
            int velocidade = 0;
            int rotacao = 0;
            int torque = 0;
            int potencia = 0;

            if ((txtConsumoIni.Text != "" && consumo < 41)||(txtConsumoFin.Text != "" && consumo < 41))

                try
                {
                    consumo = int.Parse(txtConsumoIni.Text);
                    pbConsumoIni.Value = consumo;
                }
                catch
                {
                    MessageBox.Show("O consumo deve ser até 40 km/L");
                    txtConsumo.Text = "";
                    consumo = 1;
                    pbConsumoIni.Value = consumo;
                }

            if (txtPeso.Text != "" && peso < 2801)

                try
                {
                    peso = int.Parse(txtPeso.Text);
                    pbPesoIni.Value = peso;
                }
                catch
                {
                    MessageBox.Show("O peso deve ser até 2800 kg");
                    txtPeso.Text = "";
                    peso = 1;
                    pbPesoIni.Value = peso;
                }



            if (txtAceleracao.Text != "" && aceleracao < 31)

                try
                {
                    aceleracao = int.Parse(txtAceleracao.Text);
                    pbAceleracaoIni.Value = aceleracao;
                }
                catch
                {
                    MessageBox.Show("A aceleração deve ser entre 1 e 30 seg");
                    txtAceleracao.Text = "";
                    aceleracao = 1;
                    pbAceleracaoIni.Value = aceleracao;
                }

            if (txtVelocidadeMax.Text != "" && velocidade < 401)

                try
                {
                    velocidade = int.Parse(txtVelocidadeMax.Text);
                    pbVelocidadeMaxIni.Value = velocidade;
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
                    pbRotacaoIni.Value = rotacao;
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
                    pbTorqueIni.Value = torque;
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
                    pbPotenciaIni.Value = potencia;
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

        */
    }


}

