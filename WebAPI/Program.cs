var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

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

builder.Services.AddControllers();  // Dodaj obs³ugê kontrolerów
builder.Services.AddAuthorization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{

}

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.MapControllers(); // Mapowanie kontrolerów

app.Run();
