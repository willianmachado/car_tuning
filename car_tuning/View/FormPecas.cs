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

namespace car_tuning
{
    public partial class FormPecas : Form
    {
        PecasDAO p = new PecasDAO();
        public FormPecas()
        {
            InitializeComponent();
            Fill();
            FillMarca();
            ControlaBotoes(true);
        }
        private void Fill()
        {
            
            List<Pecas> pecas;
            pecas = p.Carregar();
            dgvPecas.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvPecas.Rows.Add(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque);
            }
        }
        private void FillMarca()
        {
            List<Marca> marcas;
            MarcaDAO marca = new MarcaDAO();
            txtMarca.Items.Clear();

            marcas = marca.Carregar();

            foreach (Marca m in marcas)
            {
                txtMarca.Items.Add(m.Nome);
            }
                

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
            Fill();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
                Pecas pecas = GetDTO();

            if (txtTipo.Text != "")
            {
                if (btSalvar.Text == "Salvar")
                {
                    p.Salvar(pecas);
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                else
                {
                    Pecas peca = GetDTOcod();
                    p.Atualizar(peca);
                    MessageBox.Show("Atualizado com Sucesso!");
                    btSalvar.Text = "Salvar";
                }
                Fill();
                ControlaBotoes(true);
                limparCampos();
            }           

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            limparCampos();
            btSalvar.Text = "Salvar";

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show(this, "Clique duplo para excluir", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

           if (MessageBox.Show(" Deseja excluir a peça selecionada? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                string index = (dgvPecas.CurrentRow.Cells[0].Value.ToString());
                Pecas peca = GetDTO();
                p.Deletar(index);

                Fill();
                MessageBox.Show("Peça excluida");
                limparCampos();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                ControlaBotoes(false);

                btEditar.Enabled = false;
                btSalvar.Text = "Atualizar";
            }
            else
            {
                MessageBox.Show("Clique duplo para editar");

            }

        }
        private Pecas GetDTOcod()
        {
            Pecas p = new Pecas();
            p.Codigo = int.Parse(txtCodigo.Text);
           
            p.AddPeso = Double.Parse(txtPeso.Text);
            p.AddPotencia = Double.Parse(txtPotencia.Text);
            p.AddTorque = Double.Parse(txtTorque.Text);
            p.Compatibilidade = txtMarca.Text;
            p.Descricao = txtDescri.Text;
            p.Fabricante = txtFabri.Text;
            p.Preco = Double.Parse(txtPreco.Text);
            p.Tipo = txtTipo.Text;
            return p;
        }
        private Pecas GetDTO()
        {
            Pecas p = new Pecas();
            
            p.AddPeso = Double.Parse(txtPeso.Text);
            p.AddPotencia = Double.Parse(txtPotencia.Text);
            p.AddTorque = Double.Parse(txtTorque.Text);
            p.Compatibilidade = txtMarca.Text;
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
            p.Compatibilidade = txtMarca.Text;
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
                txtMarca.Enabled = false;
                txtDescri.Enabled = false;
                txtFabri.Enabled = false;
                txtPeso.Enabled = false;
                txtPotencia.Enabled = false;
                txtPreco.Enabled = false;
                txtTipo.Enabled = false;
                txtTorque.Enabled = false;

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
                txtMarca.Enabled = true;
                txtDescri.Enabled = true;
                txtFabri.Enabled = true;
                txtPeso.Enabled = true;
                txtPotencia.Enabled = true;
                txtPreco.Enabled = true;
                txtTipo.Enabled = true;
                txtTorque.Enabled = true;
            }
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtDescri.Text = "";
            txtFabri.Text = "";
            txtPeso.Text = "";
            txtPotencia.Text = "";
            txtPreco.Text = "";
            txtTipo.Text = "";
            txtTorque.Text = "";

        }
        
          private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgvPecas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvPecas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescri.Text = dgvPecas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPreco.Text = dgvPecas.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtFabri.Text = dgvPecas.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTipo.Text = dgvPecas.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMarca.Text = dgvPecas.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPeso.Text = dgvPecas.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPotencia.Text = dgvPecas.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtTorque.Text = dgvPecas.Rows[e.RowIndex].Cells[8].Value.ToString();
               
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            List<Pecas> pecas;
            pecas = p.Listar(txtBusca.Text);
            dgvPecas.Rows.Clear();

            foreach (Pecas p in pecas)
                dgvPecas.Rows.Add(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque);
            
        }
    }
}
