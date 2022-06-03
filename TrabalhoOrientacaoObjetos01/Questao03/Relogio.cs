using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    // Guilherme Dzesigaleski Mueller
    public class Relogio
    {
        public string Hora, Minuto, Segundo, HoraCompleta;
        public int Milhar, Centena, Dezena, Unidade;
        public string ObterHoraPorExtensoEmDezena()
        {
            if (Dezena == 1)
                return "Dez";

            else if (Dezena == 2)
                return "Vinte";

            else if (Dezena == 3)
                return "Trinta";

            else if (Dezena == 4)
                return "Quarenta";

            else if (Dezena == 5)
                return "Cinquenta";

            else if (Dezena == 6)
                return "";

            return "";
        }
        public string ObterHoraPorExtensoEmUnidade()
        {
            if (Unidade == 1)
                return "Um";

            else if (Unidade == 2)
                return "dois";

            else if (Unidade == 3)
                return "Três";

            else if (Unidade == 4)
                return "Quatro";

            else if (Unidade == 5)
                return "Cinco";

            else if (Unidade == 6)
                return "Seis";

            else if (Unidade == 7)
                return "Sete";

            else if (Unidade == 8)
                return "Oito";

            else if (Unidade == 9)
            {
                return "Nove";
            }
            else if (Unidade > 9 && Unidade < 20)
            {
                var horaExtenso = Convert.ToDateTime(Hora);

            }
            return "";
        }
        public string ObterMinutoPorExtensoEmDezena()
        {
            if (Dezena == 1)
                return "Dez";

            else if (Dezena == 2)
                return "Vinte";

            else if (Dezena == 3)
                return "Trinta";

            else if (Dezena == 4)
                return "Quarenta";

            else if (Dezena == 5)
                return "Cinquenta";

            else if (Dezena == 6)
                return "";

            return "";
        }
        public string ObterMinutoPorExtensoEmUnidade()
        {
            if (Unidade == 1)
                return "Um";

            else if (Unidade == 2)
                return "Dois";

            else if (Unidade == 3)
                return "Três";

            else if (Unidade == 4)
                return "Quatro";

            else if (Unidade == 5)
                return "Cinco";

            else if (Unidade == 6)
                return "Seis";

            else if (Unidade == 7)
                return "Sete";

            else if (Unidade == 8)
                return "Oito";

            else if (Unidade == 9)
                return "Nove";
            
            else if (Unidade > 9 && Unidade < 20)
            {
                var horaExtenso = Convert.ToDateTime(Hora);

            }
            return "";
        }
        public string ObterSegundosPorExtensoEmDezena()
        {
            if (Dezena == 1)
                return "Dez";

            else if (Dezena == 2)
                return "Vinte";

            else if (Dezena == 3)
                return "Trinta";

            else if (Dezena == 4)
                return "Quarenta";

            else if (Dezena == 5)
                return "Cinquenta";

            else if (Dezena == 6)
                return "";

            return "";
        }
        public string ObterSegundosPorExtensoEmUnidade()
        {
            if (Unidade == 1)
                return "Um";

            else if (Unidade == 2)
                return "Dois";

            else if (Unidade == 3)
                return "Três";

            else if (Unidade == 4)
                return "Quatro";

            else if (Unidade == 5)
                return "Cinco";

            else if (Unidade == 6)
                return "Seis";

            else if (Unidade == 7)
                return "Sete";
            
            else if (Unidade == 8)
                return "Oito";

            else if (Unidade == 9)
                return "Nove";

            else if (Unidade > 9 && Unidade < 20)
            {
                var horaExtenso = Convert.ToDateTime(Hora);

            }
            return "";
        }
        //public string ObterHoraCompleta()
        //{
        //    Console.WriteLine(return ObterHoraPorExtensoEmDezena());
        //}
    }
}