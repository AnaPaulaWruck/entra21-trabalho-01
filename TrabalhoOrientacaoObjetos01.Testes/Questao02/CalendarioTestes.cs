using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao02;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Testes.Questao02
{
    public class CalendarioTestes
    {
        [Theory]
        [InlineData(1, "janeiro")]
        [InlineData(2, "fevereiro")]
        [InlineData(3, "março")]
        [InlineData(4, "abril")]
        [InlineData(5, "maio")]
        [InlineData(6, "junho")]
        [InlineData(7, "julho")]
        [InlineData(8, "agosto")]
        [InlineData(9, "setembro")]
        [InlineData(10, "outubro")]
        [InlineData(11, "novembro")]
        [InlineData(12, "dezembro")]

        public void Validar_ObterMesPorExtenso(int mesTeste, string nomeEsperado)
        {

            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(2022, mesTeste, 5);

            //Act
            var mesTesteExtenso = calendario.ObterMesPorExtenso();

            //Assert
            mesTesteExtenso.Should().Be(nomeEsperado);

        }

        [Theory]
        [InlineData(1, "Primeiro")]
        [InlineData(2, "Dois")]
        [InlineData(3, "Três")]
        [InlineData(4, "Quatro")]
        [InlineData(5, "Cinco")]
        [InlineData(6, "Seis")]
        [InlineData(7, "Sete")]
        [InlineData(8, "Oito")]
        [InlineData(9, "Nove")]
        [InlineData(10, "Dez")]
        [InlineData(11, "Onze")]
        [InlineData(12, "Doze")]
        [InlineData(13, "Treze")]
        [InlineData(14, "Quatorze")]
        [InlineData(15, "Quinze")]
        [InlineData(16, "Dezesseis")]
        [InlineData(17, "Dezessete")]
        [InlineData(18, "Dezoito")]
        [InlineData(19, "Dezenove")]
        [InlineData(20, "Vinte")]
        [InlineData(21, "Vinte e um")]
        [InlineData(22, "Vinte e dois")]
        [InlineData(23, "Vinte e três")]
        [InlineData(24, "Vinte e quatro")]
        [InlineData(25, "Vinte e cinco")]
        [InlineData(26, "Vinte e seis")]
        [InlineData(27, "Vinte e sete")]
        [InlineData(28, "Vinte e oito")]
        [InlineData(29, "Vinte e nove")]
        [InlineData(30, "Trinta")]
        [InlineData(31, "Trinta e um")]

        public void Validar_ObterDiaPorExtenso(int diaTeste, string nomeEsperado)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(2022, 5, diaTeste);

            //Act
            var diaTesteExtenso = calendario.ObterDiaPorExtenso();

            //Assert
            diaTesteExtenso.Should().Be(nomeEsperado);
        }

        [Theory]
        [InlineData(1970, "mil novecentos e setenta")]
        [InlineData(1971, "mil novecentos e setenta e um")]
        [InlineData(1972, "mil novecentos e setenta e dois")]
        [InlineData(1973, "mil novecentos e setenta e três")]
        [InlineData(1974, "mil novecentos e setenta e quatro")]
        [InlineData(1975, "mil novecentos e setenta e cinco")]
        [InlineData(1976, "mil novecentos e setenta e seis")]
        [InlineData(1977, "mil novecentos e setenta e sete")]
        [InlineData(1978, "mil novecentos e setenta e oito")]
        [InlineData(1979, "mil novecentos e setenta e nove")]
        [InlineData(1980, "mil novecentos e oitenta")]
        [InlineData(1981, "mil novecentos e oitenta e um")]
        [InlineData(1982, "mil novecentos e oitenta e dois")]
        [InlineData(1983, "mil novecentos e oitenta e três")]
        [InlineData(1984, "mil novecentos e oitenta e quatro")]
        [InlineData(1985, "mil novecentos e oitenta e cinco")]
        [InlineData(1986, "mil novecentos e oitenta e seis")]
        [InlineData(1987, "mil novecentos e oitenta e sete")]
        [InlineData(1988, "mil novecentos e oitenta e oito")]
        [InlineData(1989, "mil novecentos e oitenta e nove")]
        [InlineData(1990, "mil novecentos e noventa")]
        [InlineData(1991, "mil novecentos e noventa e um")]
        [InlineData(1992, "mil novecentos e noventa e dois")]
        [InlineData(1993, "mil novecentos e noventa e três")]
        [InlineData(1994, "mil novecentos e noventa e quatro")]
        [InlineData(1995, "mil novecentos e noventa e cinco")]
        [InlineData(1996, "mil novecentos e noventa e seis")]
        [InlineData(1997, "mil novecentos e noventa e sete")]
        [InlineData(1998, "mil novecentos e noventa e oito")]
        [InlineData(1999, "mil novecentos e noventa e nove")]
        [InlineData(2000, "dois mil")]
        [InlineData(2001, "dois mil e um")]
        [InlineData(2002, "dois mil e dois")]
        [InlineData(2003, "dois mil e três")]
        [InlineData(2004, "dois mil e quatro")]
        [InlineData(2005, "dois mil e cinco")]
        [InlineData(2006, "dois mil e seis")]
        [InlineData(2007, "dois mil e sete")]
        [InlineData(2008, "dois mil e oito")]
        [InlineData(2009, "dois mil e nove")]
        [InlineData(2010, "dois mil e dez")]
        [InlineData(2011, "dois mil e onze")]
        [InlineData(2012, "dois mil e doze")]
        [InlineData(2013, "dois mil e treze")]
        [InlineData(2014, "dois mil e quatorze")]
        [InlineData(2015, "dois mil e quinze")]
        [InlineData(2016, "dois mil e dezesseis")]
        [InlineData(2017, "dois mil e dezessete")]
        [InlineData(2018, "dois mil e dezoito")]
        [InlineData(2019, "dois mil e dezenove")]
        [InlineData(2020, "dois mil e vinte")]
        [InlineData(2021, "dois mil e vinte e um")]
        [InlineData(2022, "dois mil e vinte e dois")]
        [InlineData(2023, "dois mil e vinte e três")]
        [InlineData(2024, "dois mil e vinte e quatro")]
        [InlineData(2025, "dois mil e vinte e cinco")]
        [InlineData(2026, "dois mil e vinte e seis")]
        [InlineData(2027, "dois mil e vinte e sete")]
        [InlineData(2028, "dois mil e vinte e oito")]
        [InlineData(2029, "dois mil e vinte e nove")]
        [InlineData(2030, "dois mil e trinta")]

        public void Validar_ObterAnoPorExtenso(int anoTeste, string nomeEsperado)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(anoTeste, 5, 24);

            //Act
            var anoTesteExtenso = calendario.ObterAnoPorExtenso();

            //Assert
            anoTesteExtenso.Should().Be(nomeEsperado);
        }

        [Theory]
        [InlineData("1997-1-6", "Seis de janeiro de mil novecentos e noventa e sete")]
        [InlineData("2022-2-2", "Dois de fevereiro de dois mil e vinte e dois")]
        [InlineData("1999-3-30", "Trinta de março de mil novecentos e noventa e nove")]
        [InlineData("2000-4-1", "Primeiro de abril de dois mil")]
        [InlineData("2010-5-8", "Oito de maio de dois mil e dez")]
        [InlineData("1982-6-26", "Vinte e seis de junho de mil novecentos e oitenta e dois")]
        [InlineData("1972-7-17", "Dezessete de julho de mil novecentos e setenta e dois")]
        [InlineData("2015-8-15", "Quinze de agosto de dois mil e quinze")]
        [InlineData("2018-9-13", "Treze de setembro de dois mil e dezoito")]
        [InlineData("1971-10-11", "Onze de outubro de mil novecentos e setenta e um")]
        [InlineData("2030-11-14", "Quatorze de novembro de dois mil e trinta")]
        [InlineData("2005-12-25", "Vinte e cinco de dezembro de dois mil e cinco")]
        public void Validar_ObterDataCompletaPorExtenso(string dataTeste, string dataEsperada)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = DateTime.Parse(dataTeste);

            //Act
            var dataTesteExtenso = calendario.ObterDataCompletaPorExtenso();

            //Assert
            dataTesteExtenso.Should().Be(dataEsperada);
        }
    }
}
