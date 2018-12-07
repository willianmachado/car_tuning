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
    public partial class GraphStage : Form
    {
        public GraphStage()
        {
            InitializeComponent();
            carragaGraf();
            
        }

        public void carragaGraf()
        {
            
          
                
        }
        public void carragaG(string cod)
        {
            StageDAO stageDAO = new StageDAO();
            List<Stage> stages;
            stages = stageDAO.BuscaServ(cod);
            foreach (Stage s in stages)
            {
                this.chartPotencia.Series["potenciaIni"].Points.AddY(s.PotenciaIni);
                this.chartPotencia.Series["potenciaFin"].Points.AddY(s.PotenciaFin);

                this.chartTorque.Series["TorqueIni"].Points.AddY(s.TorqueIni);
                this.chartTorque.Series["TorqueFin"].Points.AddY(s.TorqueFin);

                this.chartAcele.Series["AceleracaoIni"].Points.AddY(s.AceleracaoIni);
                this.chartAcele.Series["AceleracaoFin"].Points.AddY(s.AceleracaoFin);

                this.chartVeloMax.Series["velocidade_MAX_Ini"].Points.AddY(s.Velocidade_maxIni);
                this.chartVeloMax.Series["velocidade_MAX_Fin"].Points.AddY(s.Velocidade_maxFin);

                this.chartConsumo.Series["ConsumoIni"].Points.AddY(s.ConsumoIni);
                this.chartConsumo.Series["ConsumoFin"].Points.AddY(s.ConsumoFin);

                this.chartPeso.Series["PesoIni"].Points.AddY(s.PesoIni);
                this.chartPeso.Series["PesoFin"].Points.AddY(s.PesoFin);

                this.chartRotacao.Series["RotacaoIni"].Points.AddY(s.Rotacao_maxIni);
                this.chartRotacao.Series["RotacaoFin"].Points.AddY(s.Rotacao_maxFin);

            }


        }
    }
}
