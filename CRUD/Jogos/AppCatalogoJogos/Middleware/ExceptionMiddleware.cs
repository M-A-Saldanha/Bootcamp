using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AppCatalogoJogos.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch
            {
                await HandleExceptionAsync(context);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context)
        {
            var result = JsonSerializer.Serialize(new { Message = "Ocorreu um erro durante sua solicitação, por favor, tente novamente mais tarde"});
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(result);
        }
    }
}
/*
var result = JsonConvert.SerializeObject(new { error = exception.Message });
context.Response.ContentType = "application/json";
await context.Response.WriteAsync(result);
*/
