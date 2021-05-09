using Projeto_POO_e_Estatistica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_POO_e_Estatistica
{
    public partial class frEstatistica : Form
    {
        public frEstatistica()
        {
            InitializeComponent();
            lblNumeroDeGiros.Text += " " + Estatistica.NumeroDeGiros;

            if (Estatistica.NumeroDeGiros > 0)
                lblGanhoMedio.Text += " " + ((Jogador.Dinheiro - 10) / Estatistica.NumeroDeGiros).ToString("0.0000");
            else
                lblGanhoMedio.Text += " 0";

            if (Estatistica.ResultadosEspecificos.Count > 0)
            {
                lblLaranja.Text += Estatistica.ResultadosEspecificos[0];
                lblBanana.Text += Estatistica.ResultadosEspecificos[1];
                lblMaca.Text += Estatistica.ResultadosEspecificos[2];

                lblChanceLaranja.Text += (Estatistica.ResultadosEspecificos[0]
                                         / Convert.ToDouble(Estatistica.NumeroDeGiros)).ToString("0.00000");
                lblChanceBanana.Text += (Estatistica.ResultadosEspecificos[1]
                                        / Convert.ToDouble(Estatistica.NumeroDeGiros)).ToString("0.00000");
                lblChanceMaca.Text += (Estatistica.ResultadosEspecificos[2]
                                      / Convert.ToDouble(Estatistica.NumeroDeGiros)).ToString("0.00000");
            }
            else
            {
                lblLaranja.Text += 0;
                lblBanana.Text += 0;
                lblMaca.Text += 0;

                lblChanceBanana.Text += 0;
                lblChanceLaranja.Text += 0;
                lblChanceMaca.Text += 0;
            }
        }
    }
}
