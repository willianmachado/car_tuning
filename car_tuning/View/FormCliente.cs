using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_tuning
{
    public partial class FormCliente : Form
    {

        ClienteDAO c = new ClienteDAO();

        public FormCliente()
        {
            

            InitializeComponent();
            ControlaBotoes(true);
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtAno.Enabled = false;
            
            dgvCliente.DataSource = c.Carregar();
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


        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            lbAno.Text = txtAno.Text;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            lbMarca.Text = txtMarca.Text;
        }

        private void txtModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txtMarca.Text == "")
            {
                MessageBox.Show("Selecione a Marca do carro");
                lbModelo.Text = txtModelo.Text;
            }

            else
            {

                lbMarca.Visible = true;
                lbModelo.Text = txtModelo.Text;
                lbModelo.Visible = true;
                imgCarro.Visible = true;
                lbAno.Visible = true;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = getDTO();
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtCpf.Text != "" && txtEmail.Text!="")
            {

                clienteDAO.Salvar(cliente);
                dgvCliente.DataSource = c.Carregar();


                try
                {
                    MessageBox.Show("Cadastrado com Sucesso!");
                    ControlaBotoes(true);
                    limparCampos();
                }

                catch (Exception)
                {
                    MessageBox.Show("CPF Já cadastrado! ");
                }
            }

            else
            {
                MessageBox.Show(this, "Favor preencher: CPF/EMAIL ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (txtCpf.Text != "")

                if (MessageBox.Show(" Deseja excluir o cadastro selecionado? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                ClienteDAO clienteDAO = new ClienteDAO();
                string index = (dgvCliente.CurrentRow.Cells[0].Value.ToString());


                Cliente cliente = getDTO();
                clienteDAO.Deletar(index);

                dgvCliente.DataSource = c.Carregar();
                MessageBox.Show("Cadastro excluido");
                limparCampos();
            }
            else
                {

                    MessageBox.Show(this, "Selecione um cadastro para excluir", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void dgvCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtCpf.Text = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefone.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvCliente.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        //CONTROLES
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

                this.txtNome.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtTelefone.Enabled = false;
                this.txtAno.Enabled = false;
                this.txtMarca.Enabled = false;
                this.txtModelo.Enabled = false;

            }
            else
            {
                this.btNovo.Enabled = false;
                this.btNovo.ForeColor = Color.Gray;
                this.btExcluir.Enabled = false;
                this.btExcluir.ForeColor = Color.Gray;
                this.btEditar.Enabled = false;
                this.btEditar.ForeColor = Color.Gray;
                this.txtCpf.Enabled = true;
                this.btSalvar.Enabled = true;
                this.btSalvar.ForeColor = Color.White;
                this.btLimpar.Enabled = true;
                this.btLimpar.ForeColor = Color.White;
                this.btPesquisar.Enabled = false;
                this.btPesquisar.ForeColor = Color.Gray;

                this.txtNome.Enabled = true;
                this.txtEmail.Enabled = true;
                this.txtTelefone.Enabled = true;
                this.txtAno.Enabled = true;
                this.txtMarca.Enabled = true;
                this.txtModelo.Enabled = true;
            }
        }

        public void limparCampos()
        {
            //Limpar os campos já preenchidos

            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtAno.Text = "";
            txtModelo.Text = " ";
            txtPlaca.Text = "";
            txtMarca.Text = " ";
            
        }

        //Obter dados da Classe/Visao
        private Cliente getDTO()
        {
            Cliente cliente = new Cliente();

            cliente.Cpf = txtCpf.Text.Trim();
            cliente.Nome = txtNome.Text.Trim();
            cliente.Telefone = txtTelefone.Text.Trim();
            cliente.Email = txtEmail.Text.Trim();

            return cliente;
        }

        private Cliente setDTO()
        {
            Cliente c = new Cliente();

            txtCpf.Text = c.Cpf;
            txtNome.Text = c.Nome;
            txtTelefone.Text = c.Telefone;
            txtEmail.Text = c.Email;
            
            return c;
        }

        
    }
}
