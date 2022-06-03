using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    public class ExecutarNumero
    {
        public void Executar()
        {
            var numero = new Numero();
            numero.Valor = 0000.52;

            Console.WriteLine("Valor válido: " + numero.VerificarSeValorValido());

            //Console.WriteLine("Milhar: " + numero.ObterMilharIsolado());
            //Console.WriteLine("Centena: " + numero.ObterCentenaIsolada());
            //Console.WriteLine("Dezena: " + numero.ObterDezenaIsolada());
            //Console.WriteLine("Unidade: " + numero.ObterUnidadeIsolada());
            //Console.WriteLine("Décimo: " + numero.ObterDecimoIsolado());
            //Console.WriteLine("Centésimo: " + numero.ObterCentesimoIsolado());

            //Console.WriteLine("Milhar extenso: " + numero.ObterMilharExtenso());
            //Console.WriteLine("Centena extenso: " + numero.ObterCentenaExtenso());
            //Console.WriteLine("Dezena extenso: " + numero.ObterDezenaExtenso());
            Console.WriteLine("Unidade extenso: " + numero.ObterUnidadeExtenso());
            //Console.WriteLine("Décimo extenso: " + numero.ObterDecimoExtenso());
            //Console.WriteLine("Centésimo extenso: " + numero.ObterCentesimoExtenso());

            //Console.WriteLine("Valor total: " + numero.ObterValorTotalExtenso());
        }
    }
}