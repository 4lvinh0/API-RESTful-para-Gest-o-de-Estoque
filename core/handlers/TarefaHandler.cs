using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.entities;
using API_RESTful_para_Gestao_de_Estoque.core.requests.TarefaRequest;
using API_RESTful_para_Gestao_de_Estoque.core.responses;
using API_RESTful_para_Gestao_de_Estoque.infra;
using Microsoft.EntityFrameworkCore;

namespace API_RESTful_para_Gestao_de_Estoque.core.handlers
{
    public class TarefaHandler(AppDbContext context) : ITarefaHandler
    {
        public async Task<Response<Tarefa>> CreateTarefaAsync(CreateTarefaRequest request)
        {
            var t = new Tarefa
            {
                Title = request.Title,
                Description = request.Description,
                DataVencimento = request.DataVencimento,
                Status = request.Status,
                UsuarioId = request.UsuarioId
            };

            await context.Tarefas.AddAsync(t);
            await context.SaveChangesAsync();

            return new Response<Tarefa>(t, "Tarefa criada com sucesso", 200);
        }

        public async Task<Response<Tarefa>> DeleteTarefaAsync(DeleteTarefaRequest request)
        {
            Tarefa? t = await context
                .Tarefas
                .FirstOrDefaultAsync(
                    x =>
                    x.Id == request.Id &&
                    x.Title == request.Title &&
                    x.UsuarioId == request.UsuarioId
                );

            if (t is null)
                return new Response<Tarefa>(null, "Tarefa não encontrada", 400);

            context.Tarefas.Remove(t);
            await context.SaveChangesAsync();

            return new Response<Tarefa>(t, "Tarefa removida com sucesso", 200);
        }

        public async Task<Response<List<Tarefa>>> ReadTarefaByDataVencimentoAsync(ReadTarefaByDataVencimentoRequest request)
        {
            var t = await context
                .Tarefas
                .Where(x => x.DataVencimento == request.DataVencimento)
                .OrderBy(x => x.DataVencimento)
                .ToListAsync();


            if (t.Count == 0)
                return new Response<List<Tarefa>>(null, "Tarefa não encontra", 400);

            return new Response<List<Tarefa>>(t, "Tarefa por Data de Vencimento", 200);
        }

        public async Task<Response<List<Tarefa>>> ReadTarefaByIdAsync(ReadTarefaByIdRequest request)
        {
            var t = await context
                .Tarefas
                .Where(x => x.Id == request.Id)
                .OrderBy(x => x.Id)
                .ToListAsync();


            if (t.Count == 0)
                return new Response<List<Tarefa>>(null, "Tarefa não encontra", 400);

            return new Response<List<Tarefa>>(t, "Tarefa por Data de Vencimento", 200);
        }

        public async Task<Response<List<Tarefa>>> ReadTarefaByUsuarioRequest(ReadTarefaByUsuarioRequest request)
        {
            var t = await context
                .Tarefas
                .Where(x => x.UsuarioId == request.UserIdParaPesquisa)
                .OrderBy( x => x.UsuarioId)
                .ToListAsync();


            if (t.Count == 0)
                return new Response<List<Tarefa>>(null, "Tarefa não encontra", 400);

            return new Response<List<Tarefa>>(t, "Tarefa por Data de Vencimento", 200);        }

        public async Task<Response<Tarefa>> UpdateTarefaAsync(UpdateTarefaRequest request)
        {
            var t = await context
                .Tarefas
                .FirstOrDefaultAsync(x => x.Id == request.Id && x.UsuarioId == request.UsuarioId);

            if (t is null)
                return new Response<Tarefa>(null, "Tarefa não encontrada", 400);

            t.Title = request.Title;
            t.Description = request.Description;
            t.DataVencimento = request.DataVencimento;
            t.Status = request.Status;

            context.Tarefas.Update(t);
            await context.SaveChangesAsync();

            return new Response<Tarefa>(t, "Categoria atualizada com sucesso", 200);
        }
    }
}