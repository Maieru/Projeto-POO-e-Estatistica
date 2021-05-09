using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO_e_Estatistica.Classes
{
    static class Jogador
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

        static public string Nome { get; private set; } = Environment.UserName;
        static public double Dinheiro { get; private set; } = 10;

        static public void ModificaDinheiro(double valor)
        {
            Dinheiro += valor;
            Notificar();
        }
        static new public string ToString()
        {
            return Nome + " | Saldo: R$ " + Dinheiro;
        }
    }
}
