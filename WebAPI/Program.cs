using Microsoft.AspNetCore.Mvc.Infrastructure;
using Scrabble.Application;
using Scrabble.Infrastructure;
using WebAPI.Common.Errors;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: MyAllowSpecificOrigins,
            policy =>
            {
                policy.WithOrigins("https://yellow-meadow-00395d903.6.azurestaticapps.net")  // React Dev Server
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .SetIsOriginAllowed(origin => true);
            });
    });

    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();  // Dodaj obs³ugê kontrolerów

    builder.Services.AddSingleton<ProblemDetailsFactory, ScrabbleProblemDetailsFactory>();
    
    builder.Services.AddAuthorization();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{

}

{
    app.UseExceptionHandler("/error");
    app.UseCors(MyAllowSpecificOrigins);
    app.UseAuthorization();
    app.MapControllers(); // Mapowanie kontrolerów
}


app.Run();

//test