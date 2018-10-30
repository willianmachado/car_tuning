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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        FormCliente formC = new FormCliente();
        FormPecas formP = new FormPecas();
        FormServico formS = new FormServico();
        FormCarro FormCa = new FormCarro();
        FormRelatorio formR = new FormRelatorio();


        private void tsCliente_Click(object sender, EventArgs e)
        {
            
            formC.MdiParent = this;
            formC.StartPosition = FormStartPosition.CenterScreen;
            formC.Show();


            formP.Visible = false;
            formS.Visible = false;
            FormCa.Visible = false;
            formR.Visible = false;
        }

        private void tsPeca_Click(object sender, EventArgs e)
        {
            
            formP.MdiParent = this;
            formP.StartPosition = FormStartPosition.Manual;
            formP.Show();

            

            formC.Visible = false;
            formS.Visible = false;
            FormCa.Visible = false;
            formR.Visible = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void tsPesquisa_Click(object sender, EventArgs e)
        {

            FormPesquisa formPq = new FormPesquisa();
            formPq.Show();
            
        }

        private void tsServico_Click(object sender, EventArgs e)
        {
            
            formS.MdiParent = this;
            formS.StartPosition = FormStartPosition.Manual;
            formS.Show();


            formC.Visible = false;
            formP.Visible = false;
            FormCa.Visible = false;
            formR.Visible = false;
        }

        private void tsRelatorio_Click(object sender, EventArgs e)
        {
            
            formR.MdiParent = this;
            formR.StartPosition = FormStartPosition.Manual;
            formR.Show();


            formC.Visible = false;
            formP.Visible = false;
            formS.Visible = false;
            FormCa.Visible = false;
        }

        private void tsCarro_Click(object sender, EventArgs e)
        {
            FormCa.MdiParent = this;
            FormCa.StartPosition = FormStartPosition.Manual;
            FormCa.Show();



            formC.Visible = false;
            formP.Visible = false;
            formS.Visible = false;
            formR.Visible = false;
        }
        
    }
}
