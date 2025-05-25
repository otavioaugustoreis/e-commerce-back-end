using Cadastro.Application.Services;
using Cadastro.Data;
using cadastro_produtos_design_patterns.Util;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(p => { 
});

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddConectionBD(mySqlConnection!);
builder.Services.AddMapper();
builder.Services.AddDIP();


builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(PagamentoService).Assembly));

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
