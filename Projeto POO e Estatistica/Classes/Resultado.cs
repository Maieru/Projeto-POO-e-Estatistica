﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO_e_Estatistica.Classes
{
    class Resultado
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Recompensa { get; set; }

        public Resultado(string nome, int incidencias, double recompensa)
        {
            Nome = nome;
            Quantidade = incidencias;
            Recompensa = recompensa;
        }
    }
}
