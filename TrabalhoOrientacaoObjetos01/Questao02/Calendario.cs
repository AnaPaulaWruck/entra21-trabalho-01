using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class Calendario
    {
        public DateTime Data;

        public string ObterMesPorExtenso()
        {
            var mes = Data.Month;

            if (mes == 1)
            {
                return "Janeiro";
            }
            else if (mes == 2)
            {
                return "Fevereiro";
            }
            else if (mes == 3)
            {
                return "Março";
            }
            else if (mes == 4)
            {
                return "Abril";
            }
            else if (mes == 5)
            {
                return "Maio";
            }
            else if (mes == 6)
            {
                return "Junho";
            }
            else if (mes == 7)
            {
                return "Julho";
            }
            else if (mes == 8)
            {
                return "Agosto";
            }
            else if (mes == 9)
            {
                return "Setembro";
            }
            else if (mes == 10)
            {
                return "Outubro";
            }
            else if (mes == 11)
            {
                return "Novembro";
            }
            else if (mes == 12)
            {
                return "Dezembro";
            }
            return "Invalido.";
        }
      

    }
}
