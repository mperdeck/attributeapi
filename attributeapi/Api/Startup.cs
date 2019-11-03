using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Api
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            // New

            // Find all automapper profiles in this assembly and configure them.
            // Requires package reference to AutoMapper.Extensions.Microsoft.DependencyInjection
            // Also registers IMapper, so the mapper can be dependency injected.
            // See https://medium.com/ps-its-huuti/how-to-get-started-with-automapper-and-asp-net-core-2-ecac60ef523f
            services.AddAutoMapper();

            // Add generic IAttributeService to the DI container
            // See https://stackoverflow.com/questions/49352434/how-to-register-interface-with-generic-type-in-startup-cs
            services.AddTransient(typeof(IAttributeService<>), typeof(AttributeService<>));

            // Configure automapper (same way as in Decideware code base)
            ConfigureAutoMapper();

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public void ConfigureAutoMapper()
        {
            Mapper.Initialize(x =>
            {
                Api.AutomapperProfiles.AutoMapperConfiguration.ConfigAction.Invoke(x);
            });
        }
    }
}
