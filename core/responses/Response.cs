using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_RESTful_para_Gestao_de_Estoque.core.responses
{
    public class Response<TData>
    {
        public TData? Data { get; set; }
        public string? Menssagem { get; set; }
        public int Code { get; set; }
        public bool IsSuccess { get; set; } = true;


        [JsonConstructor]
        public Response()
        {
        }

        public Response(
            TData? data,
            string? menssagem,
            int code
        )
        {
            Data = data;
            Menssagem = menssagem;
            Code = code;

            if(Code > 399) IsSuccess = false;
        }


    }
}