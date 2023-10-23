using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using TraversalProject.AuthenticationFilter;
using TraversalProject.CQRS.Handlers.DestinationHandlers;
using TraversalProject.Models;


namespace TraversalProject
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
            services.AddScoped<GetAllDestinationQueryHandler>();
            services.AddScoped<GetDestinationByIdQueryHandler>();
            services.AddScoped<CreateDestinationCommandHandler>();
            services.AddScoped<RemoveDestinationCommandHandler>();
            services.AddScoped<UpdateDestinationCommandHandler>();

            services.AddMediatR(typeof(Startup));

            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug); // LOG ��LEM� NEREDEN �T�BAREN BA�LASIN( BU STAIRDA K� KODUN ANLAMI
                x.AddDebug(); // OUTPUT UZERINDE LOG'LARIMIZI GOSTER KODU

            });

            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>
                ().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();  // BURRASI DA PROJEYE IDENT�TY
                                                                                                                                                                                          // EKLEMEM�Z� SA�LAR 


            services.AddHttpClient();                                                                                           // BU DEPENDENCY INJECTION ILE BAGIMLILIKTAN KURTULMA ISLEMLERI

            services.ContainerDependencies();

            services.AddAutoMapper(typeof(Startup));


            services.CustomValidator();

            services.AddControllersWithViews().AddFluentValidation();
            
            // Admin Policy 
            //services.AddControllersWithViews(config =>
            //{
            //    config.Filters.Add(new AdminPolicyFilter()); // Bu filtreyi t�m controllerlara uygular
            //}).AddFluentValidation();

            ////Member Policy
            //services.AddControllersWithViews(config =>
            //{
            //    config.Filters.Add(new MemberPolicyFilter()); // Bu filtreyi t�m controllerlara uygular
            //}).AddFluentValidation();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(policy));        // bu kodlar PROJE SEV�YES�NDE AUTHOR�ZAT�ON SA�LAR    
            });

            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
                opt.AddPolicy("MemberPolicy", policy => policy.RequireRole("Member"));

            });

            services.AddLocalization(opt =>
            {
                opt.ResourcesPath = "Resources";
            });


            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();


            services.AddRazorPages();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = "/Login/SignIn/";

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            var supportedCultures = new[] { "en", "fr", "es", "gr", "tr", "de" };

            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[4]).AddSupportedCultures(supportedCultures).AddSupportedUICultures(supportedCultures);

            app.UseRequestLocalization(localizationOptions);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "AdminsArea",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}",
                   defaults: new { area = "AdminsArea" }
               ).RequireAuthorization("AdminPolicy");
            });
           
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "memberArea",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}",
                defaults: new { area = "Member" }
            ).RequireAuthorization("MemberPolicy");
            });

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
