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
using TestApi.Data;
using TestApi.Repository;
using TestApi.Service;


namespace TestApi
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
            services.AddDbContext<DatabaseContext>(
                opt=> opt.UseSqlServer(
                        Configuration.GetConnectionString("DatabaseConnection")
                    )
                );
            services.AddScoped<ISKUService,SKUManager>();
            services.AddScoped<IOrderService,OrderManager>();
            services.AddScoped<IAddressService,AddressManager>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICustomerService,CustomerManager>();
            services.AddScoped<IOrderItemService,OrderItemManager>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(EfRepository<>));

            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
