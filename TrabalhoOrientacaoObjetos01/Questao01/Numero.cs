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

		public int ObterMilhar()
        {
			int milhar = Convert.ToInt32((Valor - (Valor % 1000)) / 1000);

			return milhar;
		}

		public int ObterCentena()
		{
			Valor = Math.Round((Valor % 1000), 2);
			int centena = Convert.ToInt32((Valor - (Valor % 100)) / 100);

			return centena;
		}

		public int ObterDezena()
		{
			Valor = Math.Round((Valor % 100), 2);
			int dezena = Convert.ToInt32((Valor - (Valor % 10)) / 10);

			return dezena;
		}

		public int ObterUnidade()
		{
			Valor = Math.Round((Valor % 10), 2);
			int unidade = Convert.ToInt32((Valor - (Valor % 1)) / 1);

			return unidade;
		}

		public int ObterDecimo()
		{
			Valor = Math.Round((Valor % 1), 2);
			int decimo = Convert.ToInt32((Valor - (Valor % 0.1)) / 0.1);

			return decimo;
		}

		public int ObterCentesimo()
		{
			Valor = Math.Round((Valor % 0.1), 2);
			int centesimo = Convert.ToInt32((Valor - (Valor % 0.01)) / 0.01);

			return centesimo;
		}
	}
}


