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
    public partial class frMain : Form
    {
        private List<Disco> discosDaMaquina = new List<Disco>();
        private List<Resultado> resultadosPossiveis = new List<Resultado>();

        public frMain()
        {
            InitializeComponent();

            resultadosPossiveis.Add(new Resultado("Laranja", 1));
            resultadosPossiveis.Add(new Resultado("Banana", 3));
            resultadosPossiveis.Add(new Resultado("Maca", 6));

            discosDaMaquina.Add(new Disco(resultadosPossiveis));
            discosDaMaquina.Add(new Disco(resultadosPossiveis));
            discosDaMaquina.Add(new Disco(resultadosPossiveis));
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            txtR1.Text = discosDaMaquina[0].GirarDisco();
            txtR2.Text = discosDaMaquina[0].GirarDisco();
            txtR3.Text = discosDaMaquina[0].GirarDisco();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroLaranja = 0;
            int numeroMaca = 0;
            int numeroBanana = 0;
            int numeroIndigentes = 0;

            for (int i = 0; i < 999999; i++)
            {
                string aux = discosDaMaquina[0].GirarDisco();

                if (aux == "Laranja")
                    numeroLaranja++;
                else if (aux == "Banana")
                    numeroBanana++;
                else if (aux == "Maca")
                    numeroMaca++;
                else
                    numeroIndigentes++;
            }

            MessageBox.Show("Laranja: " + numeroLaranja +
                            "\nMaca: " + numeroMaca +
                            "\nBanana: " + numeroBanana +
                            "\nIndigentes: " + numeroIndigentes);
        }
    }
}
