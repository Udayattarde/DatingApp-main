using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.interfaces;
using API.services;
using Microsoft.EntityFrameworkCore;

namespace API.Extenions
{
    public  static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service,IConfiguration config)
        {
             service.AddDbContext<DataContext>(options =>{
                 options.UseSqlite(config.GetConnectionString("DefaultConnections"));
            });
            service.AddScoped<ITokenService,tokenService>();

            return service;
        }
    }
}