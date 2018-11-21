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

namespace car_tuning
{
    public partial class FormPecas : Form
    {
        PecasDAO p = new PecasDAO();
        public FormPecas()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            PecasDAO pecasDAO = new PecasDAO();
            List<Pecas> pecas;
            pecas = pecasDAO.Carregar();
            dgvPecas.Rows.Clear();
            foreach (Pecas p in pecas)
                dgvPecas.Rows.Add(p.Codigo,p.Descricao,p.Fabricante,p.Tipo,p.Tipo,p.Compatibilidade,p.AddPeso,p.AddPotencia,p.AddTorque);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            ControlaBotoes(false);
            limparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            PecasDAO pecasDAO = new PecasDAO();
            Pecas pecas = GetDTO();

            if (txtCodigo.Text != "")
            {
                pecasDAO.Salvar(pecas);
                Fill();

            }
            else
            {
                MessageBox.Show(this, "Favor preencheros campos ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            limparCampos();

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            btEditar.Enabled = true;
            btSalvar.Enabled = false;
        }

        private Pecas GetDTO()
        {
            Pecas p = new Pecas();
            p.AddPeso = Double.Parse(txtPeso.Text);
            p.AddPotencia = Double.Parse(txtPotencia.Text);
            p.AddTorque = Double.Parse(txtTorque.Text);
            p.Codigo = Int32.Parse(txtCodigo.Text);
            //p.Compatibilidade = txt
            p.Descricao = txtDescri.Text;
            p.Fabricante = txtFabri.Text;
            p.Preco = Double.Parse(txtPreco.Text);
            p.Tipo = txtTipo.Text;
            return p;
        }
        private void SetDTO(Pecas p)
        {
            txtPeso.Text = p.AddPeso.ToString() ;
            txtPotencia.Text = p.AddPotencia.ToString();
            txtTorque.Text = p.AddTorque.ToString();
            txtCodigo.Text = p.Codigo.ToString();
            //p.Compatibilidade = txt
            txtDescri.Text = p.Descricao;
            txtFabri.Text = p.Fabricante;
            txtPreco.Text = p.Preco.ToString();
            txtTipo.Text = p.Tipo;
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
            txtCodigo.Text = "";
            txtModelo.Text = "";
            txtDescri.Text = "";
            txtFabri.Text = "";

        }

        
    }
}
