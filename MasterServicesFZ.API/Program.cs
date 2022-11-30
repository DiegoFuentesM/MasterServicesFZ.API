using dotenv.net;
using MasterServicesFZ.API.Configuration;
using MasterServicesFZ.API.Middleware;
using MasterServicesFZ.Application;
using MasterServicesFZ.Auth;
using MasterServicesFZ.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

//Load environment variables
DotEnv.Load();

//Load appsettings.json
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.{envName}.json", optional: true, reloadOnChange: true);
});

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Configure swagger
builder.Services.ConfigureSwagger();

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddAuthServices(builder.Configuration);

//Configure cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("./v1/swagger.json", "Servicios Maestros Api V1");
});

//app.UseMiddleware<ApiKeyMiddleware>();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
