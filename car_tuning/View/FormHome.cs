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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }
        
        

        private void tsCliente_Click(object sender, EventArgs e)
        {
            FormCliente formC = new FormCliente();
            //formC.MdiParent = this;
            formC.StartPosition = FormStartPosition.CenterScreen;
            formC.Show();
            
        }

        private void tsPeca_Click(object sender, EventArgs e)
        {
            FormPecas formP = new FormPecas();
            formP.MdiParent = this;
            formP.StartPosition = FormStartPosition.Manual;
            formP.Show();
            
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsPesquisa_Click(object sender, EventArgs e)
        {
            FormPesquisa formPq = new FormPesquisa();
            formPq.MdiParent = this;
            formPq.StartPosition = FormStartPosition.Manual;
            formPq.Show();
        }

        private void tsServico_Click(object sender, EventArgs e)
        {
            FormServico formS = new FormServico();
            formS.MdiParent = this;
            formS.StartPosition = FormStartPosition.Manual;
            formS.Show();
        }

        private void tsRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio formR = new FormRelatorio();
            formR.MdiParent = this;
            formR.StartPosition = FormStartPosition.Manual;
            formR.Show();
        }
    }
}
