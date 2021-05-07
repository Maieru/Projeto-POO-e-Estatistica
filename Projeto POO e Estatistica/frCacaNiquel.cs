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
    public partial class frCacaNiquel : Form
    {
        private List<Disco> discosDaMaquina = new List<Disco>();
        private List<Resultado> resultadosPossiveis = new List<Resultado>();

        public frCacaNiquel()
        {
            InitializeComponent();

            resultadosPossiveis.Add(new Resultado("Laranja", 1, 5));
            resultadosPossiveis.Add(new Resultado("Banana", 3, 3));
            resultadosPossiveis.Add(new Resultado("Maca", 6, 1));

            discosDaMaquina.Add(new Disco(resultadosPossiveis));
            discosDaMaquina.Add(new Disco(resultadosPossiveis));
            discosDaMaquina.Add(new Disco(resultadosPossiveis));
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(lblNumeroDeGiros.Text); i++)
            {
                string resultado1 = discosDaMaquina[0].GirarDisco();
                string resultado2 = discosDaMaquina[1].GirarDisco();
                string resultado3 = discosDaMaquina[2].GirarDisco();

                Jogador.ModificaDinheiro(-1);

                if (resultado1 == resultado2 && resultado2 == resultado3)
                {
                    foreach (Resultado possivelResultado in resultadosPossiveis)
                    {
                        if (resultado1 == possivelResultado.Nome)
                            Jogador.ModificaDinheiro(possivelResultado.Recompensa);
                    }
                }
            }
        }
        private void btnAumentarNumeroDeGiros_Click(object sender, EventArgs e)
        {
            if (lblNumeroDeGiros.Text == "10000")
            {
                MessageBox.Show("Numero máximo de giros permitidos é dez mil !",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblNumeroDeGiros.Text = (Convert.ToDouble(lblNumeroDeGiros.Text) * 10).ToString();
        }
        private void btnDiminuirNumeroDeGiros_Click(object sender, EventArgs e)
        {
            if (lblNumeroDeGiros.Text == "1")
            {
                MessageBox.Show("Numero mínimo de giros permitidos é um !",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblNumeroDeGiros.Text = (Convert.ToDouble(lblNumeroDeGiros.Text) / 10).ToString();
        }
    }
}
