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

        public bool VerificarSeValorAceito()
        {
            if (Valor < 0.00 || Valor > 9999.99)
            {
                return false;
            }

            return true;
        }

        //public bool VerificarSeValorInteiro()
        //{
        //    if (VerificarSeValorAceito() == true)
        //    {
        //        string valor = Valor.ToString();
        //        if (valor.Contains(".") || valor.Contains(","))
        //        {
        //            return false;
        //        }
        //    }

        //    return false;
        //}


    }
}


