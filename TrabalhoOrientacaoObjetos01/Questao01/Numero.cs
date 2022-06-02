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

		/* double valor = 1645.32;

		double milhar = (valor - (valor % 1000)) / 1000;
		valor = Math.Round((valor % 1000), 2);
		Console.WriteLine(milhar);
		Console.WriteLine(valor);
		
		double centena = (valor - (valor % 100)) / 100;
		valor = Math.Round((valor % 100), 2);
		Console.WriteLine(centena);
		Console.WriteLine(valor);
		
		double dezena = (valor - (valor % 10)) / 10;
		valor = Math.Round((valor % 10), 2);
		Console.WriteLine(dezena);
		Console.WriteLine(valor);
		
		double unidade = (valor - (valor % 1)) / 1;
		valor = Math.Round((valor % 1), 2);
		Console.WriteLine(unidade);
		Console.WriteLine(valor);
		
		double decimo = (valor - (valor % 0.1)) / 0.1;
		valor = Math.Round((valor % 0.1), 2);
		Console.WriteLine(decimo);
		Console.WriteLine(valor);
		
		double centesimo = (valor - (valor % 0.01)) / 0.01;
		valor = Math.Round((valor % 0.01), 2);
		Console.WriteLine(centesimo);
		Console.WriteLine(valor);

		*/
    }
}


