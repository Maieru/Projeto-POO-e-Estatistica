using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO_e_Estatistica.Classes
{
    class Jogador
    {
        public string Nome { get; private set; }
        public double Dinheiro { get; private set; }

        public void ModificaDinheiro(double valor) => Dinheiro += valor;
        public override string ToString()
        {
            return Nome + " | Saldo: R$ " + Dinheiro;
        }
        public Jogador()
        {
            Nome = Environment.UserName;
            Dinheiro = 10;
        }
    }
}
