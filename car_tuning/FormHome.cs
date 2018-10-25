﻿using System;
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
            formC = new FormCliente();
            formP = new FormPecas();
        }
        FormCliente formC;
        FormPecas formP;

        private void tsCliente_Click(object sender, EventArgs e)
        {
            
            formC.MdiParent = this;
            formC.Show();
            
        }

        private void tsPeca_Click(object sender, EventArgs e)
        {
            
            formP.MdiParent = this;
            formP.Show();
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
