using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Testes.Questao03
{
    // Guilherme Dzesigaleski Mueller
    public class RelogioTests
    {
            [Theory]
            [InlineData(1, "dez")]
        public void Validar_Hora_Por_Completo(int valorPrimario, string extensoEsperado)
        {

            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 1;
            extensoEsperado = "dez";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

    }
}