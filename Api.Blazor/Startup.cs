using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Blazor.Interfaces.Registro;
using Api.Blazor.Interfaces.auth;
using Api.Blazor.Services.Registro;
using Api.Blazor.Services.auth;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Api.Blazor
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var key = "Register Token ApiKey auth";


            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:5000", "https://localhost:5001",
                                           "http://localhost:33208", "http://localhost:33208/register")
                                      .AllowAnyOrigin()
                                      .AllowAnyHeader()
                                       .AllowAnyMethod();
                                  });
            });

            services.AddControllers();

            services
            .AddAuthentication(
            x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }
            )
            .AddJwtBearer(
             x =>
             {
                 x.RequireHttpsMetadata = false;
                 x.SaveToken = true;

                 x.TokenValidationParameters = new TokenValidationParameters
                 {
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                     ValidateAudience = false,
                     ValidateIssuerSigningKey = true,
                     ValidateIssuer = false
                 };

             }
             );

            services.AddAuthorization();

            //Servicio verificador y creador de TOKEN JWT
            services.AddSingleton<IJwtAuthenticationService>(new JwtAuthenticationService(key));


            services.AddSingleton<IDataRepositoryDatosPersonales, ServicesDatosPersonales>();
            services.AddSingleton<IDataRepositoryDatosContacto, ServicesDatosContacto>();
            services.AddSingleton<IDataRepositoryDatosEducacion, ServicesDatosEducacion>();
            services.AddSingleton<IDataRepositoryDatosIdiomas, ServicesDatosIdiomas>();
            services.AddSingleton<IDataRepositoryDatosLaborales, ServicesDatosLaborales>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
