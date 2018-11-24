using car_tuning.Modelo;
using car_tuning.View;
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
    public partial class FormPesquisa : Form
    {
        ClienteDAO cliente = new ClienteDAO();

        public FormPesquisa()
        {
            InitializeComponent();
            FillFunc();
            FillPeca();

        }
        private void FillFunc()
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> funcionarios;
            funcionarios = fDAO.Carregar();
            dgvFuncP.Rows.Clear();
            foreach (Funcionario f in funcionarios)
                dgvFuncP.Rows.Add(f.Cpf, f.Nome, f.Telefone);
        }

        private void FillPeca()
        {
            PecasDAO pecasDAO = new PecasDAO();
            List<Pecas> pecas;
            pecas = pecasDAO.Carregar();
            dgvPecasP.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvPecasP.Rows.Add(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque);

            }

        }

        private void dgCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormCliente form = new FormCliente();

                string cpf = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nome = dgCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                string telefone = dgCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                string email = dgCliente.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void txtPesquisaFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> funcionarios;
            funcionarios = fDAO.Listar(txtPesquisaFunc.Text);
            dgvFuncP.Rows.Clear();
            foreach (Funcionario f in funcionarios)
                dgvFuncP.Rows.Add(f.Cpf, f.Nome, f.Telefone);
        }
        
        
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaCli.Text == "")
            {
                txtPesquisaCli.Text = "Digite o CPF, Nome ou Email";
            }
        }


        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            if(txtPesquisaCli.Text == "Digite o CPF, Nome ou Email")
            {
                txtPesquisaCli.Text = "";
            }
        }

        private void txtPesquisaCarro_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaCarro.Text == "")
            {
                txtPesquisaCarro.Text = "Digite a Placa ou CPF do Cliente";
            }
        }

        private void txtPesquisaCarro_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaCarro.Text == "Digite a Placa ou CPF do Cliente")
            {
                txtPesquisaCarro.Text = "";
            }
        }

        private void txtPesquisaPecas_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaPecas.Text == "")
            {
                txtPesquisaPecas.Text = "Digite o Código, Fabricante ou Tipo";
            }
        }

        private void txtPesquisaPecas_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaPecas.Text == "Digite o Código, Fabricante ou Tipo")
            {
                txtPesquisaPecas.Text = "";
            }
        }

        private void txtPesquisaFunc_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaFunc.Text == "")
            {
                txtPesquisaFunc.Text = "Digite o CPF ou Nome ";
            }
        }

        private void txtPesquisaFunc_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaFunc.Text == "Digite o CPF ou Nome ")
            {
                txtPesquisaFunc.Text = "";
            }
        }

        private void txtPesquisaServ_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaServ.Text == "")
            {
                txtPesquisaServ.Text = "Digite o Codigo do Serviço, Placa do Carro ou CPF do Cliente";
            }
        }

        private void txtPesquisaServ_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaServ.Text == "Digite o Codigo do Serviço, Placa do Carro ou CPF do Cliente")
            {
                txtPesquisaServ.Text = "";
            }
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtPesquisaPecas_TextChanged(object sender, EventArgs e)
        {
            PecasDAO pecasDAO = new PecasDAO();
            List<Pecas> pecas;
            pecas = pecasDAO.Listar(txtPesquisaPecas.Text);
            dgvPecasP.Rows.Clear();
            foreach (Pecas p in pecas)
            {
                dgvPecasP.Rows.Add(p.Codigo, p.Descricao, p.Preco, p.Fabricante, p.Tipo, p.Compatibilidade, p.AddPeso, p.AddPotencia, p.AddTorque);

            }
        }

        private void txtPesquisaFunc_TextChanged(object sender, EventArgs e)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> funcionarios;
            funcionarios = fDAO.Listar(txtPesquisaFunc.Text);
            dgvFuncP.Rows.Clear();
            foreach (Funcionario f in funcionarios)
                dgvFuncP.Rows.Add(f.Cpf, f.Nome, f.Telefone);
        }

        private void txtPesquisaPecas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
