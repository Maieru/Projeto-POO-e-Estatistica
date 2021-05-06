using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO_e_Estatistica.Classes
{
    class Disco
    {
        private List<Resultado> itensDoDisco;
        private List<Resultado> ItensDoDisco
        {
            get => itensDoDisco;
            set
            {
                foreach (Resultado item in value)
                    if (item.Quantidade <= 0)
                        throw new Exception($"Quantidade de {item.Nome} inválida.");

                itensDoDisco = value;
            }
        }

        public string GirarDisco()
        {
            Random geradorAleatorio = new Random();

            int totalDeItens = 0;
            foreach (Resultado item in ItensDoDisco)
                totalDeItens += item.Quantidade;

            int numeroGerado = geradorAleatorio.Next(totalDeItens) + 1;

            int aux = 0;
            foreach (Resultado item in ItensDoDisco)
            {
                aux += item.Quantidade;
                if (numeroGerado <= aux)
                    return item.Nome;
            }

            throw new Exception("Ocorreu um erro na rolagem do disco, por favor, tente novamente !");
        }

        public Disco (List<Resultado> itensDoDisco)
        {
            ItensDoDisco = itensDoDisco;
        }

    }
}
