using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_tuning.View
{
    public partial class FormCarro : Form
    {
        public FormCarro()
        {
            InitializeComponent();
        }


        private void txtAno_TextChanged_1(object sender, EventArgs e)
        {
            lbAno.Text = txtAno.Text;
        }
        
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

            lbMarca.Text = txtMarca.Text;
        }    


        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

            lbModelo.Text = txtModelo.Text;
            lbMarca.Visible = true;
            lbModelo.Visible = true;
            imgCarro.Visible = true;
            lbAno.Visible = true;
        }

        
    }
}
