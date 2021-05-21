using DAL.Repository;
using DAL.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsFinancesMenagere
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
            services.AddSingleton<IBillService, BillService>();
            services.AddSingleton<IBillRepository,BillRepository>();
            services.AddSingleton<IOrganizationRepository, OrganizationRepository>();
            services.AddSingleton<IOrganizationService, OrganizationService>();
            services.AddSingleton<ISensibleDataRepository, SensibleDataRepository>();
            services.AddSingleton<ISensibleDataService, SensibleDataService>();
            services.AddSingleton<IRoleService, RoleService>();
            services.AddSingleton<IRoleRepository, RoleRepository>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserReopository>();
            services.AddSingleton<IAccountService, AccountService>();
            services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddSingleton<IPersonalExpenseRepository, PersonalExpenseRepository>();
            services.AddSingleton<IPersonalExpenseService, PersonalExpenseService>();

            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Documentation : Finances Menagere Apps", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AppsFinancesMenagere v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
