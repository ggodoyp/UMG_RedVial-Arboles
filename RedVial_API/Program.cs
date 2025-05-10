
using Microsoft.EntityFrameworkCore;
using RedVial_API.Data;

namespace RedVial_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Modificamos los Cors para darle acceso a la aplicacion assembly.
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowBlazorClient",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:7206") 
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            // Se agrega la politica de Cors al pipeline.
            app.UseCors("AllowBlazorClient");

            app.UseAuthorization();

          
            app.MapControllers();

            app.Run();
        }
    }
}
