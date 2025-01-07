using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful_para_Gestao_de_Estoque.core.requests.TarefaRequest
{
    public class ReadTarefaByIdRequest : Request
    {
        [Required]
        public int Id {get; set;}
    }
}