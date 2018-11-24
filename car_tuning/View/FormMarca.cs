using car_tuning.DAO;
using car_tuning.Modelo;
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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MarcaDAO marcaDAO = new MarcaDAO();
            Marca marca = getDTO();
            marcaDAO.Salvar(marca);
            MessageBox.Show("Cadastrado com Sucesso!");
            FormCarro formCarro = new FormCarro();
            
            formCarro.Refresh();
            formCarro.Fill();

            this.Close();
        }

        private Marca getDTO()
        {
            Marca marca = new Marca();
            marca.Nome = txtNomeMarca.Text.Trim();
            return marca;
        }
    }
}
