using Projeto_POO_e_Estatistica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_POO_e_Estatistica
{
    public partial class frMain : Form, IObservador
    {
        private Form formAberto = null;

        public frMain()
        {
            InitializeComponent();

            Jogador.Acoplar(this);

            MostraInformacoesDoJogador();

            Configuracoes.LerConfiguracoes();
            Configuracoes.Acoplar(this);

            WMPLib.IWMPPlaylist playlist = wmpTocadorPrincipal.playlistCollection.newPlaylist("Musicas");
            WMPLib.IWMPMedia media;

            string arquivo = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Why dont you do right.mp4");
            media = wmpTocadorPrincipal.newMedia(arquivo);
            playlist.appendItem(media);

            wmpTocadorPrincipal.currentPlaylist = playlist;
            ConfigurarPlayer();
        }

        #region Observer 
        public void Atualizar()
        {
            MostraInformacoesDoJogador();
            ConfigurarPlayer();
        }
        #endregion
        private void MostraInformacoesDoJogador()
        {
            lblInformacoes.Text = "Olá, " + Jogador.ToString();
        }
        private void ConfigurarPlayer()
        {
            wmpTocadorPrincipal.settings.volume = Configuracoes.Volume;
            wmpTocadorPrincipal.settings.setMode("loop", true);
            if (Configuracoes.MusicaAtiva)
                wmpTocadorPrincipal.Ctlcontrols.play();
            else
                wmpTocadorPrincipal.Ctlcontrols.stop();
        }

        /*
         * Este método tem como objetivo abrir um form dentro do panel 
         * pnlMainForm. Desta forma, pode-se criar os formulários de forma
         * separada e com o auxilio do visual studio. Uma outra opção seria
         * criar controles via código ( o que é muito mais trabalhoso e lento ).
         */
        private void AbrirForm(Form formASerAberto)
        {
            if (formAberto != null)
                formAberto.Close();
            if (formASerAberto == null)
                return;

            // Configurações do Form 
            formASerAberto.TopLevel = false;
            formASerAberto.FormBorderStyle = FormBorderStyle.None;
            formASerAberto.Dock = DockStyle.Fill;
            pnlMainForm.Controls.Add(formASerAberto);
            formASerAberto.BackColor = pnlMainForm.BackColor;


            formASerAberto.BringToFront();
            formASerAberto.Show();
            formAberto = formASerAberto;
        }

        private void btnAbrirCacaNiquel_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCacaNiquel());
        }
        private void btnTelaDoCassino_Click(object sender, EventArgs e)
        {
            AbrirForm(null);
        }
        private void btnAbrirConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frConfig());
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            AbrirForm(new frSobre());
        }

        private void btnEstatistica_Click(object sender, EventArgs e)
        {
            AbrirForm(new frEstatistica());
        }
    }
}
