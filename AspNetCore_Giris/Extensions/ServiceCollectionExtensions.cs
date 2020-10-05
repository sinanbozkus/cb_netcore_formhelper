using AspNetCore_Giris.Models;
using AspNetCore_Giris.Validations;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Giris.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<UserFormViewModel>, UserFormViewModelValidator>();

            return services;
        }
    }
}
