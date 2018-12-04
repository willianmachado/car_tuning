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
            CrystalReport1 relatorio = new CrystalReport1();
            relatorio.SetDataSource(listaCarro);
            crvTeste.ReportSource = relatorio;
        }
    }
}
