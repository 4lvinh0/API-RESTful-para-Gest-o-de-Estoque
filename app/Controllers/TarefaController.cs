using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.entities;
using API_RESTful_para_Gestao_de_Estoque.core.handlers;
using API_RESTful_para_Gestao_de_Estoque.core.requests.TarefaRequest;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTful_para_Gestao_de_Estoque.app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController(ITarefaHandler _ITarefaHandler) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> CreateTarefaAsync(CreateTarefaRequest t)
        {

            var response = await _ITarefaHandler.CreateTarefaAsync(t);

            return response.IsSuccess
                ? TypedResults.Created($"v1/Tarefa/{response.Data?.Id}", response)
                : TypedResults.BadRequest(response);
        }

        [HttpDelete]
        public async Task<IResult> DeleteTarefaAsync(DeleteTarefaRequest t)
        {
            var response = await _ITarefaHandler.DeleteTarefaAsync(t);

            return response.IsSuccess
                ? TypedResults.Ok(response)
                : TypedResults.BadRequest(response);
        }

        [HttpPut]
        public async Task<IResult> UpdateTarefaAsync(UpdateTarefaRequest t)
        {
            var response = await _ITarefaHandler.UpdateTarefaAsync(t);

            return response.IsSuccess
                ? TypedResults.Ok(response)
                : TypedResults.BadRequest(response);
        }






    }
}