using Microsoft.AspNetCore.Builder;

namespace PruebaApi
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment iwebhost)
        {
            app.Build();
            //app.Equals();
            app.GetHashCode();
            app.GetType();
            app.New();
            

           
        }
        public IConfiguration? configuration { get; }
        public Startup(IConfiguration configuracion)
        {

        }
        public void ConfigureServices(IServiceCollection coleccion)
        {
            coleccion.AddControllers();
            coleccion.AddSwaggerGen();
            coleccion.AddEndpointsApiExplorer();

        }


    }
}
