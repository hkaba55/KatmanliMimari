using Autofac;
using Autofac.Extensions.DependencyInjection;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.DependencyResolvers.Autofac;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Domain.Concrete.Entity;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});

// Add services to the container.
//***AuFac***, Ninject, CastleWindsor, LightInject vb.
//AOP
builder.Services.AddControllers();
//builder.Services.AddSingleton<IValidator<Category>, CategoryValidator>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<IValidator<Category>, CategoryValidator>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
