using Microsoft.EntityFrameworkCore;
using it3045_finalproject.Data;
using System;
using Microsoft.OpenApi;
using Microsoft.AspNetCore.Builder;
using NSwag;
using OpenApiInfo = Microsoft.OpenApi.OpenApiInfo;
using OpenApiSchema = NSwag.OpenApiSchema;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// Register services required to generate Swagger/OpenAPI documents
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "it3045-finalproject API", Version = "v1" });
});

// Register EF Core DbContext using SQL Server connection string from configuration
builder.Services.AddDbContext<DefaultContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
// Enable middleware to serve generated Swagger as JSON endpoint and the Swagger UI.
// Keep this enabled so the UI is reachable when running locally; restrict in production as needed.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "it3045-finalproject API v1"));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
