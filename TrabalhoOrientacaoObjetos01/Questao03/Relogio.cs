using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Relogio
    {
        public string Hora, Minuto, Segundo, HoraCompleta, Milhar, Centena, Dezena, Unidade;
        public string ObterHoraPorExtensoEmDezena()
        {
            if (Dezena == "1")
                Dezena = "Dez";

            else if (Dezena == "2")
                Dezena = "Vinte";

            else if (Dezena == "3")
                Dezena = "Trinta";

            else if (Dezena == "4")
                Dezena = "Quarenta";

            else if (Dezena == "5")
                Dezena = "Cinquenta";

            else if (Dezena == "6")
                Dezena = "";

            return Dezena;
        }
        public string ObterHoraPorExtensoEmUnidade()
        {
            if (Unidade == "1")
                Unidade = "Um";

            else if (Unidade == "2")
                Unidade = "Dois";

            else if (Unidade == "3")
                Unidade = "Três";

            else if (Unidade == "4")
                Unidade = "Quatro";

            else if (Unidade == "5")
                Unidade = "Cinco";

            else if (Unidade == "6")
                Unidade = "Seis";


            
            return Unidade;
        }
        public string ObterMinutoPorExtensoEmDezena()
        {
            if (Dezena == "1")
                Dezena = "Dez";

            return Dezena;
        }


    }
}