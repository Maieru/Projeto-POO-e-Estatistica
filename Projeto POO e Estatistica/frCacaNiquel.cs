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
        private int[] contadorDeGiro = new int[3];
        private int[] momentoDeParada = new int[3];

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
            string[] resultados = new string[3];
            double auxDeDinheiro = 0;

            #region Parte Lógica e de Processamento
            for (int i = 0; i < Convert.ToInt32(lblNumeroDeGiros.Text); i++)
            {
                resultados[0] = discosDaMaquina[0].GirarDisco();
                resultados[1] = discosDaMaquina[1].GirarDisco();
                resultados[2] = discosDaMaquina[2].GirarDisco();

                auxDeDinheiro--;

                if (resultados[0] == resultados[1] && resultados[1] == resultados[2])
                {
                    foreach (Resultado possivelResultado in resultadosPossiveis)
                    {
                        if (resultados[1] == possivelResultado.Nome)
                            auxDeDinheiro += possivelResultado.Recompensa;
                    }
                }
            }
            #endregion

            Jogador.ModificaDinheiro(auxDeDinheiro);

            // A animação de giro só acontece quando se roda apenas uma vez
            if (lblNumeroDeGiros.Text == "1")
            {
                DefineMomentoDeParada(resultados);
                AtivaTimerMaestro();
            }
        }
        private void DefineMomentoDeParada(string[] resultados)
        {
            int tempoMinimo = 96; // IMPORTANTE: É necessário que seja multiplo de 12
            for(int i = 0; i < momentoDeParada.Length; i++)
            {
                if (resultados[i] == "Laranja")
                    momentoDeParada[i] = tempoMinimo;
                if (resultados[i] == "Banana")
                    momentoDeParada[i] = tempoMinimo + 4;
                if (resultados[i] == "Maca")
                    momentoDeParada[i] = tempoMinimo + 8;
            }
        }
        private void AtivaTimerMaestro()
        {
            for (int i = 0; i < contadorDeGiro.Length; i++)
                contadorDeGiro[i] = 0;

            tmrMaestro.Enabled = true;
        }
        private void btnAumentarNumeroDeGiros_Click(object sender, EventArgs e)
        {
            if (lblNumeroDeGiros.Text == "10000" && Configuracoes.LimitadorDeAposta)
            {
                MessageBox.Show("Numero máximo de giros permitidos é dez mil !",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lblNumeroDeGiros.Text == "1000000")
            {
                MessageBox.Show("O número máximo de giros suportado pelo sistema é de um milhão.",
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
        private void tmrMaestro_Tick(object sender, EventArgs e)
        {
            if (contadorDeGiro[0] == 0)
                tmrSlot1.Enabled = true;
            if (contadorDeGiro[1] == 0 && contadorDeGiro[0] == 12)
                tmrSlot2.Enabled = true;
            if (contadorDeGiro[2] == 0 && contadorDeGiro[1] == 12)
                tmrSlot3.Enabled = true;

            for (int i = 0; i < contadorDeGiro.Length; i++)
            {
                if (contadorDeGiro[i] >= momentoDeParada[i])
                {
                    if (i == 0)
                        tmrSlot1.Enabled = false;
                    else if (i == 1)
                        tmrSlot2.Enabled = false;
                    else
                        tmrSlot3.Enabled = false;

                    contadorDeGiro[i] = -1;
                }
            }
        }
        private Bitmap PegaImagemCorreta(int numero)
        {
            List<Bitmap> imagens = new List<Bitmap>();
            imagens.Add(Properties.Resources.Rodando1);
            imagens.Add(Properties.Resources.Rodando2);
            imagens.Add(Properties.Resources.Rodando3);
            imagens.Add(Properties.Resources.Rodando4);
            imagens.Add(Properties.Resources.Rodando5);
            imagens.Add(Properties.Resources.Rodando6);
            imagens.Add(Properties.Resources.Rodando7);
            imagens.Add(Properties.Resources.Rodando8);
            imagens.Add(Properties.Resources.Rodando9);
            imagens.Add(Properties.Resources.Rodando10);
            imagens.Add(Properties.Resources.Rodando11);
            imagens.Add(Properties.Resources.Rodando12);

            return imagens[numero];
        }
        private void tmrSlot1_Tick(object sender, EventArgs e)
        {
            picSlot1.Image = PegaImagemCorreta(contadorDeGiro[0]%12);
            contadorDeGiro[0]++;
        }
        private void tmrSlot2_Tick(object sender, EventArgs e)
        {
            picSlot2.Image = PegaImagemCorreta(contadorDeGiro[1]%12);
            contadorDeGiro[1]++;
        }
        private void tmrSlot3_Tick(object sender, EventArgs e)
        {
            picSlot3.Image = PegaImagemCorreta(contadorDeGiro[2]%12);
            contadorDeGiro[2]++;
        }
    }
}
