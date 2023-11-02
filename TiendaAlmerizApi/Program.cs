using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using TiendaAlmerizApi.Aplicacion;
using TiendaAlmerizApi.Infraestructura.Contenedor;

try
{
    var builder = WebApplication.CreateBuilder(args);

    #region services
    // Add services to the container.
    builder.Services.AddControllersWithViews();
    builder.Services.AddSignalR();
    builder.Services.AddControllers(options =>
    {
        options.EnableEndpointRouting = false;
    });


    builder.Services.AddSwaggerGen(s =>
    {
        s.SwaggerDoc("v1", new OpenApiInfo { Title = "TiendaAlmerizApi", Version = "v1" });
    });

    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("CORSPolicy",
            builder => builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowAnyOrigin());
    });

    builder.Services.AddConfiguracionInfraestructura();
    builder.Services.AddConfiguracionCQRS();

    #endregion services

    #region configuration
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    else
    {
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseAuthorization();

    app.UseCors("CORSPolicy");

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    app.MapControllers();

    app.Run();

    #endregion configuracion

}
catch (Exception ex)
{

}
finally
{

}