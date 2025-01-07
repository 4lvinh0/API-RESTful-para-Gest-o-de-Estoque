using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful_para_Gestao_de_Estoque.core.entities
{
    public class Usuario
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public int Senha {get; set;}

        public ICollection<Tarefa> Tarefa {get;} = new List<Tarefa>();
    }
}