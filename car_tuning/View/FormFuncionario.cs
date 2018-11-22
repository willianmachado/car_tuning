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
    public partial class FormFuncionario : Form
    {
        FuncionarioDAO f = new FuncionarioDAO();
        public FormFuncionario()
        {
            InitializeComponent();
            ControlaBotoes(true);
            Fill();
        }
        private void Fill()
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> funcionarios;
            funcionarios = fDAO.Carregar();
            dgvFunc.Rows.Clear();
            foreach (Funcionario f in funcionarios)
                dgvFunc.Rows.Add(f.Cpf, f.Nome, f.Telefone);
        }


        private void btPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa form = new FormPesquisa();
            form.ShowDialog();
        }

        private void btLimpar_Click( object sender, EventArgs e)
        {
            btSalvar.Text = "Salvar";
            ControlaBotoes(true);
            limparCampos();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            ControlaBotoes(false);
            limparCampos();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            Funcionario funcionario = getDTO();
            

            if (txtCpf.Text != "" || txtNome.Text != "")
            {
                
                Fill();
                if (btSalvar.Text == "Salvar")
                {
                    funcionarioDAO.Salvar(funcionario);
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                else
                {
                    funcionarioDAO.atualizar(funcionario);
                    MessageBox.Show("Atualizado com Sucesso!");
                    btSalvar.Text = "Salvar";
                }
                try
                {
                    Fill();
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
                MessageBox.Show(this, "Favor preencher: CPF/Nome ", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                btSalvar.Text = "Atualizar";
                ControlaBotoes(false);
                txtCpf.Enabled = false;
                txtNome.Enabled = true;
                txtTelefone.Enabled = true;
                
            }

            else
            {
                MessageBox.Show("Clique duplo para editar");

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            
            if (txtCpf.Text =="")
            {

                MessageBox.Show(this, "Clique duplo para excluir", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String key = dgvFunc.CurrentRow.Cells[0].Value.ToString();
                FuncionarioDAO dao = new FuncionarioDAO();
                Funcionario funcionario = getDTO();
                dao.Deletar(key);
                Fill();
                limparCampos();
            }
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
            txtCpf.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }
        private Funcionario getDTO()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Cpf = txtCpf.Text.Trim();
            funcionario.Nome = txtNome.Text.Trim();
            funcionario.Telefone = txtTelefone.Text.Trim();
            return funcionario;
        }
        private void setDTO(Funcionario f)
        {
            
            txtCpf.Text = f.Cpf;
            txtNome.Text = f.Nome;
            txtTelefone.Text = f.Telefone;
            
        }
        

        private void dgvFunc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCpf.Text = dgvFunc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvFunc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefone.Text = dgvFunc.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }

        private void txtBuscaFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Funcionario> funcionarios;
            funcionarios = f.Listar(txtBuscaFunc.Text);
            dgvFunc.Rows.Clear();

            foreach (Funcionario f in funcionarios)
                dgvFunc.Rows.Add(f.Codigo, f.Cpf, f.Telefone);
        }
    }
}
