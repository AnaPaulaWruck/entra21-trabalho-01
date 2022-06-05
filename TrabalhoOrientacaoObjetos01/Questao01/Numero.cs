using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    // Ana Paula Wruck
    public class Numero
    {
        public double Valor;

        public int ObterMilharIsolado()
        {
            double valor = Valor;

            int milhar = Convert.ToInt32((valor - (valor % 1000)) / 1000);

            return milhar;
        }

        public int ObterCentenaIsolada()
        {
            double valor = Valor;

            int milhar = Convert.ToInt32((valor - (valor % 1000)) / 1000);
            int centena = Convert.ToInt32((valor - (valor % 100)) / 100);
            centena = centena - (milhar * 10);

            return centena;
        }

        public int ObterDezenaIsolada()
        {
            double valor = Valor;

            int milhar = Convert.ToInt32((valor - (valor % 1000)) / 1000);
            int centena = Convert.ToInt32((valor - (valor % 100)) / 100);
            centena -= (milhar * 10);
            int dezena = Convert.ToInt32((valor - (valor % 10)) / 10);
            dezena = dezena - (centena * 10) - (milhar * 100);

            return dezena;
        }

        public int ObterUnidadeIsolada()
        {
            double valor = Valor;

            int milhar = Convert.ToInt32((valor - (valor % 1000)) / 1000);
            int centena = Convert.ToInt32((valor - (valor % 100)) / 100);
            centena -= (milhar * 10);
            int dezena = Convert.ToInt32((valor - (valor % 10)) / 10);
            dezena = dezena - (centena * 10) - (milhar * 100);
            int unidade = Convert.ToInt32((valor - (valor % 1)) / 1);
            unidade = unidade - (dezena * 10) - (centena * 100) - (milhar * 1000);

            return unidade;
        }

        public int ObterDecimoIsolado()
        {
            double valor = Valor;

            int milhar = Convert.ToInt32((valor - (valor % 1000)) / 1000);
            int centena = Convert.ToInt32((valor - (valor % 100)) / 100);
            centena -= (milhar * 10);
            int dezena = Convert.ToInt32((valor - (valor % 10)) / 10);
            dezena = dezena - (centena * 10) - (milhar * 100);
            int unidade = Convert.ToInt32((valor - (valor % 1)) / 1);
            unidade = unidade - (dezena * 10) - (centena * 100) - (milhar * 1000);
            int decimo = Convert.ToInt32((valor - Math.Round(valor % 0.1)) / 0.1);
            decimo = decimo - (unidade * 10) - (dezena * 100) - (centena * 1000) - (milhar * 10000);

            return decimo;
        }

        public int ObterCentesimoIsolado()
        {
            double valor = Valor;

            int milhar = Convert.ToInt32((valor - (valor % 1000)) / 1000);
            int centena = Convert.ToInt32((valor - (valor % 100)) / 100);
            centena -= (milhar * 10);
            int dezena = Convert.ToInt32((valor - (valor % 10)) / 10);
            dezena = dezena - (centena * 10) - (milhar * 100);
            int unidade = Convert.ToInt32((valor - (valor % 1)) / 1);
            unidade = unidade - (dezena * 10) - (centena * 100) - (milhar * 1000);
            int decimo = Convert.ToInt32((valor - Math.Round(valor % 0.1)) / 0.1);
            decimo = decimo - (unidade * 10) - (dezena * 100) - (centena * 1000) - (milhar * 10000);
            int centesimo = Convert.ToInt32((valor - Math.Round(valor % 0.01)) / 0.01);
            centesimo = centesimo - (decimo * 10) - (unidade * 100) - (dezena * 1000) - (centena * 10000) - (milhar * 100000);

            return centesimo;
        }

        public string ObterMilharExtenso()
        {
            int milharIsolado = ObterMilharIsolado();

            if (milharIsolado == 1)
            {
                return "mil";
            }
            else if (milharIsolado == 2)
            {
                return "dois mil";
            }
            else if (milharIsolado == 3)
            {
                return "três mil";
            }
            else if (milharIsolado == 4)
            {
                return "quatro mil";
            }
            else if (milharIsolado == 5)
            {
                return "cinco mil";
            }
            else if (milharIsolado == 6)
            {
                return "seis mil";
            }
            else if (milharIsolado == 7)
            {
                return "sete mil";
            }
            else if (milharIsolado == 8)
            {
                return "oito mil";
            }
            else if (milharIsolado == 9)
            {
                return "nove mil";
            }

            // Se zero:
            return "";
        }

        public string ObterCentenaExtenso()
        {
            int centenaIsolada = ObterCentenaIsolada();
            int dezenaIsolada = ObterDezenaIsolada();
            int unidadeIsolada = ObterUnidadeIsolada();

            if (centenaIsolada == 1 && dezenaIsolada == 0 && unidadeIsolada == 0)
            {
                return "cem";
            }
            else if (centenaIsolada == 1 && (dezenaIsolada != 0 || unidadeIsolada != 0))
            {
                return "cento";
            }
            else if (centenaIsolada == 2)
            {
                return "duzentos";
            }
            else if (centenaIsolada == 3)
            {
                return "trezentos";
            }
            else if (centenaIsolada == 4)
            {
                return "quatrocentos";
            }
            else if (centenaIsolada == 5)
            {
                return "quinhentos";
            }
            else if (centenaIsolada == 6)
            {
                return "seiscentos";
            }
            else if (centenaIsolada == 7)
            {
                return "setecentos";
            }
            else if (centenaIsolada == 8)
            {
                return "oitocentos";
            }
            else if (centenaIsolada == 9)
            {
                return "novecentos";
            }

            // Se zero:
            return "";
        }

        public string ObterDezenaExtenso()

        {
            int dezenaIsolada = ObterDezenaIsolada();
            int unidadeIsolada = ObterUnidadeIsolada();

            if (dezenaIsolada == 1 && unidadeIsolada == 0)
            {
                return "dez";
            }
            else if (dezenaIsolada == 1 && unidadeIsolada != 0)
            {
                if (unidadeIsolada == 1)
                {
                    return "onze";
                }
                else if (unidadeIsolada == 2)
                {
                    return "doze";
                }
                else if (unidadeIsolada == 3)
                {
                    return "treze";
                }
                else if (unidadeIsolada == 4)
                {
                    return "catorze";
                }
                else if (unidadeIsolada == 5)
                {
                    return "quinze";
                }
                else if (unidadeIsolada == 6)
                {
                    return "dezesseis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "dezessete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "dezoito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "dezenove";
                }
            }
            else if (dezenaIsolada == 2)
            {
                return "vinte";
            }
            else if (dezenaIsolada == 3)
            {
                return "trinta";
            }
            else if (dezenaIsolada == 4)
            {
                return "quarenta";
            }
            else if (dezenaIsolada == 5)
            {
                return "cinquenta";
            }
            else if (dezenaIsolada == 6)
            {
                return "sessenta";
            }
            else if (dezenaIsolada == 7)
            {
                return "setenta";
            }
            else if (dezenaIsolada == 8)
            {
                return "oitenta";
            }
            else if (dezenaIsolada == 9)
            {
                return "noventa";
            }

            // Se zero:
            return "";
        }

        public string ObterUnidadeExtenso()
        {
            int milharIsolado = ObterMilharIsolado();
            int centenaIsolada = ObterCentenaIsolada();
            int dezenaIsolada = ObterDezenaIsolada();
            int unidadeIsolada = ObterUnidadeIsolada();

            if (unidadeIsolada == 1)
            {
                return "um";
            }
            else if (unidadeIsolada == 2)
            {
                return "dois";
            }
            else if (unidadeIsolada == 3)
            {
                return "três";
            }
            else if (unidadeIsolada == 4)
            {
                return "quatro";
            }
            else if (unidadeIsolada == 5)
            {
                return "cinco";
            }
            else if (unidadeIsolada == 6)
            {
                return "seis";
            }
            else if (unidadeIsolada == 7)
            {
                return "sete";
            }
            else if (unidadeIsolada == 8)
            {
                return "oito";
            }
            else if (unidadeIsolada == 9)
            {
                return "nove";
            }
            else if (unidadeIsolada == 0 && dezenaIsolada == 0 && centenaIsolada == 0 && milharIsolado == 0)
            {
                return "zero";
            }

            return "";
        }

        public string ObterDecimoExtenso()
        {
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            if (decimoIsolado == 1 && centesimoIsolado == 0)
            {
                return "dez";
            }
            else if (decimoIsolado == 1 && centesimoIsolado != 0)
            {
                if (centesimoIsolado == 1)
                {
                    return "onze";
                }
                else if (centesimoIsolado == 2)
                {
                    return "doze";
                }
                else if (centesimoIsolado == 3)
                {
                    return "treze";
                }
                else if (centesimoIsolado == 4)
                {
                    return "catorze";
                }
                else if (centesimoIsolado == 5)
                {
                    return "quinze";
                }
                else if (centesimoIsolado == 6)
                {
                    return "dezesseis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "dezessete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "dezoito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "dezenove";
                }
            }
            else if (decimoIsolado == 2)
            {
                return "vinte";
            }
            else if (decimoIsolado == 3)
            {
                return "trinta";
            }
            else if (decimoIsolado == 4)
            {
                return "quarenta";
            }
            else if (decimoIsolado == 5)
            {
                return "cinquenta";
            }
            else if (decimoIsolado == 6)
            {
                return "sessenta";
            }
            else if (decimoIsolado == 7)
            {
                return "setenta";
            }
            else if (decimoIsolado == 8)
            {
                return "oitenta";
            }
            else if (decimoIsolado == 9)
            {
                return "noventa";
            }

            // Se zero:
            return "";
        }

        public string ObterCentesimoExtenso()
        {
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            if (centesimoIsolado == 1)
            {
                return "um";
            }
            else if (centesimoIsolado == 2)
            {
                return "dois";
            }
            else if (centesimoIsolado == 3)
            {
                return "três";
            }
            else if (centesimoIsolado == 4)
            {
                return "quatro";
            }
            else if (centesimoIsolado == 5)
            {
                return "cinco";
            }
            else if (centesimoIsolado == 6)
            {
                return "seis";
            }
            else if (centesimoIsolado == 7)
            {
                return "sete";
            }
            else if (centesimoIsolado == 8)
            {
                return "oito";
            }
            else if (centesimoIsolado == 9)
            {
                return "nove";
            }
            else if (decimoIsolado == 0 && centesimoIsolado == 0)
            {
                return "zero";
            }

            return "";
        }

        public string ApresentarMilharExtenso()
        {
            string milharTexto = ObterMilharExtenso();
            string centenaTexto = ObterCentenaExtenso();
            string dezenaTexto = ObterDezenaExtenso();
            string unidadeTexto = ObterUnidadeExtenso();
            string decimoTexto = ObterDecimoExtenso();
            string centesimoTexto = ObterCentesimoExtenso();

            int dezenaIsolada = ObterDezenaIsolada();
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            // Milhar
            string apresentarMilharExtenso = milharTexto;

            // Centena
            if (centenaTexto != "" && milharTexto != "")
            {
                apresentarMilharExtenso += " e " + centenaTexto;
            }
            else if (centenaTexto != "" && milharTexto == "")
            {
                apresentarMilharExtenso += centenaTexto;
            }

            // Dezena
            if (dezenaTexto != "" && (milharTexto != "" || centenaTexto != ""))
            {
                apresentarMilharExtenso += " e " + dezenaTexto;
            }
            else if (dezenaTexto != "" && (milharTexto == "" || centenaTexto == ""))
            {
                apresentarMilharExtenso += dezenaTexto;
            }

            // Unidade
            if (unidadeTexto != "" && dezenaTexto != "" && dezenaIsolada != 1)
            {
                apresentarMilharExtenso += " e " + unidadeTexto;
            }
            else if (unidadeTexto != "" && dezenaTexto == "" && (centenaTexto != "" || milharTexto != ""))
            {
                apresentarMilharExtenso += " e " + unidadeTexto;
            }
            else if (unidadeTexto != "" && dezenaTexto == "" && centenaTexto == "" && milharTexto == "")
            {
                apresentarMilharExtenso += unidadeTexto;
            }

            // Décimo
            if (decimoTexto != "")
            {
                apresentarMilharExtenso += " vírgula " + decimoTexto;
            }

            // Centésimo
            if (centesimoTexto != "" && decimoTexto != "" && decimoIsolado != 1)
            {
                apresentarMilharExtenso += " e " + centesimoTexto;
            }
            else if (centesimoTexto != "" && centesimoIsolado == 0 && decimoIsolado == 0)
            {
                apresentarMilharExtenso += " vírgula " + centesimoTexto;
            }
            else if (centesimoTexto != "" && decimoIsolado == 0 && centesimoIsolado != 0)
            {
                apresentarMilharExtenso += " vírgula zero " + centesimoTexto;
            }

            return apresentarMilharExtenso;
        }

        public string ApresentarCentenaExtenso()
        {
            string centenaTexto = ObterCentenaExtenso();
            string dezenaTexto = ObterDezenaExtenso();
            string unidadeTexto = ObterUnidadeExtenso();
            string decimoTexto = ObterDecimoExtenso();
            string centesimoTexto = ObterCentesimoExtenso();

            int dezenaIsolada = ObterDezenaIsolada();
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            // Centena
            string apresentarCentenaExtenso = centenaTexto;

            // Dezena
            if (dezenaTexto != "" && centenaTexto != "")
            {
                apresentarCentenaExtenso += " e " + dezenaTexto;
            }
            else if (dezenaTexto != "" && centenaTexto == "")
            {
                apresentarCentenaExtenso += dezenaTexto;
            }

            // Unidade
            if (unidadeTexto != "" && dezenaTexto != "" && dezenaIsolada != 1)
            {
                apresentarCentenaExtenso += " e " + unidadeTexto;
            }
            else if (unidadeTexto != "" && dezenaTexto == "" && centenaTexto != "")
            {
                apresentarCentenaExtenso += " e " + unidadeTexto;
            }
            else if (unidadeTexto != "" && dezenaTexto == "" && centenaTexto == "")
            {
                apresentarCentenaExtenso += unidadeTexto;
            }

            // Décimo
            if (decimoTexto != "")
            {
                apresentarCentenaExtenso += " vírgula " + decimoTexto;
            }

            // Centésimo
            if (centesimoTexto != "" && decimoTexto != "" && decimoIsolado != 1)
            {
                apresentarCentenaExtenso += " e " + centesimoTexto;
            }
            else if (centesimoTexto != "" && centesimoIsolado == 0 && decimoIsolado == 0)
            {
                apresentarCentenaExtenso += " vírgula " + centesimoTexto;
            }
            else if (centesimoTexto != "" && decimoIsolado == 0 && centesimoIsolado != 0)
            {
                apresentarCentenaExtenso += " vírgula zero " + centesimoTexto;
            }

            return apresentarCentenaExtenso;
        }

        public string ApresentarDezenaExtenso()
        {
            string dezenaTexto = ObterDezenaExtenso();
            string unidadeTexto = ObterUnidadeExtenso();
            string decimoTexto = ObterDecimoExtenso();
            string centesimoTexto = ObterCentesimoExtenso();

            int dezenaIsolada = ObterDezenaIsolada();
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            // Dezena
            string apresentarDezenaExtenso = dezenaTexto;

            // Unidade
            if (unidadeTexto != "" && dezenaTexto != "" && dezenaIsolada != 1)
            {
                apresentarDezenaExtenso += " e " + unidadeTexto;
            }
            else if (unidadeTexto != "" && dezenaTexto == "")
            {
                apresentarDezenaExtenso += unidadeTexto;
            }

            // Décimo
            if (decimoTexto != "")
            {
                apresentarDezenaExtenso += " vírgula " + decimoTexto;
            }

            // Centésimo
            if (centesimoTexto != "" && decimoTexto != "" && decimoIsolado != 1)
            {
                apresentarDezenaExtenso += " e " + centesimoTexto;
            }
            else if (centesimoTexto != "" && centesimoIsolado == 0 && decimoIsolado == 0)
            {
                apresentarDezenaExtenso += " vírgula " + centesimoTexto;
            }
            else if (centesimoTexto != "" && decimoIsolado == 0 && centesimoIsolado != 0)
            {
                apresentarDezenaExtenso += " vírgula zero " + centesimoTexto;
            }

            return apresentarDezenaExtenso;
        }

        public string ApresentarUnidadeExtenso()
        {
            string unidadeTexto = ObterUnidadeExtenso();
            string decimoTexto = ObterDecimoExtenso();
            string centesimoTexto = ObterCentesimoExtenso();

            int unidadeIsolada = ObterUnidadeIsolada();
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            // Unidade
            string apresentarUnidadeExtenso = unidadeTexto;
            if (unidadeIsolada == 0)
            {
                apresentarUnidadeExtenso = "zero";
            }

            // Décimo
            if (decimoTexto != "")
            {
                apresentarUnidadeExtenso += " vírgula " + decimoTexto;
            }

            // Centésimo
            if (centesimoTexto != "" && decimoTexto != "" && decimoIsolado != 1)
            {
                apresentarUnidadeExtenso += " e " + centesimoTexto;
            }
            else if (centesimoTexto != "" && centesimoIsolado == 0 && decimoIsolado == 0)
            {
                apresentarUnidadeExtenso += " vírgula " + centesimoTexto;
            }
            else if (centesimoTexto != "" && decimoIsolado == 0 && centesimoIsolado != 0)
            {
                apresentarUnidadeExtenso += " vírgula zero " + centesimoTexto;
            }

            return apresentarUnidadeExtenso;
        }

        public string ApresentarDecimalExtenso()
        {
            string decimoTexto = ObterDecimoExtenso();
            string centesimoTexto = ObterCentesimoExtenso();

            int unidadeIsolada = ObterUnidadeIsolada();
            int decimoIsolado = ObterDecimoIsolado();
            int centesimoIsolado = ObterCentesimoIsolado();

            string apresentarDecimalExtenso = "zero vírgula";

            // Décimo
            if (decimoTexto != "")
            {
                apresentarDecimalExtenso += " " + decimoTexto;
            }

            // Centésimo
            if (centesimoTexto != "" && decimoTexto != "" && decimoIsolado != 1)
            {
                apresentarDecimalExtenso += " e " + centesimoTexto;
            }
            else if (centesimoTexto != "" && centesimoIsolado == 0 && decimoIsolado == 0)
            {
                apresentarDecimalExtenso += " " + centesimoTexto;
            }
            else if (centesimoTexto != "" && decimoIsolado == 0 && centesimoIsolado != 0)
            {
                apresentarDecimalExtenso += " zero " + centesimoTexto;
            }

            return apresentarDecimalExtenso;
        }
    }
}

// situações a considerar:

// 1000 - mil
// 1100 - mil e cem
// 1010 - mil e dez
// 1001 - mil e um
// 1000,2 - mil inteiro e 1 décimo

// 100 - cem
// 110 - cento e dez
// 101 - cento e um
// 100,1 - cem inteiro e um décimo

// 10, 11, 12, ..., 19 - dez, onze, doze, ..., dezenove
// mesmo para decimal e centesimal

// 20, 30, 40, ..., 90 - vinte, trinta, quarenta, ..., noventa

// 21 - vinte e um
// 21,23 - vinte e um inteiro e vinte e três centésimos

// 0,1 - um décimo
// 0,01 - um centésimo
// 0,11 - onze centésimos
