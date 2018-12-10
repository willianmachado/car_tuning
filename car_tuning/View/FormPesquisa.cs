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
            fillStage();
            fillCarro();
            fillServico();

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
        private void fillStage()
        {
            StageDAO stageDAO = new StageDAO();
            List<Stage> stages;
            stages = stageDAO.Carregar();
            dgvStage.Rows.Clear();
            foreach (Stage s in stages)
            {
                dgvStage.Rows.Add(s.CodServ1,
                    s.PesoIni, s.PesoFin,
                    s.AceleracaoIni, s.AceleracaoFin,
                    s.TorqueIni, s.TorqueFin,
                    s.Velocidade_maxIni, s.Velocidade_maxFin,
                    s.PotenciaIni, s.PotenciaFin,
                    s.ConsumoIni, s.ConsumoFin,
                    s.Rotacao_maxIni, s.Rotacao_maxFin);

            }
        }
        private void fillCarro()
        {
            CarroDAO carroDAO = new CarroDAO();
            List<Carro> carros;
            carros = carroDAO.Carregar();
            dgvCarroP.Rows.Clear();
            foreach (Carro c in carros)
                dgvCarroP.Rows.Add(c.Placa, c.Modelo, c.Marca, c.CpfCliente);
        }
        private void fillServico()
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            List<Servico> servicos;
            servicos = servicoDAO.Carregar();
            dgvServP.Rows.Clear();
            foreach (Servico s in servicos)
                dgvServP.Rows.Add(s.Codigo, s.PlacaCarro1, s.CpfCliente1, s.CpfFuncionario1, s.ValorTotal);
            
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





        private void txtBuscaStage_Leave(object sender, EventArgs e)
        {
            if (txtBuscaStage.Text == "")
            {
                txtBuscaStage.Text = "Digite o Codigo do Serviço";
            }
        }

        private void txtBuscaStage_Enter(object sender, EventArgs e)
        {
            if (txtBuscaStage.Text == "Digite o Codigo do Serviço")
            {   
                txtBuscaStage.Text = "";
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
        private void txtPesquisaServ_TextChanged(object sender, EventArgs e)
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            List<Servico> servicos;
            if(txtPesquisaServ.Text != "")
            {
                servicos = servicoDAO.Listar(txtPesquisaServ.Text);
                dgvServP.Rows.Clear();
                foreach (Servico s in servicos)
                    dgvServP.Rows.Add(s.Codigo, s.CpfCliente1, s.PlacaCarro1, s.CpfFuncionario1, s.ValorTotal);
            }
            
        }

        private void txtPesquisaCarro_TextChanged(object sender, EventArgs e)
        {
            CarroDAO carroDAO = new CarroDAO();
            List<Carro> carros;
            carros = carroDAO.Listar(txtPesquisaCarro.Text);
            dgvCarroP.Rows.Clear();
            foreach (Carro c in carros)
                dgvCarroP.Rows.Add(c.Placa,c.Modelo,c.Marca,c.CpfCliente);
        }
        private void txtPesquisaPecas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        private void txtBuscaStage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StageDAO stageDAO = new StageDAO();
                List<Stage> stages;
                stages = stageDAO.BuscaServ(txtBuscaStage.Text);
                dgvStage.Rows.Clear();
                foreach (Stage s in stages)
                {
                    dgvStage.Rows.Add(s.CodServ1,
                        s.PesoIni, s.PesoFin,
                        s.AceleracaoIni, s.AceleracaoFin,
                        s.TorqueIni, s.TorqueFin,
                        s.Velocidade_maxIni, s.Velocidade_maxFin,
                        s.PotenciaIni, s.PotenciaFin,
                        s.ConsumoIni, s.ConsumoFin,
                        s.Rotacao_maxIni, s.Rotacao_maxFin);

                }
            }
            catch
            {
                // Prevenindo erro do

            }
                
            

            
            
        }

        

        private void tabCliente_Selecting(object sender, TabControlCancelEventArgs e)
        {
            FillFunc();
            FillPeca();
            fillStage();
            fillCarro();
            fillServico();
        }

        private void dgvCarroP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GraphStage form2 = new GraphStage();
            //form2.carragaG(dgvCarroP.CurrentRow.Cells[0].Value.ToString());
            
            form2.Show(this);
            
        }

        private void dgvStage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GraphStage form2 = new GraphStage();
            form2.carragaG(dgvStage.CurrentRow.Cells[0].Value.ToString());
            form2.Show(this);
        }

        private void dgvServP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GraphStage form2 = new GraphStage();
            form2.carragaG(dgvServP.CurrentRow.Cells[0].Value.ToString());
            form2.Show(this);
        }
    }
}
