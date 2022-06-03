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
    }
}
