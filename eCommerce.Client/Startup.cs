
using eCommerce.Client.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using eCommerce.Data.Context;
using eCommerce.Data.MapperProfiles;

namespace eCommerce.Client

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ECommerceContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("eCommerceDB"),
                    sqlServerOptions => sqlServerOptions.MigrationsAssembly("eCommerce.Data")));


            services.AddTransient<IOrdersService, OrdersService>();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddSwaggerGen(c =>

            {
                c.SwaggerDoc("v0.1", new OpenApiInfo { Title = "eCommerce", Version = "v1" });
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()
                .Where(x => x.FullName?.Contains("eCommerce", StringComparison.OrdinalIgnoreCase) == true));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v0.1/swagger.json", "eCommerce API V1");
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
