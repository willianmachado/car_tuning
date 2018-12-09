using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using car_tuning.View;
using car_tuning.Modelo;
using car_tuning.Controle;
using car_tuning.DAO;
using car_tuning.Relatorio;
namespace car_tuning
{
    public partial class NotaFiscal : Form
    {
        public NotaFiscal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        public void mostra(string cod)
        {
            List<NotaF> notas = new RelatorioDAO().ListaCodigo(cod);
            CrNotaFiscal crNota = new CrNotaFiscal();
            crNota.SetDataSource(notas);
            crvNotaF.ReportSource = crNota;
        }

        private void btnBuscaNota_Click(object sender, EventArgs e)
        {
            List<NotaF> notas = new RelatorioDAO().ListaCodigo(txtBusca.Text);
            CrNotaFiscal crNota = new CrNotaFiscal();
            crNota.SetDataSource(notas);
            crvNotaF.ReportSource = crNota;
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
