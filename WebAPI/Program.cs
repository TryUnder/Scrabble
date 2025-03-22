var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")  // React Dev Server
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();  // Dodaj obs³ugê kontrolerów
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.MapControllers(); // Mapowanie kontrolerów

app.Run();
