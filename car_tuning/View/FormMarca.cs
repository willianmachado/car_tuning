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
            Fill();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Fill()
        {
            List<Marca> marcas;
            MarcaDAO marca = new MarcaDAO();
            dgvMarca.Rows.Clear();

            marcas = marca.Carregar();

            foreach (Marca m in marcas)
            {
                dgvMarca.Rows.Add(m.Codigo, m.Nome);
            }


        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeMarca.Text != "" )
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
            else
            {
                MessageBox.Show("Insira o nome da marca");
            }
            
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            MarcaDAO marcaDAO = new MarcaDAO();
            string index = (dgvMarca.CurrentRow.Cells[0].Value.ToString());

            getDTO();
            marcaDAO.Deletar(index);

            Fill();
            MessageBox.Show("Marca excluida");
        }

        private Marca getDTO()
        {
            Marca marca = new Marca();
            marca.Nome = txtNomeMarca.Text.Trim();
            return marca;
        }

        
    }
}
