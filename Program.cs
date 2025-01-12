
using API_RESTful_para_Gestao_de_Estoque.core.handlers;
using API_RESTful_para_Gestao_de_Estoque.infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Banco de dados
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseInMemoryDatabase("InMemoryDB"));


//Controllers
builder.Services.AddControllers();


//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Injeção de Dependencia
builder.Services.AddTransient<ITarefaHandler, TarefaHandler>();


//---------------------------------------------------//
var app = builder.Build();

//Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//Swagger
app.MapControllers();


//App run
app.Run();
