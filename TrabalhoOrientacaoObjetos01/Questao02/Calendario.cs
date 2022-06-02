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
            else if (mes > 9)
            {
                var mesString = Convert.ToString(mes);
                if (Convert.ToString(mesString[1]) == "0")
                {
                    return "outubro";
                }
                else if (Convert.ToString(mesString[1]) == "1")
                {
                    return "novembro";
                }
                else if (Convert.ToString(mesString[1]) == "2")
                {
                    return "dezembro";
                }

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
                return "Nove de ";
            }
            else if (dia > 9 && dia < 20)
            {
                var diaString = Convert.ToString(dia);
                if (Convert.ToString(diaString[1]) == "1")
                {
                    return "Onze de ";
                }
                else if (Convert.ToString(diaString[1]) == "2")
                {
                    return "Doze de ";
                }
                else if (Convert.ToString(diaString[1]) == "3")
                {
                    return "Treze de ";
                }
                else if (Convert.ToString(diaString[1]) == "4")
                {
                    return "Quatorze de ";
                }
                else if (Convert.ToString(diaString[1]) == "5")
                {
                    return "Quinze de ";
                }
                else if (Convert.ToString(diaString[1]) == "6")
                {
                    return "Dezesseis de ";
                }
                else if (Convert.ToString(diaString[1]) == "7")
                {
                    return "Dezessete ";
                }
                else if (Convert.ToString(diaString[1]) == "8")
                {
                    return "Dezoito ";
                }
                else if (Convert.ToString(diaString[1]) == "9")
                {
                    return "Dezenove ";
                }
            }
            else if (dia < 30)
            {
                var diaString = Convert.ToString(dia);
                if (Convert.ToString(diaString[1]) == "1")
                {
                    if (Convert.ToString(diaString[1]) == "0")
                    {
                        return "Vinte";
                    }
                    else if (Convert.ToString(diaString[1]) == "1")
                    {
                        return "Vinte e um";
                    }
                    else if (Convert.ToString(diaString[1]) == "2")
                    {
                        return "Vinte e dois";
                    }
                    else if (Convert.ToString(diaString[1]) == "3")
                    {
                        return "Vinte e três";
                    }
                    else if (Convert.ToString(diaString[1]) == "4")
                    {
                        return "Vinte e quatro";
                    }
                    else if (Convert.ToString(diaString[1]) == "5")
                    {
                        return "Vinte e cinco";
                    }
                    else if (Convert.ToString(diaString[1]) == "6")
                    {
                        return "Vinte e seis";
                    }
                    else if (Convert.ToString(diaString[1]) == "7")
                    {
                        return "Vinte e sete";
                    }
                    else if (Convert.ToString(diaString[1]) == "8")
                    {
                        return "Vinte e oito";
                    }
                    else if (Convert.ToString(diaString[1]) == "9")
                    {
                        return "Vinte e nove";
                    }
                }
            }
            else if (dia < 31)
            {
                var diaString = Convert.ToString(dia);
                if (Convert.ToString(diaString[1]) == "0")
                {
                    return "Trinta";
                }
                else
                {
                    return "Trinta e dois";
                }
            }

            return "Ivalido";
        }
        public string ObterAnoPorExtenso()
        {
            var ano = Convert.ToString(Data.Year);
            string milhar = ano.Substring(0, 1);
            string centena = ano.Substring(1, 1);
            string dezena = ano.Substring(2, 1);
            string unidade = ano.Substring(3, 1);
            if (milhar == "1")
            {
                milhar = "mil";
            }
            else if (milhar == "2")
            {
                milhar = "dois mil";
            }
            if (centena == "1")
            {
                centena = "cento";
            }
            else if (centena == "2")
            {
                centena = "duzentos";
            }
            else if (centena == "3")
            {
                centena = "trezentos";
            }
            else if (centena == "4")
            {
                centena = "quatrocentos";
            }
            else if (centena == "5")
            {
                centena = "quinhentos";
            }
            else if (centena == "6")
            {
                centena = "seiscentos";
            }
            else if (centena == "7")
            {
                centena = "setecentos";
            }
            else if (centena == "8")
            {
                centena = "oitocentos";
            }
            else if (centena == "9")
            {
                centena = "novecentos";
            }
            else
            {
                centena = "";
            }
            if (dezena == "2")
            {
                dezena = "vinte";
            }
            else if (dezena == "3")
            {
                dezena = "trinta";
            }
            else if (dezena == "4")
            {
                dezena = "quarenta";
            }
            else if (dezena == "5")
            {
                dezena = "cinquenta";
            }
            else if (dezena == "6")
            {
                dezena = "sessenta";
            }
            else if (dezena == "7")
            {
                dezena = "setenta";
            }
            else if (dezena == "8")
            {
                dezena = "oitenta";
            }
            else if (dezena == "9")
            {
                dezena = "noventa";
            }
            else if ((dezena == "1") && (unidade == "0"))
            {
                dezena = "dez";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "1"))
            {
                dezena = "onze";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "2"))
            {
                dezena = "doze";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "3"))
            {
                dezena = "treze";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "4"))
            {
                dezena = "catorze";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "5"))
            {
                dezena = "quinze";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "6"))
            {
                dezena = "dezesseis";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "7"))
            {
                dezena = "dezessete";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "8"))
            {
                dezena = "dezoito";
                unidade = "";
            }
            else if ((dezena == "1") && (unidade == "9"))
            {
                dezena = "dezenove";
                unidade = "";
            }
            else
            {
                dezena = "";
            }
            if (unidade == "1")
            {
                unidade = "um";
            }
            else if (unidade == "2")
            {
                unidade = "dois";
            }
            else if (unidade == "3")
            {
                unidade = "três";
            }
            else if (unidade == "4")
            {
                unidade = "quatro";
            }
            else if (unidade == "5")
            {
                unidade = "cinco";
            }
            else if (unidade == "6")
            {
                unidade = "seis";
            }
            else if (unidade == "7")
            {
                unidade = "sete";
            }
            else if (unidade == "8")
            {
                unidade = "oito";
            }
            else if (unidade == "9")
            {
                unidade = "nove";
            }
            else
            {
                unidade = "";
            }

            return milhar + " " + centena + " " + dezena + " " + unidade;
        }
        public string ObterDataCompletaPorExtenso()
        {
            var dataPorExtenso = ObterDiaPorExtenso() + " de " + ObterMesPorExtenso() + " de " + ObterAnoPorExtenso();

            return dataPorExtenso;
        }
    }
}
