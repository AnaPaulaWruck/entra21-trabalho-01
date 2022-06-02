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

            else if (Unidade == "7")
                Unidade = "Sete";

            else if (Unidade == "8")
                Unidade = "Oito";

            else if (Unidade == "9")
            {
                Unidade = "Nove";
            }
            else if ((Unidade > "9") && (Unidade < "20"))
            {
                var horaExtenso = Convert.ToDateTime(Hora);

            }
            return Unidade;
        }
        public string ObterMinutoPorExtensoEmDezena()
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
        public string ObterMinutoPorExtensoEmUnidade()
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

            else if (Unidade == "7")
                Unidade = "Sete";

            else if (Unidade == "8")
                Unidade = "Oito";

            else if (Unidade == "9")
                Unidade = "Nove";

            return Unidade;
        }
        public string ObterSegundosPorExtensoEmDezena()
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
        public string ObterSegundosPorExtensoEmUnidade()
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

            else if (Unidade == "7")
                Unidade = "Sete";

            else if (Unidade == "8")
                Unidade = "Oito";

            else if (Unidade == "9")
                Unidade = "Nove";

            return Unidade;
        }
    }
}