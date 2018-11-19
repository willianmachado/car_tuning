using car_tuning.Modelo;
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
            
            
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            
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
            txtCodFuncionario.Text = "";
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


        private Servico getDTO()
        {
            Servico servico = new Servico();
            servico.CodCarro1 = Int32.Parse(txtCarro.Text);

            return servico;
        }

        private void setDTO(Servico s)
        {

        }

        

    }

    
}

