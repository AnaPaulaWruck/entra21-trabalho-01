using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao03;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Testes.Questao03
{
    // Guilherme Dzesigaleski Mueller
    // Participação especial Amanda Bauler.
    public class RelogioTests
    {
        [Theory]
        [InlineData(0, "Meia noite")]
        [InlineData(1, "Uma hora")]
        [InlineData(2, "Duas horas")]
        [InlineData(3, "Três horas")]
        [InlineData(4, "Quatro horas")]
        [InlineData(5, "Cinco horas")]
        [InlineData(6, "Seis horas")]
        [InlineData(7, "Sete horas")]
        [InlineData(8, "Oito horas")]
        [InlineData(9, "Nove horas")]
        [InlineData(10, "Dez horas")]
        [InlineData(11, "Onze horas")]
        [InlineData(12, "Doze horas")]
        [InlineData(13, "Treze horas")]
        [InlineData(14, "Quatorze horas")]
        [InlineData(15, "Quinze horas")]
        [InlineData(16, "Dezesseis horas")]
        [InlineData(17, "Dezessete horas")]
        [InlineData(18, "Dezoito horas")]
        [InlineData(19, "Dezenove horas")]
        [InlineData(20, "Vinte horas")]
        [InlineData(21, "Vinte e uma horas")]
        [InlineData(22, "Vinte e duas horas")]
        [InlineData(23, "Vinte e três horas")]

        public void Validar_ObterHoraPorExtenso(int horaNumero, string horaExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = new DateTime(2022, 5, 12, horaNumero, 12, 58);

            //Act
            var horaExtensoTeste = relogio.ObterHoraPorExtenso();

            //Assert
            horaExtensoTeste.Should().Be(horaExtenso);
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "um minuto")]
        [InlineData(2, "dois minutos")]
        [InlineData(3, "três minutos")]
        [InlineData(4, "quatro minutos")]
        [InlineData(5, "cinco minutos")]
        [InlineData(6, "seis minutos")]
        [InlineData(7, "sete minutos")]
        [InlineData(8, "oito minutos")]
        [InlineData(9, "nove minutos")]
        [InlineData(10, "dez minutos")]
        [InlineData(11, "onze minutos")]
        [InlineData(12, "doze minutos")]
        [InlineData(13, "treze minutos")]
        [InlineData(14, "quatorze minutos")]
        [InlineData(15, "quinze minutos")]
        [InlineData(16, "dezesseis minutos")]
        [InlineData(17, "dezessete minutos")]
        [InlineData(18, "dezoito minutos")]
        [InlineData(19, "dezenove minutos")]
        [InlineData(20, "vinte minutos")]
        [InlineData(21, "vinte e um minutos")]
        [InlineData(22, "vinte e dois minutos")]
        [InlineData(23, "vinte e três minutos")]
        [InlineData(24, "vinte e quatro minutos")]
        [InlineData(25, "vinte e cinco minutos")]
        [InlineData(26, "vinte e seis minutos")]
        [InlineData(27, "vinte e sete minutos")]
        [InlineData(28, "vinte e oito minutos")]
        [InlineData(29, "vinte e nove minutos")]
        [InlineData(30, "trinta minutos")]
        [InlineData(31, "trinta e um minutos")]
        [InlineData(32, "trinta e dois minutos")]
        [InlineData(33, "trinta e três minutos")]
        [InlineData(34, "trinta e quatro minutos")]
        [InlineData(35, "trinta e cinco minutos")]
        [InlineData(36, "trinta e seis minutos")]
        [InlineData(37, "trinta e sete minutos")]
        [InlineData(38, "trinta e oito minutos")]
        [InlineData(39, "trinta e nove minutos")]
        [InlineData(40, "quarenta minutos")]
        [InlineData(41, "quarenta e um minutos")]
        [InlineData(42, "quarenta e dois minutos")]
        [InlineData(43, "quarenta e três minutos")]
        [InlineData(44, "quarenta e quatro minutos")]
        [InlineData(45, "quarenta e cinco minutos")]
        [InlineData(46, "quarenta e seis minutos")]
        [InlineData(47, "quarenta e sete minutos")]
        [InlineData(48, "quarenta e oito minutos")]
        [InlineData(49, "quarenta e nove minutos")]
        [InlineData(50, "cinquenta minutos")]
        [InlineData(51, "cinquenta e um minutos")]
        [InlineData(52, "cinquenta e dois minutos")]
        [InlineData(53, "cinquenta e três minutos")]
        [InlineData(54, "cinquenta e quatro minutos")]
        [InlineData(55, "cinquenta e cinco minutos")]
        [InlineData(56, "cinquenta e seis minutos")]
        [InlineData(57, "cinquenta e sete minutos")]
        [InlineData(58, "cinquenta e oito minutos")]
        [InlineData(59, "cinquenta e nove minutos")]
        
        public void Validar_ObterMinutoPorExtenso(int minutoNumero, string minutoExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = new DateTime(2022, 5, 12, 20, minutoNumero, 58);

            //Act
            var minutoExtensoTeste = relogio.ObterMinutoPorExtenso();

            //Assert
            minutoExtensoTeste.Should().Be(minutoExtenso);
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "um segundo")]
        [InlineData(2, "dois segundos")]
        [InlineData(3, "três segundos")]
        [InlineData(4, "quatro segundos")]
        [InlineData(5, "cinco segundos")]
        [InlineData(6, "seis segundos")]
        [InlineData(7, "sete segundos")]
        [InlineData(8, "oito segundos")]
        [InlineData(9, "nove segundos")]
        [InlineData(10, "dez segundos")]
        [InlineData(11, "onze segundos")]
        [InlineData(12, "doze segundos")]
        [InlineData(13, "treze segundos")]
        [InlineData(14, "quatorze segundos")]
        [InlineData(15, "quinze segundos")]
        [InlineData(16, "dezesseis segundos")]
        [InlineData(17, "dezessete segundos")]
        [InlineData(18, "dezoito segundos")]
        [InlineData(19, "dezenove segundos")]
        [InlineData(20, "vinte segundos")]
        [InlineData(21, "vinte e um segundos")]
        [InlineData(22, "vinte e dois segundos")]
        [InlineData(23, "vinte e três segundos")]
        [InlineData(24, "vinte e quatro segundos")]
        [InlineData(25, "vinte e cinco segundos")]
        [InlineData(26, "vinte e seis segundos")]
        [InlineData(27, "vinte e sete segundos")]
        [InlineData(28, "vinte e oito segundos")]
        [InlineData(29, "vinte e nove segundos")]
        [InlineData(30, "trinta segundos")]
        [InlineData(31, "trinta e um segundos")]
        [InlineData(32, "trinta e dois segundos")]
        [InlineData(33, "trinta e três segundos")]
        [InlineData(34, "trinta e quatro segundos")]
        [InlineData(35, "trinta e cinco segundos")]
        [InlineData(36, "trinta e seis segundos")]
        [InlineData(37, "trinta e sete segundos")]
        [InlineData(38, "trinta e oito segundos")]
        [InlineData(39, "trinta e nove segundos")]
        [InlineData(40, "quarenta segundos")]
        [InlineData(41, "quarenta e um segundos")]
        [InlineData(42, "quarenta e dois segundos")]
        [InlineData(43, "quarenta e três segundos")]
        [InlineData(44, "quarenta e quatro segundos")]
        [InlineData(45, "quarenta e cinco segundos")]
        [InlineData(46, "quarenta e seis segundos")]
        [InlineData(47, "quarenta e sete segundos")]
        [InlineData(48, "quarenta e oito segundos")]
        [InlineData(49, "quarenta e nove segundos")]
        [InlineData(50, "cinquenta segundos")]
        [InlineData(51, "cinquenta e um segundos")]
        [InlineData(52, "cinquenta e dois segundos")]
        [InlineData(53, "cinquenta e três segundos")]
        [InlineData(54, "cinquenta e quatro segundos")]
        [InlineData(55, "cinquenta e cinco segundos")]
        [InlineData(56, "cinquenta e seis segundos")]
        [InlineData(57, "cinquenta e sete segundos")]
        [InlineData(58, "cinquenta e oito segundos")]
        [InlineData(59, "cinquenta e nove segundos")]

        public void Validar_ObterSegundoPorExtenso(int segundoNumero, string segundoExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = new DateTime(2022, 5, 12, 20, 33, segundoNumero);

            //Act
            var segundoExtensoTeste = relogio.ObterSegundoPorExtenso();

            //Assert
            segundoExtensoTeste.Should().Be(segundoExtenso);
        }

        [Theory]
        [InlineData("2001-10-10 12:12:12", "Doze horas doze minutos e doze segundos")]
        [InlineData("2020-12-23 11:23:55", "Onze horas vinte e três minutos e cinquenta e cinco segundos")]
        [InlineData("1997-03-30 23:15:57", "Vinte e três horas quinze minutos e cinquenta e sete segundos")]
        [InlineData("1971-07-17 10:30:59", "Dez horas trinta minutos e cinquenta e nove segundos")]
        [InlineData("2008-11-25 08:55:15", "Oito horas cinquenta e cinco minutos e quinze segundos")]
        [InlineData("2010-01-16 06:45:40", "Seis horas quarenta e cinco minutos e quarenta segundos")]
        [InlineData("2018-02-19 09:56:12", "Nove horas cinquenta e seis minutos e doze segundos")]
        [InlineData("2005-04-10 16:45:11", "Dezesseis horas quarenta e cinco minutos e onze segundos")]
        [InlineData("2002-02-12 14:12:36", "Quatorze horas doze minutos e trinta e seis segundos")]
        [InlineData("2001-05-14 00:00:14", "Meia noite e quatorze segundos")]

        public void Validar_ApresentarHoraPorExtenso(string horarioTeste, string horarioExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = DateTime.Parse(horarioTeste);

            //Act
            var horarioTesteExtenso = relogio.ApresentarHoraPorExtenso();

            //Assert
            horarioTesteExtenso.Should().Be(horarioExtenso);
        }

    }
}