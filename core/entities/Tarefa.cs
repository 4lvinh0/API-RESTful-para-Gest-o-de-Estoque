using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.enums;

namespace API_RESTful_para_Gestao_de_Estoque.core.entities
{
    public class Tarefa
    {
        public int Id {get; set;}
        
        public string? Title {get; set;}
        public string? Description {get; set;}

        public DateOnly? DataVencimento {get; set;}

        public TarefaStatus Status {get; set;}


        public int UsuarioId {get; set;}
        public Usuario Usuario {get; set;} = null!;

    }
}