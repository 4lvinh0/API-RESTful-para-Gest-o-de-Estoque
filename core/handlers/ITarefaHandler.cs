using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.entities;
using API_RESTful_para_Gestao_de_Estoque.core.requests.TarefaRequest;
using API_RESTful_para_Gestao_de_Estoque.core.responses;

namespace API_RESTful_para_Gestao_de_Estoque.core.handlers
{
    public interface ITarefaHandler
    {
        Task<Response<Tarefa>> CreateTarefaAsync(CreateTarefaRequest request);
        Task<Response<Tarefa>> DeleteTarefaAsync(DeleteTarefaRequest request);
        Task<Response<List<Tarefa>>> ReadTarefaByDataVencimentoAsync(ReadTarefaByDataVencimentoRequest request);
        Task<Response<List<Tarefa>>> ReadTarefaByIdAsync(ReadTarefaByIdRequest request);
        Task<Response<List<Tarefa>>> ReadTarefaByUsuarioRequest(ReadTarefaByUsuarioRequest request);
        Task<Response<Tarefa>> UpdateTarefaAsync(UpdateTarefaRequest request);

    }
}