using LibeyTechnicalTestAPI.Middleware;
using LibeyTechnicalTestDomain.EFCore;
using Microsoft.EntityFrameworkCore;
IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").AddEnvironmentVariables().Build();
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("localCors",
    builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
builder.Services.AddSwaggerGen();
DIExtensions.AddConfigurations(builder.Services);

var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddFilter("Microsoft", LogLevel.Information) // Puedes ajustar el nivel de log que te interesa
        .AddConsole(); // Esto asegura que los logs se muestren en la consola
});

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(config.GetConnectionString("LibeyTechnicalTest"),
    sqlServerOptionsAction: builder =>
    {
        builder.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
    })
    .UseLoggerFactory(loggerFactory) // Usa el logger configurado
    .EnableSensitiveDataLogging();    // Habilita la captura de datos sensibles
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("localCors");
app.UseRouting();
app.MapControllers();
app.Run();