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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            carragaGraf();
            
        }

        public void carragaGraf()
        {
            CarroDAO carroDAO = new CarroDAO();
            List<Carro> carros;
            carros = carroDAO.Carregar();
            foreach (Carro c in carros)
            {
                this.chart2.Series["potencia"].Points.AddXY(c.Placa, c.Potencia);
                this.chart2.Series["torque"].Points.AddXY(c.Placa, c.Torque);
            }
                
        }
        public void carragaG(string cod)
        {
            StageDAO stageDAO = new StageDAO();
            List<Stage> stages;
            stages = stageDAO.BuscaServ(cod);
            foreach (Stage s in stages)
            {
                this.chart1.Series["potenciaIni"].Points.AddY(s.PotenciaIni);
                this.chart1.Series["potenciaFin"].Points.AddY(s.PotenciaFin);
                //this.chart1.
                //this.chart2.Series[]
            }

        }
    }
}
