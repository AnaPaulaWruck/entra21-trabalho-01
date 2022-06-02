using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class ExemploRelogio
    {
        public void Executar()
        {
            var relogio = new Relogio();
            Console.WriteLine("Informe a hora atual: ");
            relogio.Hora = Console.ReadLine();
            relogio.Minuto = Console.ReadLine();
            relogio.Segundo = Console.ReadLine();
            //relogio.Dezena = Hora.Substring(2, 1);
            //relogio.Unidade = Hora.Substring(3, 1);

        }
    }
}