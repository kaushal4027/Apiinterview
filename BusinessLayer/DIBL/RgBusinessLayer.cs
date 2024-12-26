using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using BusinessLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.DIBL
{
    public static class RgBusinessLayer
    {
        public static void Rgbusinesslayer(this IServiceCollection Services, IConfiguration configuration)
        {
            Services.AddScoped<EmployeeINF,EmployeeServices>();
        }
    }
}
