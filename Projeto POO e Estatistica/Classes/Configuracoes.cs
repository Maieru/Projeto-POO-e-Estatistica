using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO_e_Estatistica.Classes
{
    static class Configuracoes
    {
        #region Observer
        private static List<object> observadores = new List<object>();

        public static void Acoplar(IObservador observador) => observadores.Add(observador);
        public static void Desacoplar(IObservador observador) => observadores.Remove(observador);
        private static void Notificar()
        {
            foreach (var observador in observadores)
                (observador as IObservador).Atualizar();
        }
        #endregion

        public static bool MusicaAtiva { get; private set; }
        public static int Volume { get; private set; }
        public static bool LimitadorDeAposta { get;private set; }

        public static void Salvar(bool musicaAtiva, bool limitadorDeAposta, int volume)
        {
            string conteudo = musicaAtiva + "|" + limitadorDeAposta + "|" + volume;
            File.WriteAllText("configuracoes.txt", conteudo);

            MusicaAtiva = musicaAtiva;
            Volume = volume;
            LimitadorDeAposta = limitadorDeAposta;

            Notificar();
        }
        public static void LerConfiguracoes()
        {
            if (File.Exists("configuracoes.txt"))
            {
                string[] configuracoes = File.ReadAllText("configuracoes.txt").Split('|');
                MusicaAtiva = Convert.ToBoolean(configuracoes[0]);
                LimitadorDeAposta = Convert.ToBoolean(configuracoes[1]);
                Volume = Convert.ToInt32(configuracoes[2]);
            }
            else
            {
                Volume = 5;
                MusicaAtiva = true;
                LimitadorDeAposta = true;
            }
        }
    }
}
