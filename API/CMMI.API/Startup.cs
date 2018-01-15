using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMMI.Contracts;
using CMMI.Logging.Service;
using CMMI.Services;
using CMMI.Store.Base;
using CMMI.Store.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CMMI.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IDbConnectionFactory, SqlConnectionFactory>();
            services.AddTransient<IDataStore, DataStore>();
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddSingleton<CMMI.Logging.Contract.ILogger, DBLogger>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
