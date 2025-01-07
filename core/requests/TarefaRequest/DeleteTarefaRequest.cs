using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful_para_Gestao_de_Estoque.core.requests.TarefaRequest
{
    public class DeleteTarefaRequest : Request
    {
        [Required]
        public int Id {get; set;}

        [Required]
        [MaxLength(128, ErrorMessage = "O titulo contem até 128 caracteres")]
        public string Title {get; set;} = string.Empty;
    }
}