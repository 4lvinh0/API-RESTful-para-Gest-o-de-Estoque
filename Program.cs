
using API_RESTful_para_Gestao_de_Estoque.core.entities;
using API_RESTful_para_Gestao_de_Estoque.core.handlers;
using API_RESTful_para_Gestao_de_Estoque.infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Banco de dados
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));


builder.Services.AddEndpointsApiExplorer();

//Injeção de Dependencia
builder.Services.AddTransient<ITarefaHandler, TarefaHandler>();


var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
