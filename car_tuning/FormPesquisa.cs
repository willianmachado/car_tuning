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
        public FormPesquisa()
        {
            InitializeComponent();
            

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
