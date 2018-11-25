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
            FillPecas();
            FormItens formItens = new FormItens();
            formItens.ShowDialog();
            formItens.StartPosition = FormStartPosition.CenterParent;
        }
    }

    
}

