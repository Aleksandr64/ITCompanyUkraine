using System.Globalization;
using ITCompany.Application.Services;
using ITCompany.Application.Services.Interface;
using ITCompany.Infrastructure;
using ITCompany.Infrastructure.Repository;
using ITCompany.Infrastructure.Repository.Interface;
using ITCompany.Web.Handler;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddSingleton<DapperContext>();

builder.Services.AddScoped<ICompanyService, CompanyService>();

builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();

app.MapControllers();

app.Run();