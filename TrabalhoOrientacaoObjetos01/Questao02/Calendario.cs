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
        //Transformar a data e string.
        public string ObterMesPorExtenso()
        {
            var mes = Data.Month;

            if (mes == 1)
            {
                return "janeiro";
            }
            else if (mes == 2)
            {
                return "fevereiro";
            }
            else if (mes == 3)
            {
                return "março";
            }
            else if (mes == 4)
            {
                return "abril";
            }
            else if (mes == 5)
            {
                return "maio";
            }
            else if (mes == 6)
            {
                return "junho";
            }
            else if (mes == 7)
            {
                return "julho";
            }
            else if (mes == 8)
            {
                return "agosto";
            }
            else if (mes == 9)
            {
                return "setembro";
            }
            else if (mes == 10)
            {
                return "outubro";
            }
            else if (mes == 11)
            {
                return "novembro";
            }
            else if (mes == 12)
            {
                return "dezembro";
            }
            return "Invalido.";
        }
        public string ObterDiaPorExtenso()
        {
            var dia = Data.Day;

            if (dia == 1)
            {
                return "Primeiro de ";
            }
            else if (dia == 2)
            {
                return "Dois de ";
            }
            else if (dia == 3)
            {
                return "Três de ";
            }
            else if (dia == 4)
            {
                return "Quatro de";
            }
            else if (dia == 5)
            {
                return "Cinco de";
            }
            else if (dia == 6)
            {
                return "Seis de";
            }
            else if (dia == 7)
            {
                return "Sete de";
            }
            else if (dia == 8)
            {
                return "Oito de";
            }
            else if (dia == 9)
            {
                return "Nove de";
            }

            return "Ivalido";
        }
        public string ObterAnoPorExtenso()
        {
            var ano = Data.Year;
            
            return "Invatido";
        }

    }
}
