using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.PersistenceAdapter.Models;
using GrantCountyAs400.PersistenceAdapter.Repositories;
using GrantCountyAs400.PersistenceAdapter.SecurityModule;
using GrantCountyAs400.PersistenceAdapter.SecurityModule.Models;
using GrantCountyAs400.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GrantCountyAs400.Web
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
            // Add framework services.
            services.Configure<IISOptions>(options =>
            {
            });
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddDistributedMemoryCache();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
        .AddSessionStateTempDataProvider();

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
            });
            services.AddDbContext<GrantCountyDbContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("GrantCountyDbContext")));
            services.AddDbContext<ApplicationDbContext>(options =>
                       options.UseSqlServer(Configuration.GetConnectionString("GrantCountySecurityDbContext")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddScoped<IPersonnelRepository, PersonnelRepository>();
            services.AddScoped<IGeneralLedgerRepository, GeneralLedgerRepository>();
            services.AddScoped<IDeductionRepository, DeductionRepository>();
            services.AddScoped<ILegalDescriptionRepository, LegalDescriptionRepository>();
            services.AddScoped<IManufacturedHomeParkRepository, ManufacturedHomeParkRepository>();
            services.AddScoped<IPlatCondoRepository, PlatCondoRepository>();
            services.AddScoped<IChildParentParcelRepository, ChildParentParcelRepository>();
            services.AddScoped<IAssociatedPersonRepository, AssociatedPersonRepository>();
            services.AddScoped<IRealPropertyRepository, RealPropertyRepository>();
            services.AddScoped<IBuildingPermitsRepository, BuildingPermitsRepository>();
            services.AddScoped<ILegalDocumentRepository, LegalDocumentRepository>();
            services.AddScoped<IBuildingPermitSystemRepository, BuildingPermitSystemRepository>();
            services.AddScoped<ITaxReceivableRepository, TaxReceivableRepository>();


            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                options.AddPolicy("RequireAccountantRole", policy => policy.RequireRole("Accountant"));
                options.AddPolicy("RequireEitherAccountantOrAdminRole", policy => policy.RequireRole("Accountant", "Admin"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc();

            AutoMapperConfig.Configure();
        }
    }
}