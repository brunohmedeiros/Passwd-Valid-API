using Passwd.Valid.IntegrationTest.Factory;
using System;
using System.Net.Http;
using Xunit;

namespace Passwd.Valid.IntegrationTest.Fixture
{
    [CollectionDefinition(nameof(IntegrationTestFixtureCollection))]
    public class IntegrationTestFixtureCollection : ICollectionFixture<IntegrationTestFixture<StartupIntegrationTest>>
    {

    }

    public class IntegrationTestFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly PasswdAppFactory<TStartup> Factory;
        public HttpClient Client;

        public IntegrationTestFixture()
        {
            var clientOpt = new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions()
            {
                HandleCookies = false,
                BaseAddress = new Uri("http://localhost:5001"),
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 10
            };

            Factory = new PasswdAppFactory<TStartup>();
            Client = Factory.CreateClient(clientOpt);
        }

        ~IntegrationTestFixture() => Dispose();

        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
