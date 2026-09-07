using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANTE_2._0_DELLATORRE
{
    public class ClassCalculo
    {
        public decimal Total { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal TotalFinal { get; private set; }

        /*aqui ele verifica se as variaveis abaixo sao verdadeiras ou nao, se sim, adiciona na conta final*/
        public void Calcular(bool almoco, bool refrigerante, bool cerveja, bool suco)
        {
            Total = 0;
            Desconto = 0;
            TotalFinal = 0;

            if (almoco)
            {
                Total += 35.00m;
            }
            if (refrigerante)
            {
                Total += 12.00m;
            }
            if (cerveja)
            {
                Total += 15.00m;
            }
            if (suco)
            {
                Total += 11.50m;
            }

            TotalFinal = Total;
        }

        /*verifica se o usuario é aniversariante ou nao, se verdadeiro, valor final volta com desconto*/
        public void DescontoAniversariante(bool aniversariante)
        {
            if (aniversariante)
            {
                Desconto = Total * 0.03m;
                TotalFinal = Total - Desconto;
            }
            else
            {
                Desconto = 0;
                TotalFinal = Total;
            }
        }
    }
}