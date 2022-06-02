using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class Numero
    {
        public double Valor;

        public bool VerificarSeValorValido()
        {
            if (Valor < 0.00 || Valor > 9999.99)
            {
                return false;
            }

            return true;
        }

        public int ObterMilharIsolado()
        {
            int milhar = 0;

            if (VerificarSeValorValido() == true)
            {
                milhar = Convert.ToInt32((Valor - (Valor % 1000)) / 1000);
            }

            return milhar;
        }

        public int ObterCentenaIsolada()
        {
            int centena = 0;

            if (VerificarSeValorValido() == true)
            {
                Valor = Math.Round((Valor % 1000), 2);
                centena = Convert.ToInt32((Valor - (Valor % 100)) / 100);
            }

            return centena;
        }

        public int ObterDezenaIsolada()
        {
            int dezena = 0;

            if (VerificarSeValorValido() == true)
            {
                Valor = Math.Round((Valor % 100), 2);
                dezena = Convert.ToInt32((Valor - (Valor % 10)) / 10);
            }

            return dezena;
        }

        public int ObterUnidadeIsolada()
        {
            int unidade = 0;

            if (VerificarSeValorValido() == true)
            {
                Valor = Math.Round((Valor % 10), 2);
                unidade = Convert.ToInt32((Valor - (Valor % 1)) / 1);
            }

            return unidade;
        }

        public int ObterDecimoIsolado()
        {
            int decimo = 0;

            if (VerificarSeValorValido() == true)
            {
                Valor = Math.Round((Valor % 1), 2);
                decimo = Convert.ToInt32((Valor - (Valor % 0.1)) / 0.1);
            }

            return decimo;
        }

        public int ObterCentesimoIsolado()
        {
            int centesimo = 0;

            if (VerificarSeValorValido() == true)
            {
                Valor = Math.Round((Valor % 0.1), 2);
                centesimo = Convert.ToInt32((Valor - (Valor % 0.01)) / 0.01);
            }

            return centesimo;
        }

        public string ObterMilharExtenso()
        {
            int milharIsolado = ObterMilharIsolado();
            string milharExtenso = "";

            if (milharIsolado == 1)
            {
                milharExtenso = "mil";
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
            return milharExtenso;
        }

        public string ObterCentenaExtenso()
        {
            int centenaIsolada = ObterCentenaIsolada();
            int dezenaIsolada = ObterDezenaIsolada();
            int unidadeIsolada = ObterUnidadeIsolada();
            string centenaExtenso = "";

            if (centenaIsolada == 1 && dezenaIsolada == 0 && unidadeIsolada == 0)
            {
                centenaExtenso= "cem";
            }
            else if (centenaIsolada == 1 && dezenaIsolada != 0 && unidadeIsolada != 0)
            {
                centenaExtenso = "cento";
            }
            else if (centenaIsolada == 2)
            {
                centenaExtenso = "duzentos";
            }
            else if (centenaIsolada == 3)
            {
                centenaExtenso = "trezentos";
            }
            // continuar alteração
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
            if (ObterDezenaIsolada() == 1 && ObterUnidadeIsolada() == 0)
            {
                return "dez";
            }

            // Se zero:
            return "";
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
