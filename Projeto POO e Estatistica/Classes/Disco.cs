using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO_e_Estatistica.Classes
{
    class Disco
    {
        /* 
         * É vital para o funcionamento da classe que o gerador seja estático.
         * Caso contrário, o mesmo geraria o mesmo número para todas as instancias
         * da classe, fazendo com que o jogador tivesse quase 100% de chance
         * de vir 3 resultados iguais.
        */
        static private Random geradorRandomico = new Random();

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

        /*
         * O disco calcula o numero de itens dentro dele e, gera um numero
         * entre 1 e esse número. Após isso, ele soma os itens, até que a
         * soma seja maior ou igual que o número sorteado
         */ 
        public string GirarDisco()
        {
            int totalDeItens = 0;
            foreach (Resultado item in ItensDoDisco)
                totalDeItens += item.Quantidade;

            int numeroGerado = geradorRandomico.Next(totalDeItens) + 1;

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
