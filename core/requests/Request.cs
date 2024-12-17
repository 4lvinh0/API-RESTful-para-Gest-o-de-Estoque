using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful_para_Gestao_de_Estoque.core.requests
{
    public abstract class Request
    {
        public string UserId { get; set; } = string.Empty;
    }
}