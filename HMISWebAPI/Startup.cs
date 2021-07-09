using HMISWebAPI.DataContext;
using HMISWebAPI.Repositories;
using HMISWebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI
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
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddDbContext<HMISManagementContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddTransient(typeof(IDepartmentSetupRepos), typeof(DepartmentSetupRepos));
            services.AddTransient(typeof(IAreaSetupNewRepos), typeof(AreaSetupNewRepos));
            services.AddTransient(typeof(ICitySetupRepos), typeof(CitySetupRepos));
            services.AddTransient(typeof(ICompanySetupRepos), typeof(CompanySetupRepos));
            services.AddTransient(typeof(ICompanyClientSetupRepos), typeof(CompanyClientSetupRepos));

            services.AddTransient(typeof(IDepartmentSetup), typeof(DepartmentSetupService));
            services.AddTransient(typeof(IAreaSetupNew), typeof(AreaSetupNewService));
            services.AddTransient(typeof(ICitySetup), typeof(CitySetupService));
            services.AddTransient(typeof(ICompanySetup), typeof(CompanySetupService));
            services.AddTransient(typeof(ICompanyClientSetup), typeof(CompanyClientSetupService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json/", "");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
