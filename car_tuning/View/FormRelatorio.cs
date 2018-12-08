using car_tuning.Modelo;
using car_tuning.View;
using car_tuning.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using car_tuning.DAO;
using car_tuning.Controle;

namespace car_tuning
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            List<NotaF> notaFiscals = new RelatorioDAO().ListaEvolucao(txtPlacaEvolu.Text);
            CrEvolucao crEvolucao = new CrEvolucao();
            crEvolucao.SetDataSource(notaFiscals);
            crvEvolucao.ReportSource = crEvolucao;
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            List<Carro> listaCarro = new CarroDAO().Carregar();
            CrCarro relatorio = new CrCarro();
            relatorio.SetDataSource(listaCarro);
            crvCarro.ReportSource = relatorio;


            List<Cliente> listaClientes = new ClienteDAO().Carregar();
            crCliente crCliente = new crCliente();
            crCliente.SetDataSource(listaClientes);
            crvCliente.ReportSource = crCliente;



            List<Pecas> listaPecas = new PecasDAO().Carregar();
            CrPeca crPecas = new CrPeca();

            crPecas.SetDataSource(listaPecas);
            crvPeca.ReportSource = crPecas;


            List<Funcionario> f = new FuncionarioDAO().Carregar();
            crFuncionario crFuncionario = new crFuncionario();
            crFuncionario.SetDataSource(f);   
            crvFuncionario.ReportSource = crFuncionario;

            
            List<NotaF> pecaRel = new RelatorioDAO().ListaPecaVenda();
            CrVendaPeca crVendaPeca = new CrVendaPeca();
            crVendaPeca.SetDataSource(pecaRel);
            crvVendapeca.ReportSource = crVendaPeca;
        }


        public void test()
        {
            

            
        }

        
    }
}
