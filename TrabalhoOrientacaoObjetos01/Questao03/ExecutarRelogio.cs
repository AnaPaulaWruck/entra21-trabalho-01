using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExecutarRelogio
    {
        public void Executar()
        { 
            DateTime relogio = DateTime.Parse("19:37:47");
            relogio.ToString("19:37:47");
            Console.Write(relogio);
        }
    }
}