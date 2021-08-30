using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WowApp.Database;
using WowApp.Database.Service;

using ServiceFactory = WowApp.Database.Service.Factory;
using DatabaseFactory = WowApp.Database.Factory;

namespace WowApp.Host
{
    public class Startup
    {

        private ILoggerFactory _loggerFactory;

        public Startup(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;
            _loggerFactory = loggerFactory;
        }

        private IWebHostEnvironment CurrentEnvironment{ get; set; }
        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            ConfigureCoreServices(services);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }


        private void ConfigureCoreServices(IServiceCollection services)
        {
            Type typeOfContent = typeof(Startup);

            services.AddDbContext<PostgreSqlContext>
            (
                x => x.UseNpgsql
                (
                    Configuration.GetConnectionString("PostgreSqlConnection"),
                    b => b.MigrationsAssembly(typeOfContent.Assembly.GetName().Name)
                )
            );

            services.AddScoped<IDatabaseContainer>(
                x => DatabaseFactory.Create(_loggerFactory)
            );

            services.AddScoped<IServiceContainer>
            (
                x => ServiceFactory.Create(
                    _loggerFactory,
                    x.GetRequiredService<IDatabaseContainer>()
                )
            );
        }
    }
}