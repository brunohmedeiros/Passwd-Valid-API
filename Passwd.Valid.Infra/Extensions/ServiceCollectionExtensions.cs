using Microsoft.Extensions.DependencyInjection;
using Passwd.Valid.Domain.Entities;
using Passwd.Valid.Domain.Interfaces;
using Passwd.Valid.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwd.Valid.Infra.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDI(this IServiceCollection services)
        {
            services.AddTransient<IPasswordService, PasswordService>();

            return services;
        }
    }
}
