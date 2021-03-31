using Microsoft.Extensions.DependencyInjection;
using Passwd.Valid.Domain.Interfaces;
using Passwd.Valid.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwd.Valid.UnitTest.Fixture
{
    public class UnitTestFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public UnitTestFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IPasswordService, PasswordService>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
