using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DatabaseLayer.DIDL
{
    public static class RgDatabaselayer
    {
        public static void RGdatabaselayer(this IServiceCollection builder,IConfiguration configuration )
        {
            builder.AddDbContext<three_tier_api>(Options => Options.UseSqlServer(configuration.GetConnectionString("apiData")));
            //builder.AddDbContext<three_tier_api>(Options => Options.UseNpgsql(configuration.GetConnectionString("apiData")));


        }


    }
}
