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
            crvPecas.ReportSource = crPecas;


            List<Funcionario> f = new FuncionarioDAO().Carregar();
            crFuncionario crFuncionario = new crFuncionario();
            crFuncionario.SetDataSource(f);   
            crvFuncionario.ReportSource = crFuncionario;

            test();
        }


        public void test()
        {
                
        }

        
    }
}
