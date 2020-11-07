using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using VASEP.Implement;
using VASEP.Interfaces;

namespace VASEP
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue;
                x.MemoryBufferThreshold = int.MaxValue;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler
            {
                InboundClaimTypeMap = new Dictionary<string, string>()
            };

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = Configuration["Jwt:JwtIssuer"],
                        ValidAudience = Configuration["Jwt:JwtIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:JwtKey"])),
                        ClockSkew = TimeSpan.Zero,
                    };
                    cfg.SecurityTokenValidators.Clear();
                    cfg.SecurityTokenValidators.Add(jwtSecurityTokenHandler);
                });

            services.AddTransient<IMediaBusinessLogic, MediaBusinessLogic>();
            services.AddTransient<IUserBusinessLogic, UserBusinessLogic>();
            services.AddTransient<IHomeBusinessLogic, HomeBusinessLogic>();
            services.AddTransient<IMemberBusinessLogic, MemberBusinessLogic>();
            services.AddTransient<INewBusinessLogic, NewBusinessLogic>();
            services.AddTransient<IDocumentBusinessLogic, DocumentBusinessLogic>();

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
                options.SerializerSettings.DateParseHandling = DateParseHandling.DateTimeOffset;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "VASEP Api",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "SoftViet",
                        Email = "phill@thanglonginc.com",
                    }
                });
            });

            services.AddDistributedMemoryCache();
            services.AddSession(o =>
            {
                o.IdleTimeout = TimeSpan.FromMinutes(5);
                o.Cookie.HttpOnly = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VASEP Api");
            });
            app.UseSession();
        }
    }
}
