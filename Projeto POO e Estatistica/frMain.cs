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
        private Jogador jogador = new Jogador();

        public frMain()
        {
            InitializeComponent();

            resultadosPossiveis.Add(new Resultado("Laranja", 1, 5));
            resultadosPossiveis.Add(new Resultado("Banana", 3, 3));
            resultadosPossiveis.Add(new Resultado("Maca", 6, 1));

            discosDaMaquina.Add(new Disco(resultadosPossiveis));
            discosDaMaquina.Add(new Disco(resultadosPossiveis));
            discosDaMaquina.Add(new Disco(resultadosPossiveis));

            MostraInformacoesDoJogador();
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(lblNumeroDeGiros.Text); i++)
            {
                string resultado1 = discosDaMaquina[0].GirarDisco();
                string resultado2 = discosDaMaquina[1].GirarDisco();
                string resultado3 = discosDaMaquina[2].GirarDisco();

                

                jogador.ModificaDinheiro(-1);

                
                if (resultado1 == resultado2 && resultado2 == resultado3)
                {
                    foreach (Resultado possivelResultado in resultadosPossiveis)
                    {
                        if (resultado1 == possivelResultado.Nome)
                            jogador.ModificaDinheiro(possivelResultado.Recompensa);
                    }
                }
            }
            
            MostraInformacoesDoJogador();
        }
        private void MostraInformacoesDoJogador()
        {
            lblInformacoes.Text = "Olá, " +jogador.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroRepetidos = 0;
            int numeroNaoRepetidos = 0;
            int numeroDeLaranjas = 0;
            int numeroDeBananas = 0;
            int numeroDeMacas = 0;

            for (int i = 0; i <= 9999999; i++)
            {
                string aux1 = discosDaMaquina[0].GirarDisco();
                string aux2 = discosDaMaquina[0].GirarDisco();
                string aux3 = discosDaMaquina[0].GirarDisco();

                if (aux1 == aux2 && aux2 == aux3)
                    numeroRepetidos++;
                else
                    numeroNaoRepetidos++;

                if (aux1 == "Laranja")
                    numeroDeLaranjas++;
                else if (aux1 == "Banana")
                    numeroDeBananas++;
                else
                    numeroDeMacas++;
            }

            MessageBox.Show("Repetidos: " + numeroRepetidos +
                            "\nNão repetidos: " + numeroNaoRepetidos+
                            "\nLaranja: " + numeroDeLaranjas +
                            "\nBanana: " + numeroDeBananas + 
                            "\nMaca: " + numeroDeMacas);
        }

        private void btnAumentarNumeroDeGiros_Click(object sender, EventArgs e)
        {
            if (lblNumeroDeGiros.Text == "1000000")
            {
                MessageBox.Show("Numero máximo de giros permitidos é um milhão !",
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
