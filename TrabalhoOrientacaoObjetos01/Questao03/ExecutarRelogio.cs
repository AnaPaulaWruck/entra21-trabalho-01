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
            var relogio = new Relogio();
            Console.WriteLine("Informe a hora atual: ");
            relogio.Hora = Console.ReadLine();
            relogio.Minuto = Console.ReadLine();
            relogio.Segundo = Console.ReadLine();
            relogio.Dezena = relogio.Hora.Substring(2, 1);
            relogio.Unidade = relogio.Hora.Substring(3, 1);
            relogio.Dezena = relogio.Minuto.Substring(4, 1);
            relogio.Unidade = relogio.Minuto.Substring(5, 1);
            relogio.Dezena = relogio.Segundo.Substring(6, 1);


        }
    }
}