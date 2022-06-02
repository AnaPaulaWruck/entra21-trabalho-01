using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExecutarCalendario
    {
        public void Executar()
        {
            var calendario = new Calendario();
            calendario.Data = DateTime.Parse("1997/01/06");

            Console.WriteLine(calendario.ObterDataCompletaPorExtenso());
        }
    }
}
//Remover "de" dos dias do metodo ObterDiaPorExtenso.