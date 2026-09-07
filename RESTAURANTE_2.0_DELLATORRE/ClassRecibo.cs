using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANTE_2._0_DELLATORRE
{
    //classe para pegar os dados do formulario e transformar em objeto para lançar no novo formulario de recibo
    public class ClassRecibo
    {
        // recebe todos os dados
        public string GerarTextoRecibo(string nome, string nascimento, string onde,
                                       bool almoco, bool refrig, bool cerveja, bool suco,
                                       string totalTexto)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendLine("--- RECIBO DO CLIENTE ---");
            msg.AppendLine();
            msg.AppendLine("Nome: " + nome);
            msg.AppendLine("Nascimento: " + nascimento);

            if (onde != "")
            {
                msg.AppendLine("Onde: " + onde);
            }

            msg.AppendLine();
            msg.AppendLine("--- ITENS CONSUMIDOS ---");

            if (almoco) msg.AppendLine("Almoço");
            if (refrig) msg.AppendLine("Refrigerante");
            if (cerveja) msg.AppendLine("Cerveja");
            if (suco) msg.AppendLine("Suco");            

            msg.AppendLine();
            msg.AppendLine(totalTexto); // Adiciona o total no final

            // Transforma tudo que foi montado no StringBuilder em uma string normal e devolve
            return msg.ToString();
        }
    }
}