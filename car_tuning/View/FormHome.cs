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
        FormCarro FormCa = new FormCarro();
        FormRelatorio formR = new FormRelatorio();
        FormFuncionario formFunc = new FormFuncionario();

        private void tsCliente_Click(object sender, EventArgs e)
        {
            
            formC.MdiParent = this;
            formC.StartPosition = FormStartPosition.Manual;
            formC.Show();

            formFunc.Visible = false;
            formP.Visible = false;
            FormCa.Visible = false;
            formR.Visible = false;
        }

        private void tsPeca_Click(object sender, EventArgs e)
        {
            
            formP.MdiParent = this;
            formP.StartPosition = FormStartPosition.Manual;
            formP.Show();


            formFunc.Visible = false;
            formC.Visible = false;
            FormCa.Visible = false;
            formR.Visible = false;
        }

        

        private void tsPesquisa_Click(object sender, EventArgs e)
        {

            FormPesquisa formPq = new FormPesquisa();
            formPq.Show();
            
        }

        private void tsServico_Click(object sender, EventArgs e)
        {

            FormServico formS = new FormServico();
            formS.Show();

            
        }

        private void tsRelatorio_Click(object sender, EventArgs e)
        {
            
            formR.MdiParent = this;
            formR.StartPosition = FormStartPosition.Manual;
            formR.Show();

            formFunc.Visible = false;
            formC.Visible = false;
            formP.Visible = false;
            FormCa.Visible = false;
        }

        private void tsCarro_Click(object sender, EventArgs e)
        {
            FormCa.MdiParent = this;
            FormCa.StartPosition = FormStartPosition.Manual;
            FormCa.Show();


            formFunc.Visible = false;
            formC.Visible = false;
            formP.Visible = false;
            formR.Visible = false;
        }

        private void tsfuncionario_Click(object sender, EventArgs e)
        {

            formFunc.MdiParent = this;
            formFunc.StartPosition = FormStartPosition.Manual;
            formFunc.Show();

            FormCa.Visible = false;
            formC.Visible = false;
            formP.Visible = false;
            formR.Visible = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
