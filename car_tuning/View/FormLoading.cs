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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try

            {
                pgbProgressao.Value += 5;
            }
            catch (Exception)
            {
                pgbProgressao.Value = 100;
            }

        }
    }
}

