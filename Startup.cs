using Microsoft.EntityFrameworkCore;

namespace Web_Api_.NET
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        { 
        
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationdbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {

                endpoints.MapControllers();
            });

           
        }
    }
}
