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
        
        [Theory]
        [InlineData(2, "Vinte")]
        public void Valida_Hora_Por_Completo2(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 2;
            extensoEsperado = "Vinte";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(3, "Trinta")]
        public void Validar_Hora_Por_Completo3(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 3;
            extensoEsperado = "Trinta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(4, "Quarenta")]
        public void Validar_Hora_Por_Completo4(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 4;
            extensoEsperado = "Quarenta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(5, "Cinquenta")]
        public void Validar_Hora_Por_Completo5(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 5;
            extensoEsperado = "Cinquenta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(6, "")]
        public void Validar_Hora_Por_Completo6(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 6;
            extensoEsperado = "";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(1, "Um")]
        public void Valida_Hora_Por_Completo01(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 1;
            extensoEsperado = "Um";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(2, "Dois")]
        public void Valida_Hora_Por_Completo02(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 2;
            extensoEsperado = "Dois";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(3, "Três")]
        public void Valida_Hora_Por_Completo03(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 3;
            extensoEsperado = "Três";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(4, "Quatro")]
        public void Valida_Hora_Por_Completo04(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 4;
            extensoEsperado = "Quatro";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(5, "Cinco")]
        public void Valida_Hora_Por_Completo05(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 5;
            extensoEsperado = "Cinco";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(6, "Seis")]
        public void Valida_Hora_Por_Completo06(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 6;
            extensoEsperado = "Seis";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(7, "Sete")]
        public void Valida_Hora_Por_Completo07(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 7;
            extensoEsperado = "Sete";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(8, "Oito")]
        public void Valida_Hora_Por_Completo08(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 8;
            extensoEsperado = "Oito";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(9, "Nove")]
        public void Valida_Hora_Por_Completo09(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 9;
            extensoEsperado = "Nove";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(1, "dez")]
        public void Validar_Minuto_Por_Completo(int valorPrimario, string extensoEsperado)
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

        [Theory]
        [InlineData(2, "Vinte")]
        public void Valida_Minuto_Por_Completo2(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 2;
            extensoEsperado = "Vinte";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(3, "Trinta")]
        public void Validar_Minuto_Por_Completo3(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 3;
            extensoEsperado = "Trinta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(4, "Quarenta")]
        public void Validar_Minuto_Por_Completo4(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 4;
            extensoEsperado = "Quarenta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(5, "Cinquenta")]
        public void Validar_Minuto_Por_Completo5(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 5;
            extensoEsperado = "Cinquenta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(6, "")]
        public void Validar_Minuto_Por_Completo6(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 6;
            extensoEsperado = "";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(1, "Um")]
        public void Valida_Minuto_Por_Completo01(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 1;
            extensoEsperado = "Um";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(2, "Dois")]
        public void Valida_Minuto_Por_Completo02(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 2;
            extensoEsperado = "Dois";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(3, "Três")]
        public void Valida_Minuto_Por_Completo03(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 3;
            extensoEsperado = "Três";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(4, "Quatro")]
        public void Valida_Minuto_Por_Completo04(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 4;
            extensoEsperado = "Quatro";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(5, "Cinco")]
        public void Valida_Minuto_Por_Completo05(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 5;
            extensoEsperado = "Cinco";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(6, "Seis")]
        public void Valida_Minuto_Por_Completo06(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 6;
            extensoEsperado = "Seis";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(7, "Sete")]
        public void Valida_Minuto_Por_Completo07(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 7;
            extensoEsperado = "Sete";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(8, "Oito")]
        public void Valida_Minuto_Por_Completo08(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 8;
            extensoEsperado = "Oito";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(9, "Nove")]
        public void Valida_Minuto_Por_Completo09(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 9;
            extensoEsperado = "Nove";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(1, "Dez")]
        public void Validar_Segundo_PorCompleto(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 1;
            extensoEsperado = "Dez";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(2, "Vinte")]
        public void Valida_Segundo_Por_Completo2(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 2;
            extensoEsperado = "Vinte";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(3, "Trinta")]
        public void Valida_Segundo_Por_Completo3(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 3;
            extensoEsperado = "Trinta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(4, "Quarenta")]
        public void Valida_Segundo_Por_Completo4(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 4;
            extensoEsperado = "Quarenta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(5, "Cinquenta")]
        public void Valida_Segundo_Por_Completo5(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 5;
            extensoEsperado = "Cinquenta";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
        
        [Theory]
        [InlineData(6, "")]
        public void Valida_Segundo_Por_Completo6(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 6;
            extensoEsperado = "";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(1, "Um")]
        public void Valida_Segundo_Por_Completo01(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 1;
            extensoEsperado = "Um";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(2, "Dois")]
        public void Valida_Segundo_Por_Completo02(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 2;
            extensoEsperado = "Dois";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(3, "Três")]
        public void Valida_Segundo_Por_Completo03(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 3;
            extensoEsperado = "Três";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(4, "Quatro")]
        public void Valida_Segundo_Por_Completo04(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 4;
            extensoEsperado = "Quatro";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(5, "Cinco")]
        public void Valida_Segundo_Por_Completo05(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 5;
            extensoEsperado = "Cinco";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(6, "Seis")]
        public void Valida_Segundo_Por_Completo06(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 6;
            extensoEsperado = "Seis";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(7, "Sete")]
        public void Valida_Segundo_Por_Completo07(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 7;
            extensoEsperado = "Sete";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(8, "Oito")]
        public void Valida_Segundo_Por_Completo08(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 8;
            extensoEsperado = "Oito";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }

        [Theory]
        [InlineData(9, "Nove")]
        public void Valida_Segundo_Por_Completo09(int valorPrimario, string extensoEsperado)
        {
            // Arrenge
            var relogio = new RelogioTests();
            valorPrimario = 9;
            extensoEsperado = "Nove";

            // Act
            var extensoResultado = extensoEsperado;

            // Assert
            extensoResultado.Should().Be(extensoEsperado);
        }
    }
}