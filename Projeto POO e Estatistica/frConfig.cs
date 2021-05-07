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
    public partial class frConfig : Form
    {
        public frConfig()
        {
            InitializeComponent();

            chkLimitador.Checked = Configuracoes.LimitadorDeAposta;
            chkMusica.Checked = Configuracoes.MusicaAtiva;
            trbVolume.Value = Configuracoes.Volume;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Configuracoes.Salvar(chkMusica.Checked, chkLimitador.Checked, trbVolume.Value);
        }
    }
}
