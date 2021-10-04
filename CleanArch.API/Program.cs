using CleanArch.Application.Common.Helper;
using CleanArch.Application.Interfaces.Helpers;
using CleanArch.Application.Interfaces.Services;
using CleanArch.Application.Services;
using CleanArch.Infrastructure.Repository;
using Microsoft.OpenApi.Models;
using static CleanArch.API.Controllers.StudentControlller;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container..

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IDateTimeHelper, DateTimeHelper>();
builder.Services.AddControllers();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "CleanArch.API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArch.API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
