var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Only use HTTPS redirection in Production
app.UseHttpsRedirection();

// // Add a root endpoint
// app.MapGet("/", () => "API is running. Visit /weatherforecast for weather data or /openapi for API docs")
//     .WithName("Root")
//     .WithOpenApi();

app.Run();
