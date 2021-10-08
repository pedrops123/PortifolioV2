using System;
using System.IO;
using System.Reflection;
using System.Text;
using Contexto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace webApi
{
    public class Startup
    {
         private const string name_cors = "AllowCorsLocal"; 
         private static string hashServer = "";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            hashServer = configuration.GetSection("hashServer").Value;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configuracao de connection strings
            //services.AddDbContext<ContextoDB>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexionDB")));
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
          services.AddCors(options => options.AddPolicy(name_cors,
          builder => {
              
              builder.AllowAnyHeader();
              builder.AllowAnyOrigin();
              builder.AllowAnyMethod();
              //builder.WithOrigins("http://localhost:4200");
          }));

         var key = Encoding.ASCII.GetBytes(hashServer);

        services.AddAuthentication(x => {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer( x => {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true ;
            x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters(){
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

          // Configuracoes Swagger
          services.ConfigureSwaggerGen(r=>{
              r.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Portifolio V2",
                    Description = "API portifolio V2",
                    TermsOfService = null ,
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact() {
                         Name = "Pedro Vinicius Rodrigues Furlan",
                         Email = "pedro.furlan1304@hotmail.com",
                         Url = null 
                     }
                });

           // mostra comentarios xml para documentação
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            r.IncludeXmlComments(xmlPath);
          });

          services.AddSwaggerGen();
    
          services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           app.UseSwagger();
           app.UseSwaggerUI(c =>
            {
                 c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

    
            app.UseCors(name_cors);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
