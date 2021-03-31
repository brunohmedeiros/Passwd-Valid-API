using Passwd.Valid.IntegrationTest.Fixture;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace Passwd.Valid.IntegrationTest.Tests
{
    [Collection(nameof(IntegrationTestFixtureCollection))]
    public class PasswordControllerTest
    {
        private readonly IntegrationTestFixture<StartupIntegrationTest> _integrationTest;

        public PasswordControllerTest(IntegrationTestFixture<StartupIntegrationTest> integrationTest)
        {
            _integrationTest = integrationTest;
        }

        [Theory]
        [InlineData("aa")]
        [InlineData("ab")]
        [InlineData("AAAbbbCc")]
        [InlineData("AbTp9!foo")]
        [InlineData("AbTp9!foA")]
        [InlineData("AbTp9 fok")]
        public async Task SenhaInvalida_RetornarFalse(string passwd)
        {
            var req = await _integrationTest.Client.GetAsync($"/api/v1/Password/Valid/{passwd}");
            var resp = await req.Content.ReadAsStringAsync();

            Assert.True(req.IsSuccessStatusCode);
            Assert.Contains("false", resp);
        }

        [Theory]
        [InlineData("AbTp9!fok")]
        [InlineData("AbTp9!fokÉÍÓúéÇç-C#")]
        [InlineData("z%uKyDi)+(^wp!AJ@8x&*eqr9-hEfc#")]
        public async Task SenhaValida_RetornarTrue(string passwd)
        {
            var req = await _integrationTest.Client.GetAsync($"/api/v1/Password/Valid/{passwd}");
            var resp = await req.Content.ReadAsStringAsync();

            Assert.True(req.IsSuccessStatusCode);
            Assert.Contains("true", resp);
        }
    }
}
