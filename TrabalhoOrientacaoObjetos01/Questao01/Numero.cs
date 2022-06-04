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
            else if (centenaIsolada == 1 && dezenaIsolada != 0 && unidadeIsolada != 0)
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

            if (dezenaIsolada == 1)
            {
                if (unidadeIsolada == 0)
                {
                    return "dez";
                }
                else if (unidadeIsolada == 1)
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
                if (unidadeIsolada == 0)
                {
                    return "vinte";
                }
                else if (unidadeIsolada == 1)
                {
                    return "vinte e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "vinte e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "vinte e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "vinte e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "vinte e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "vinte e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "vinte e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "vinte e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "vinte e nove";
                }
            }
            else if (dezenaIsolada == 3)
            {
                if (unidadeIsolada == 0)
                {
                    return "trinta";
                }
                else if (unidadeIsolada == 1)
                {
                    return "trinta e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "trinta e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "trinta e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "trinta e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "trinta e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "trinta e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "trinta e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "trinta e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "trinta e nove";
                }
            }
            else if (dezenaIsolada == 4)
            {
                if (unidadeIsolada == 0)
                {
                    return "quarenta";
                }
                else if (unidadeIsolada == 1)
                {
                    return "quarenta e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "quarenta e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "quarenta e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "quarenta e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "quarenta e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "quarenta e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "quarenta e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "quarenta e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "quarenta e nove";
                }
            }
            else if (dezenaIsolada == 5)
            {
                if (unidadeIsolada == 0)
                {
                    return "cinquenta";
                }
                else if (unidadeIsolada == 1)
                {
                    return "cinquenta e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "cinquenta e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "cinquenta e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "cinquenta e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "cinquenta e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "cinquenta e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "cinquenta e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "cinquenta e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "cinquenta e nove";
                }
            }
            else if (dezenaIsolada == 6)
            {
                if (unidadeIsolada == 0)
                {
                    return "sessenta";
                }
                else if (unidadeIsolada == 1)
                {
                    return "sessenta e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "sessenta e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "sessenta e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "sessenta e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "sessenta e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "sessenta e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "sessenta e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "sessenta e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "sessenta e nove";
                }
            }
            else if (dezenaIsolada == 7)
            {
                if (unidadeIsolada == 0)
                {
                    return "setenta";
                }
                else if (unidadeIsolada == 1)
                {
                    return "setenta e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "setenta e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "setenta e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "setenta e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "setenta e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "setenta e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "setenta e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "setenta e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "setenta e nove";
                }
            }
            else if (dezenaIsolada == 8)
            {
                if (unidadeIsolada == 0)
                {
                    return "oitenta";
                }
                else if (unidadeIsolada == 1)
                {
                    return "oitenta e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "oitenta e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "oitenta e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "oitenta e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "oitenta e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "oitenta e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "oitenta e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "oitenta e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "oitenta e nove";
                }
            }
            else if (dezenaIsolada == 9)
            {
                if (unidadeIsolada == 0)
                {
                    return "noventa";
                }
                else if (unidadeIsolada == 1)
                {
                    return "noventa e um";
                }
                else if (unidadeIsolada == 2)
                {
                    return "noventa e dois";
                }
                else if (unidadeIsolada == 3)
                {
                    return "noventa e três";
                }
                else if (unidadeIsolada == 4)
                {
                    return "noventa e quatro";
                }
                else if (unidadeIsolada == 5)
                {
                    return "noventa e cinco";
                }
                else if (unidadeIsolada == 6)
                {
                    return "noventa e seis";
                }
                else if (unidadeIsolada == 7)
                {
                    return "noventa e sete";
                }
                else if (unidadeIsolada == 8)
                {
                    return "noventa e oito";
                }
                else if (unidadeIsolada == 9)
                {
                    return "noventa e nove";
                }
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

            if (decimoIsolado == 1)
            {
                if (centesimoIsolado == 0)
                {
                    return "dez";
                }
                else if (centesimoIsolado == 1)
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
                if (centesimoIsolado == 0)
                {
                    return "vinte";
                }
                else if (centesimoIsolado == 1)
                {
                    return "vinte e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "vinte e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "vinte e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "vinte e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "vinte e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "vinte e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "vinte e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "vinte e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "vinte e nove";
                }
            }
            else if (decimoIsolado == 3)
            {
                if (centesimoIsolado == 0)
                {
                    return "trinta";
                }
                else if (centesimoIsolado == 1)
                {
                    return "trinta e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "trinta e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "trinta e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "trinta e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "trinta e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "trinta e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "trinta e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "trinta e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "trinta e nove";
                }
            }
            else if (decimoIsolado == 4)
            {
                if (centesimoIsolado == 0)
                {
                    return "quarenta";
                }
                else if (centesimoIsolado == 1)
                {
                    return "quarenta e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "quarenta e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "quarenta e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "quarenta e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "quarenta e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "quarenta e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "quarenta e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "quarenta e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "quarenta e nove";
                }
            }
            else if (decimoIsolado == 5)
            {
                if (centesimoIsolado == 0)
                {
                    return "cinquenta";
                }
                else if (centesimoIsolado == 1)
                {
                    return "cinquenta e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "cinquenta e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "cinquenta e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "cinquenta e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "cinquenta e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "cinquenta e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "cinquenta e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "cinquenta e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "cinquenta e nove";
                }
            }
            else if (decimoIsolado == 6)
            {
                if (centesimoIsolado == 0)
                {
                    return "sessenta";
                }
                else if (centesimoIsolado == 1)
                {
                    return "sessenta e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "sessenta e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "sessenta e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "sessenta e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "sessenta e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "sessenta e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "sessenta e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "sessenta e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "sessenta e nove";
                }
            }
            else if (decimoIsolado == 7)
            {
                if (centesimoIsolado == 0)
                {
                    return "setenta";
                }
                else if (centesimoIsolado == 1)
                {
                    return "setenta e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "setenta e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "setenta e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "setenta e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "setenta e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "setenta e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "setenta e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "setenta e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "setenta e nove";
                }
            }
            else if (decimoIsolado == 8)
            {
                if (centesimoIsolado == 0)
                {
                    return "oitenta";
                }
                else if (centesimoIsolado == 1)
                {
                    return "oitenta e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "oitenta e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "oitenta e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "oitenta e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "oitenta e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "oitenta e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "oitenta e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "oitenta e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "oitenta e nove";
                }
            }
            else if (decimoIsolado == 9)
            {
                if (centesimoIsolado == 0)
                {
                    return "noventa";
                }
                else if (centesimoIsolado == 1)
                {
                    return "noventa e um";
                }
                else if (centesimoIsolado == 2)
                {
                    return "noventa e dois";
                }
                else if (centesimoIsolado == 3)
                {
                    return "noventa e três";
                }
                else if (centesimoIsolado == 4)
                {
                    return "noventa e quatro";
                }
                else if (centesimoIsolado == 5)
                {
                    return "noventa e cinco";
                }
                else if (centesimoIsolado == 6)
                {
                    return "noventa e seis";
                }
                else if (centesimoIsolado == 7)
                {
                    return "noventa e sete";
                }
                else if (centesimoIsolado == 8)
                {
                    return "noventa e oito";
                }
                else if (centesimoIsolado == 9)
                {
                    return "noventa e nove";
                }
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

            string apresentarMilharExtenso = milharTexto;

            if (centenaTexto != "")
            {
                apresentarMilharExtenso += " " + centenaTexto;
            }
            if (dezenaTexto != "")
            {
                apresentarMilharExtenso += " " + dezenaTexto;
            }
            if (unidadeTexto != "" && dezenaTexto == "")
            {
                apresentarMilharExtenso += " " + unidadeTexto;
            }
            if (decimoTexto != "")
            {
                apresentarMilharExtenso += " vírgula " + decimoTexto;
            }
            if (centesimoTexto != "" && decimoTexto == "")
            {
                apresentarMilharExtenso += " vírgula " + centesimoTexto;
            }
            
            return apresentarMilharExtenso;
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
