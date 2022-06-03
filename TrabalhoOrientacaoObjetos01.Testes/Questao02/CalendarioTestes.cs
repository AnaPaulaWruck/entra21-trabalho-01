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


    }
}
