using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Classe responsavel por realizar os calculos de preço final
    class cl_Calculo {

        // Variaveis privadas pra armazenar porcentagens de acrescimo 
        // Cada uma representa o percentual aplicado conforme o tipo do produto
        private double porcentagem_1 = 5;
        private double porcentagem_2 = 10;
        private double porcentagem_3 = 20;
        private double porcentagem_4 = 25;
        private double porcentagem_5 = 30;

        // Método público que calcula o preço final
        public double CalculaPrecoFinal(double precoinicial, double tipoProduto) {
            // Variável que vai armazena o resultado final, sendo iniciada em 0
            double precoFinal = 0;

            // Estrutura para aplicar a porcentagem correta(um laço de decisão)
            switch (tipoProduto) {
                // Aplica 5% ao preço
                case 1:
                    precoFinal = precoinicial + (precoinicial * (porcentagem_1 / 100));
                    break;

                // Aplica 10% ao preço
                case 2:
                    precoFinal = precoinicial + (precoinicial * (porcentagem_2 / 100));
                    break;

                // Aplica 20% ao preço
                case 3: precoFinal = precoinicial + (precoinicial * (porcentagem_3 / 100));
                    break;

                // Aplica 25% ao preço
                case 4: precoFinal = precoinicial + (precoinicial * (porcentagem_4 / 100));
                    break;

                // Aplica 30% ao preço
                case 5: precoFinal = precoinicial + (precoinicial * (porcentagem_5 / 100));
                    break; 
            }
            // Retorna o valor final calculado
            return precoFinal;
        }
    }
}
