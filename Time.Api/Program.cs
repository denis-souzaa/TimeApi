using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.MapGet("/time", () =>
    new {
        CurrentTime = DateTime.UtcNow,
        TimeZoneInfo = "UTC"
    });

app.Run();