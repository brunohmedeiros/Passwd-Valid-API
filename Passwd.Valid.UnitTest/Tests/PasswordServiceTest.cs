using Passwd.Valid.Domain.Interfaces;
using Passwd.Valid.UnitTest.Fixture;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Passwd.Valid.UnitTest.Tests
{
    public class PasswordServiceTest : IClassFixture<UnitTestFixture>
    {
        private IPasswordService _passwordService;

        public PasswordServiceTest(UnitTestFixture fixture)
        {
            _passwordService = fixture.ServiceProvider.GetRequiredService<IPasswordService>();
        }

        [Fact]
        public void SenhaCorreta_Valida_RetornarSucesso()
        {
            // Act
            var senhaValida = _passwordService.IsValid("AbTp9!fok");

            // Assert
            Assert.True(senhaValida);
        }

        [Fact]
        public void SenhaVazia_Invalida_RetornarErro()
        {   
            // Act
            var senhaValida = _passwordService.IsValid("");

            // Assert
            Assert.False(senhaValida);
        }

        [Fact]
        public void SenhaPequenalenght2_Invalida_RetornarErro()
        {
            // Act
            var senhaValida = _passwordService.IsValid("aa");

            // Assert
            Assert.False(senhaValida);
        }

        [Fact]
        public void SenhaPequenalenght8_Invalida_RetornarErro()
        {
            // Act
            var senhaValida = _passwordService.IsValid("Ab9tv-Cc");

            // Assert
            Assert.False(senhaValida);
        }

        [Fact]
        public void SenhaCaracterRepetido_Invalida_RetornarErro()
        {
            // Act
            var senhaValida = _passwordService.IsValid("AbTp9!foo");

            // Assert
            Assert.False(senhaValida);
        }

        [Fact]
        public void SenhaCaracterRepetido2_Invalida_RetornarErro()
        {
            // Act
            var senhaValida = _passwordService.IsValid("AbTp9!foA");

            // Assert
            Assert.False(senhaValida);
        }

        [Fact]
        public void SenhaComEspaco_Invalida_RetornarErro()
        {
            // Act
            var senhaValida = _passwordService.IsValid("AbTp9 fok");

            // Assert
            Assert.False(senhaValida);
        }

        [Fact]
        public void SenhaGrande_Valida_RetornarSucesso()
        {
            // Act
            var senhaValida = _passwordService.IsValid("z%uKyDi)+(^wp!AJ@8x&*eqr9-hEfc#");

            // Assert
            Assert.True(senhaValida);
        }

        [Fact]
        public void SenhaAcentosPtBr_Valida_RetornarSucesso()
        {
            // Act
            var senhaValida = _passwordService.IsValid("AbTp9!fok…Õ”˙È«Á-C#");

            // Assert
            Assert.True(senhaValida);
        }
    }
}
