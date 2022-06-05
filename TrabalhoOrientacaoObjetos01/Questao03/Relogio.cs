using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    // Guilherme Dzesigaleski Mueller
    // Participação especial Amanda Bauler
    public class Relogio
    {
        public DateTime Hora;

        public string ObterHoraPorExtenso()
        {
            int hora = Hora.Hour;

            if (hora == 0)
            {
                return "Meia noite";
            }
            else if (hora == 1)
            {
                return "Uma hora";
            }

            else if (hora == 2)
            {
                return "Duas horas";
            }

            else if (hora == 3)
            {
                return "Três horas";
            }

            else if (hora == 4)
            {
                return "Quatro horas";
            }

            else if (hora == 5)
            {
                return "Cinco horas";
            }

            else if (hora == 6)
            {
                return "Seis horas";
            }

            else if (hora == 7)
            {
                return "Sete horas";
            }

            else if (hora == 8)
            {
                return "Oito horas";
            }

            else if (hora == 9)
            {
                return "Nove horas";
            }

            else if (hora > 9 && hora < 20)
            {
                var horaTexto = Convert.ToString(hora);
                if (Convert.ToString(horaTexto[1]) == "0")
                {
                    return "Dez horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "1")
                {
                    return "Onze horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "2")
                {
                    return "Doze horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "3")
                {
                    return "Treze horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "4")
                {
                    return "Quatorze horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "5")
                {
                    return "Quinze horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "6")
                {
                    return "Dezesseis horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "7")
                {
                    return "Dezessete horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "8")
                {
                    return "Dezoito horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "9")
                {
                    return "Dezenove horas";
                }
            }

            else if (hora < 24)
            {
                var horaTexto = Convert.ToString(hora);
                if (Convert.ToString(horaTexto[1]) == "0")
                {
                    return "Vinte horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "1")
                {
                    return "Vinte e uma horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "2")
                {
                    return "Vinte e duas horas";
                }
                else if (Convert.ToString(horaTexto[1]) == "3")
                {
                    return "Vinte e três horas";
                }

            }
            return "";
        }
        public string ObterMinutoPorExtenso()
        {
            var minuto = Hora.Minute;
            if (minuto == 0)
            {
                return "";
            }
            else if (minuto == 1)
            {
                return "um minuto";
            }

            else if (minuto == 2)
            {
                return "dois minutos";
            }

            else if (minuto == 3)
            {
                return "três minutos";
            }

            else if (minuto == 4)
            {
                return "quatro minutos";
            }

            else if (minuto == 5)
            {
                return "cinco minutos";
            }

            else if (minuto == 6)
            {
                return "seis minutos";
            }

            else if (minuto == 7)
            {
                return "sete minutos";
            }

            else if (minuto == 8)
            {
                return "oito minutos";
            }

            else if (minuto == 9)
            {
                return "nove minutos";
            }
            else if (minuto < 20)
            {
                var minutoTexto = Convert.ToString(minuto);
                if (Convert.ToString(minutoTexto[1]) == "0")
                {
                    return "dez minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "1")
                {
                    return "onze minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "2")
                {
                    return "doze minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "3")
                {
                    return "treze minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "4")
                {
                    return "quatorze minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "5")
                {
                    return "quinze minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "6")
                {
                    return "dezesseis minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "7")
                {
                    return "dezessete minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "8")
                {
                    return "dezoito minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "9")
                {
                    return "dezenove minutos";
                }

            }

            else if (minuto < 30)
            {
                var minutoTexto = Convert.ToString(minuto);
                if (Convert.ToString(minutoTexto[1]) == "0")
                {
                    return "vinte minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "1")
                {
                    return "vinte e um minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "2")
                {
                    return "vinte e dois minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "3")
                {
                    return "vinte e três minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "4")
                {
                    return "vinte e quatro minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "5")
                {
                    return "vinte e cinco minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "6")
                {
                    return "vinte e seis minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "7")
                {
                    return "vinte e sete minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "8")
                {
                    return "vinte e oito minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "9")
                {
                    return "vinte e nove minutos";
                }

            }

            else if (minuto < 40)
            {
                var minutoTexto = Convert.ToString(minuto);
                if (Convert.ToString(minutoTexto[1]) == "0")
                {
                    return "trinta minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "1")
                {
                    return "trinta e um minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "2")
                {
                    return "trinta e dois minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "3")
                {
                    return "trinta e três minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "4")
                {
                    return "trinta e quatro minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "5")
                {
                    return "trinta e cinco minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "6")
                {
                    return "trinta e seis minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "7")
                {
                    return "trinta e sete minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "8")
                {
                    return "trinta e oito minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "9")
                {
                    return "trinta e nove minutos";
                }
            }

            else if (minuto < 50)
            {
                var minutoTexto = Convert.ToString(minuto);
                if (Convert.ToString(minutoTexto[1]) == "0")
                {
                    return "quarenta minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "1")
                {
                    return "quarenta e um minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "2")
                {
                    return "quarenta e dois minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "3")
                {
                    return "quarenta e três minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "4")
                {
                    return "quarenta e quatro minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "5")
                {
                    return "quarenta e cinco minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "6")
                {
                    return "quarenta e seis minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "7")
                {
                    return "quarenta e sete minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "8")
                {
                    return "quarenta e oito minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "9")
                {
                    return "quarenta e nove minutos";
                }

            }
            else if (minuto < 60)
            {
                var minutoTexto = Convert.ToString(minuto);
                if (Convert.ToString(minutoTexto[1]) == "0")
                {
                    return "cinquenta minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "1")
                {
                    return "cinquenta e um minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "2")
                {
                    return "cinquenta e dois minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "3")
                {
                    return "cinquenta e três minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "4")
                {
                    return "cinquenta e quatro minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "5")
                {
                    return "cinquenta e cinco minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "6")
                {
                    return "cinquenta e seis minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "7")
                {
                    return "cinquenta e sete minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "8")
                {
                    return "cinquenta e oito minutos";
                }
                else if (Convert.ToString(minutoTexto[1]) == "9")
                {
                    return "cinquenta e nove minutos";
                }
            }
            return "";
        }
        public string ObterSegundoPorExtenso()
        {
            var segundos = Hora.Second;
            if (segundos == 0)
            {
                return "";
            }
            else if (segundos == 1)
            {
                return "um segundo";
            }

            else if (segundos == 2)
            {
                return "dois segundos";
            }

            else if (segundos == 3)
            {
                return "três segundos";
            }

            else if (segundos == 4)
            {
                return "quatro segundos";
            }

            else if (segundos == 5)
            {
                return "cinco segundos";
            }

            else if (segundos == 6)
            {
                return "seis segundos";
            }

            else if (segundos == 7)
            {
                return "sete segundos";
            }

            else if (segundos == 8)
            {
                return "oito segundos";
            }

            else if (segundos == 9)
            {
                return "nove segundos";
            }
            else if (segundos < 20)
            {
                var segundosTexto = Convert.ToString(segundos);
                if (Convert.ToString(segundosTexto[1]) == "0")
                {
                    return "dez segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "1")
                {
                    return "onze segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "2")
                {
                    return "doze segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "3")
                {
                    return "treze segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "4")
                {
                    return "quatorze segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "5")
                {
                    return "quinze segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "6")
                {
                    return "dezesseis segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "7")
                {
                    return "dezessete segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "8")
                {
                    return "dezoito segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "9")
                {
                    return "dezenove segundos";
                }

            }

            else if (segundos < 30)
            {
                var segundosTexto = Convert.ToString(segundos);
                if (Convert.ToString(segundosTexto[1]) == "0")
                {
                    return "vinte segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "1")
                {
                    return "vinte e um segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "2")
                {
                    return "vinte e dois segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "3")
                {
                    return "vinte e três segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "4")
                {
                    return "vinte e quatro segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "5")
                {
                    return "vinte e cinco segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "6")
                {
                    return "vinte e seis segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "7")
                {
                    return "vinte e sete segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "8")
                {
                    return "vinte e oito segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "9")
                {
                    return "vinte e nove segundos";
                }

            }

            else if (segundos < 40)
            {
                var segundosTexto = Convert.ToString(segundos);
                if (Convert.ToString(segundosTexto[1]) == "0")
                {
                    return "trinta segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "1")
                {
                    return "trinta e um segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "2")
                {
                    return "trinta e dois segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "3")
                {
                    return "trinta e três segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "4")
                {
                    return "trinta e quatro segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "5")
                {
                    return "trinta e cinco segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "6")
                {
                    return "trinta e seis segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "7")
                {
                    return "trinta e sete segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "8")
                {
                    return "trinta e oito segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "9")
                {
                    return "trinta e nove segundos";
                }
            }

            else if (segundos < 50)
            {
                var segundosTexto = Convert.ToString(segundos);
                if (Convert.ToString(segundosTexto[1]) == "0")
                {
                    return "quarenta segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "1")
                {
                    return "quarenta e um segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "2")
                {
                    return "quarenta e dois segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "3")
                {
                    return "quarenta e três segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "4")
                {
                    return "quarenta e quatro segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "5")
                {
                    return "quarenta e cinco segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "6")
                {
                    return "quarenta e seis segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "7")
                {
                    return "quarenta e sete segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "8")
                {
                    return "quarenta e oito segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "9")
                {
                    return "quarenta e nove segundos";
                }

            }
            else if (segundos < 60)
            {
                var segundosTexto = Convert.ToString(segundos);
                if (Convert.ToString(segundosTexto[1]) == "0")
                {
                    return "cinquenta segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "1")
                {
                    return "cinquenta e um segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "2")
                {
                    return "cinquenta e dois segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "3")
                {
                    return "cinquenta e três segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "4")
                {
                    return "cinquenta e quatro segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "5")
                {
                    return "cinquenta e cinco segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "6")
                {
                    return "cinquenta e seis segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "7")
                {
                    return "cinquenta e sete segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "8")
                {
                    return "cinquenta e oito segundos";
                }
                else if (Convert.ToString(segundosTexto[1]) == "9")
                {
                    return "cinquenta e nove segundos";
                }
            }
            return "";
        }
        public string ApresentarHoraPorExtenso()
        {
            if(ObterMinutoPorExtenso() == "" && ObterSegundoPorExtenso() == "")
            {
                return ObterHoraPorExtenso();
            }
            else if (ObterMinutoPorExtenso() == "" && ObterSegundoPorExtenso() != "")
            {
                return ObterHoraPorExtenso() + " e " + ObterSegundoPorExtenso();
            }
            else if (ObterMinutoPorExtenso() != "" && ObterSegundoPorExtenso() == "")
            {
                return ObterHoraPorExtenso() + " e " + ObterMinutoPorExtenso();
            }
            else
            {
                return ObterHoraPorExtenso() + " " + ObterMinutoPorExtenso() + " e " + ObterSegundoPorExtenso();
            }
            
        }
    }
}