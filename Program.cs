using System.Diagnostics;
namespace apimentoringsystem

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Process secondProcess = new Process();
            secondProcess.StartInfo.FileName = @"..\mentoring-system\bin\Debug\net6.0-windows\mentoring-system.exe";
            secondProcess.Start();
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            
        }
    }
}



