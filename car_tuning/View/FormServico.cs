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
            Carrinho(false);

            ServicoDAO s = new ServicoDAO();
            labalCodigo.Text = (s.BuscaCodigo() + 1).ToString();

        }
        public void Carrinho(bool estado)
        {
            if(estado == true)
            {
                dgvCarrinho.Visible = true;
                txtQuant.Visible = true;
                labalQuant.Visible = true;

                labalCodigo.Visible = false;
                txtFunc.Visible = false;
                txtCliente.Visible = false;
                txtCarro.Visible = false;
                labalCod.Visible = false;
                LabelCarro.Visible = false;
                LabelCli.Visible = false;
                LabelFunc.Visible = false;
                lbCpfCliente.Visible = false;
                lbCpfFunc.Visible = false;
                lbPlacaCarro.Visible = false;
            }
            else if (estado == false)
            {
                dgvCarrinho.Visible = false;
                txtQuant.Visible = false;
                labalQuant.Visible = false;

                labalCodigo.Visible = true;
                txtFunc.Visible = true;
                txtCliente.Visible = true;
                txtCarro.Visible = true;
                labalCod.Visible = true;
                LabelCarro.Visible = true;
                LabelCli.Visible = true;
                LabelFunc.Visible = true;
                lbCpfCliente.Visible = true;
                lbCpfFunc.Visible = true;
                lbPlacaCarro.Visible = true;
            }
            
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

     
        
        PecasDAO pecasDAO = new PecasDAO();
        List<Pecas> pecas;
        List<int> itens = new List<int>();

        double preco=0;
        double consumo = 0;
        double peso = 0;
        double potencia = 0;
        double velocidade = 0;
        double torque = 0;
        double aceleracao = 0;

        private void dgvCarrinho_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCarrinho.Rows.Count > 0)
            {
                preco -= (double.Parse(dgvCarrinho.CurrentRow.Cells["Column5preco"].Value.ToString()) * (double.Parse(dgvCarrinho.CurrentRow.Cells["quantidade"].Value.ToString())));
                peso -= (double.Parse(dgvCarrinho.CurrentRow.Cells["colPeso"].Value.ToString()) * (double.Parse(dgvCarrinho.CurrentRow.Cells["quantidade"].Value.ToString())));
                potencia -= (double.Parse(dgvCarrinho.CurrentRow.Cells["colPotencia"].Value.ToString()) * (double.Parse(dgvCarrinho.CurrentRow.Cells["quantidade"].Value.ToString())));
                torque -= (double.Parse(dgvCarrinho.CurrentRow.Cells["colTorque"].Value.ToString()) * (double.Parse(dgvCarrinho.CurrentRow.Cells["quantidade"].Value.ToString())));

                dgvCarrinho.Rows.RemoveAt(this.dgvCarrinho.CurrentRow.Index);


                
                 consumo = 0;
                 peso = 0;
                 potencia = 0;
                 velocidade = 0;
                 torque = 0;
                 aceleracao = 0;


                lbPesoIni.Text = peso.ToString();
                lbConsumoIni.Text = consumo.ToString();
                lbPotenciaIni.Text = potencia.ToString();
                lbVelocidadeIni.Text = velocidade.ToString();
                lbTorqueIni.Text = torque.ToString();
                lbAceleracaoIni.Text = aceleracao.ToString();

                rtValor.Text = preco.ToString();
            }
            else
            {
                MessageBox.Show("Adicione ao carrinho com o duplo click.");

            }

        }

        private void dgvPecasServ_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(txtQuant.Text != "")
            {
                
                pecas = pecasDAO.Listar(dgvPecasServ.Rows[e.RowIndex].Cells[0].Value.ToString());
                itens.Add(int.Parse(dgvPecasServ.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()));
                
                dgvPecasServ.CurrentRow.Cells[0].Style.BackColor = Color.Yellow;

                foreach (Pecas p in pecas)
                {
                    dgvCarrinho.Rows.Add(p.Codigo, p.Tipo, p.Fabricante, p.Preco, p.Descricao,txtQuant.Text, p.AddTorque, p.AddPotencia, p.AddPeso);
                    preco += (double.Parse(p.Preco.ToString()) * (double.Parse(txtQuant.Text)));
                    peso += double.Parse(txtPesoIni.Text) + (double.Parse(p.AddPeso.ToString()) * (double.Parse(txtQuant.Text)));
                    potencia += double.Parse(txtPotenciaIni.Text) + (double.Parse(p.AddPotencia.ToString()) * (double.Parse(txtQuant.Text)));
                    torque += double.Parse(txtTorqueIni.Text) + (double.Parse(p.AddTorque.ToString()) * (double.Parse(txtQuant.Text)));

                }


                if (dgvCarrinho != null)
                {

                    txtQuant.Value = 1;
                    consumo = peso * 0.002 + double.Parse(txtConsumoIni.Text);
                    velocidade = potencia * 0.07 + double.Parse(txtVeloMaxIni.Text);
                    aceleracao = double.Parse(txtAceleIni.Text) - (torque * 0.009);

                    
                    lbPesoIni.Text = peso.ToString();
                    lbPesoIni.Visible = true;
                    lbConsumoIni.Text = consumo.ToString();
                    lbConsumoIni.Visible = true;
                    lbPotenciaIni.Text = potencia.ToString();
                    lbPotenciaIni.Visible = true;
                    lbVelocidadeIni.Text = velocidade.ToString();
                    lbVelocidadeIni.Visible = true;
                    lbTorqueIni.Text = torque.ToString();
                    lbTorqueIni.Visible = true;
                    lbAceleracaoIni.Text = aceleracao.ToString();
                    lbAceleracaoIni.Visible = true;

                    /*
                    txtConsumoFin.Text = consumo.ToString();
                    txtPesoFin.Text = peso.ToString();
                    txtPotenciaFin.Text = potencia.ToString();
                    txtVelocMaxFin.Text = velocidade.ToString();
                    txtTorqueFin.Text = torque.ToString();
                    txtAceleFin.Text = aceleracao.ToString();
                    */





                    rtValor.Text = preco.ToString();
                }
            }
            else
            {
                MessageBox.Show("digite a quantidade.");
            }
            
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
            
            limparCampos();
            

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            
            limparCampos();

            NotaFiscal n = new NotaFiscal();
            n.ShowDialog(this);

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            
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
            {
                txtCliente.Items.Add(c.Cpf);
                
            }
                
                

        }
        public void fillCarro()
        {
            List<Carro> carros;
            CarroDAO cDAO = new CarroDAO();
            txtCarro.Items.Clear();
            carros = cDAO.Listar(txtCliente.Text);
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
       
        
        public void limparCampos()
        {
            
            txtCarro.Text = "";
            txtCliente.Text = "";
            txtFunc.Text = "";
        }
        int r=0;
        private void btExecutar_Click(object sender, EventArgs e)
        {
            if (txtCarro.Text != "")
            {


                if (MessageBox.Show("Executar o Serviço? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ServicoDAO servicoDAO = new ServicoDAO();
                    Servico servico = getDTOServ();
                    servicoDAO.Salvar(servico);

                    StageDAO stageDAO = new StageDAO();
                    Stage stage = getDTO();
                    stageDAO.Salvar(stage);

                    for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                    {
                        ServPecaDAO servPecaDAO = new ServPecaDAO();
                        ServPeca servPeca = getDTOPecaServ();
                        servPecaDAO.Salvar(servPeca);
                        r++;
                    }

                    CarroDAO car = new CarroDAO();
                    Carro c = getDTOCar();
                    car.AtualizaSpecs(c);


                    NotaFiscal n = new NotaFiscal();
                    ServicoDAO s = new ServicoDAO();
                    n.mostra(s.BuscaCodigo().ToString());
                    n.ShowDialog(this);

                    //para chamar o splash
                    Thread t = new Thread((new ThreadStart(Loading)));
                    ////inicializar a thread
                    t.Start();
                    Thread.Sleep(1200);
                    t.Abort();


                    MessageBox.Show("Serviço encaminhado com sucesso!");

                    
                }

                else
                {
                    MessageBox.Show("Serviço cancelado");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos para iniciar o serviço");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o Serviço? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
        }
        private Carro getDTOCar()
        {
            Carro c = new Carro();
            c.Peso = int.Parse(txtPesoFin.Text);
            c.Potencia = int.Parse(txtPotenciaFin.Text);
            c.VelocidadeMax = int.Parse(txtVelocMaxFin.Text);
            c.Torque = int.Parse(txtTorqueFin.Text);
            c.Aceleracao = int.Parse(txtAceleFin.Text);
            c.Consumo = int.Parse(txtConsumoFin.Text);
            c.RotacaoMax = int.Parse(txtRotaMaxFin.Text);
            return c;
        }
        private Servico getDTOServ()
        {
            Servico s = new Servico();
            s.CpfCliente1 = txtCliente.Text;
            s.CpfFuncionario1 = txtFunc.Text;
            s.ValorTotal = preco;
            s.PlacaCarro1 = txtCarro.Text;
            return s;
        }

        private ServPeca getDTOPecaServ()
        {
            ServicoDAO s = new ServicoDAO();
            ServPeca sv = new ServPeca();
            sv.CodPeca1 = int.Parse(dgvCarrinho.Rows[r].Cells[0].Value.ToString());
            sv.CodServ1 = s.BuscaCodigo();
            sv.Quantidade = int.Parse(dgvCarrinho.Rows[r].Cells[5].Value.ToString());
            return sv;
        }
        private Stage getDTO()
        {
            ServicoDAO s = new ServicoDAO();
            Stage stage = new Stage();
            stage.CodServ1 = s.BuscaCodigo();
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
            Carrinho(true);
            FillPecas();
            
        }

        private void btnRemoverPeca_Click(object sender, EventArgs e)
        {
            Carrinho(false);
        }

        

        private void dgvPecasServ_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Carrinho(true);
        }

        private void txtFiltrarPeca_TextChanged(object sender, EventArgs e)
        {
            PecasDAO pecasDAO = new PecasDAO();
            List<Pecas> pecas;
            pecas = pecasDAO.Listar(txtFiltrarPeca.Text);
            dgvPecasServ.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvPecasServ.Rows.Add(p.Codigo, p.Compatibilidade, p.Tipo, p.Fabricante, p.Preco, p.Descricao, p.AddTorque, p.AddPotencia, p.AddPeso);

            }
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

            if ((txtConsumoIni.Text != "" && consumo < 41))

                try
                {
                    consumo = int.Parse(txtConsumoIni.Text);
                    pbConsumoIni.Value = consumo;
                }
                catch
                {
                    MessageBox.Show("O consumo deve ser até 40 km/L");
                    txtConsumoIni.Text = "";
                    consumo = 1;
                    pbConsumoIni.Value = consumo;
                }
            if ((txtConsumoFin.Text != "" && consumo < 41))

                try
                {
                    consumo = int.Parse(txtConsumoFin.Text);
                    pbConsumoFin.Value = consumo;
                }
                catch
                {
                    MessageBox.Show("O consumo deve ser até 40 km/L");
                    txtConsumoFin.Text = "";
                    consumo = 1;
                    pbConsumoFin.Value = consumo;
                }

            
            if (txtPesoIni.Text != "" && peso < 2801)

                try
                {
                    peso = int.Parse(txtPesoIni.Text);
                    pbPesoIni.Value = peso;
                }
                catch
                {
                    MessageBox.Show("O peso deve ser até 2800 kg");
                    txtPesoIni.Text = "";
                    peso = 1;
                    pbPesoIni.Value = peso;
                }

            if (txtPesoFin.Text != "" && peso < 2801)

                try
                {
                    peso = int.Parse(txtPesoFin.Text);
                    pbPesoFin.Value = peso;
                }
                catch
                {
                    MessageBox.Show("O peso deve ser até 2800 kg");
                    txtPesoFin.Text = "";
                    peso = 1;
                    pbPesoFin.Value = peso;
                }


            if (txtAceleIni.Text != "" && aceleracao < 31)

                try
                {
                    aceleracao = int.Parse(txtAceleIni.Text);
                    pbAceleracaoIni.Value = aceleracao;
                }
                catch
                {
                    MessageBox.Show("A aceleração deve ser entre 1 e 30 seg");
                    txtAceleIni.Text = "";
                    aceleracao = 1;
                    pbAceleracaoIni.Value = aceleracao;
                }
            if (txtAceleFin.Text != "" && aceleracao < 31)

                try
                {
                    aceleracao = int.Parse(txtAceleFin.Text);
                    pbAceleracaoFin.Value = aceleracao;
                }
                catch
                {
                    MessageBox.Show("A aceleração deve ser entre 1 e 30 seg");
                    txtAceleFin.Text = "";
                    aceleracao = 1;
                    pbAceleracaoFin.Value = aceleracao;
                }


            if (txtVeloMaxIni.Text != "" && velocidade < 401)

                try
                {
                    velocidade = int.Parse(txtVeloMaxIni.Text);
                    pbVelocidadeMaxIni.Value = velocidade;
                }
                catch
                {
                    MessageBox.Show("A velocidade máxima registrada é 400km/h");
                    txtVeloMaxIni.Text = "";
                    velocidade = 1;
                }
            if (txtVelocMaxFin.Text != "" && velocidade < 401)

                try
                {
                    velocidade = int.Parse(txtVelocMaxFin.Text);
                    pbVelocidadeMaxFin.Value = velocidade;
                }
                catch
                {
                    MessageBox.Show("A velocidade máxima registrada é 400km/h");
                    txtVelocMaxFin.Text = "";
                    velocidade = 1;
                }
            if (txtRotMaxIni.Text != "" && rotacao < 10001)

                try
                {
                    rotacao = int.Parse(txtRotMaxIni.Text);
                    pbRotacaoIni.Value = rotacao;
                }
                catch
                {
                    MessageBox.Show("Rotação max = 10000");
                    txtRotMaxIni.Text = "";
                    rotacao = 1;
                }
            if (txtRotaMaxFin.Text != "" && rotacao < 10001)

                try
                {
                    rotacao = int.Parse(txtRotaMaxFin.Text);
                    pbRotacaoFin.Value = rotacao;
                }
                catch
                {
                    MessageBox.Show("Rotação max = 10000");
                    txtRotaMaxFin.Text = "";
                    rotacao = 1;
                }
            if (txtTorqueIni.Text != "" && torque < 101)

                try
                {
                    torque = int.Parse(txtTorqueIni.Text);
                    pbTorqueIni.Value = torque;
                }
                catch
                {
                    MessageBox.Show("O torque deve ser até 101 kg");
                    txtTorqueIni.Text = "";
                    torque = 1;

                }
            if (txtTorqueFin.Text != "" && torque < 101)

                try
                {
                    torque = int.Parse(txtTorqueFin.Text);
                    pbTorqueFin.Value = torque;
                }
                catch
                {
                    MessageBox.Show("O torque deve ser até 101 kg");
                    txtTorqueFin.Text = "";
                    torque = 1;

                }
            if (txtPotenciaIni.Text != "" && potencia < 1201)

                try
                {
                    potencia = int.Parse(txtPotenciaIni.Text);
                    pbPotenciaIni.Value = potencia;
                }
                catch
                {
                    MessageBox.Show("A potencia maxima registrada é 1200cv");
                    txtPotenciaIni.Text = "";
                    potencia = 1;
                }
            if (txtPotenciaFin.Text != "" && potencia < 1201)

                try
                {
                    potencia = int.Parse(txtPotenciaFin.Text);
                    pbPotenciaFin.Value = potencia;
                }
                catch
                {
                    MessageBox.Show("A potencia maxima registrada é 1200cv");
                    txtPotenciaFin.Text = "";
                    potencia = 1;
                }
            
            lbAceleracao.Text = txtAceleIni.Text;
            lbConsumo.Text = txtConsumoIni.Text;
            lbPeso.Text = txtPesoIni.Text;
            lbPotencia.Text = txtPotenciaIni.Text;
            lbRotacao.Text = txtRotMaxIni.Text;
            lbTorque.Text = txtTorqueIni.Text;
            lbVelocidade.Text = txtVeloMaxIni.Text;

            lbAceleracaoFin.Text = txtAceleFin.Text;
            lbConsumoFin.Text = txtConsumoFin.Text;
            lbPesoFin.Text = txtPesoFin.Text;
            lbPotenciaFin.Text = txtPotenciaFin.Text;
            lbRotacaoFin.Text = txtRotaMaxFin.Text;
            lbTorqueFin.Text = txtTorqueFin.Text;
            lbVelocidadeFin.Text = txtVelocMaxFin.Text;
        }

        private void txtRotMaxIni_TextChanged(object sender, EventArgs e)
        {
            pbFill();
        }

        private void txtRotaMaxFin_TextChanged(object sender, EventArgs e)
        {
            pbFill();
        }

        private void txtCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = clienteDAO.BuscaCPF(txtCliente.Text);
            lbCpfCliente.Text = cliente.Nome;
        }

        private void txtCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroDAO carroDAO = new CarroDAO();
            //Carro carro = carroDAO.
        }

        private void txtFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

