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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormPecas form = new FormPecas();
            form.MdiParent = this;
            form.Show();
        }
    }
}
