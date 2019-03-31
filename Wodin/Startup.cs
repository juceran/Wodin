using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wodin.Models;
using Wodin.Context;
using Wodin.ContextFluentAPI;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Wodin.Services;

namespace Wodin
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Context de acesso ao Banco de Dados
            services.AddDbContext<AdmContext>(options => options.UseNpgsql("Host=localhost;Database=Adm;Username=WODINPASS;Password=(*5523bASS%$12_."));
            services.AddDbContext<NovoContext>(options => options.UseNpgsql("Host=localhost;Database=3R_Ambiental;Username=WODINPASS;Password=(*5523bASS%$12_."));
            services.AddDbContext<WodinContext>(options => options.UseNpgsql("Host=localhost;Database=Wodin;Username=WODINPASS;Password=(*5523bASS%$12_."));

            //injeçao de dependência para personalizar a criação do campos no banco de dados, FluentAPI - Contexts
            //pertence a todas as bases
            services.AddScoped<EmpresaConfiguration>();

            //Adm apenas
            services.AddScoped<MenuUlConfiguration>();
            services.AddScoped<MenuLiConfiguration>();

            //tabelas do sistema
            services.AddScoped<DepartamentoConfiguration>();
            services.AddScoped<FormaPagamentoConfiguration>();
            services.AddScoped<PrazoPagamentoConfiguration>();

            services.AddScoped<PessoaConfiguration>();
            services.AddScoped<PessoaClienteConfiguration>();
            services.AddScoped<PessoaEmailConfiguration>();
            services.AddScoped<PessoaEnderecoConfiguration>();
            services.AddScoped<PessoaFisicaConfiguration>();
            services.AddScoped<PessoaFornecedorConfiguration>();
            services.AddScoped<PessoaJuridicaConfiguration>();
            services.AddScoped<PessoaUsuarioConfiguration>();
            services.AddScoped<PessoaUsuarioSenhaConfiguration>();
            services.AddScoped<PessoaTelefoneConfiguration>();
            services.AddScoped<UsuarioPermissaoAcessoConfiguration>();

            //serviços dos repositorios
            services.AddScoped<DepartamentoService>();
            services.AddScoped<MenuService>();
            services.AddScoped<SubMenuService>();
            services.AddScoped<LoginService>();
            services.AddScoped<PessoaService>();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
