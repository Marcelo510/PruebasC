using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebCore31.Negocio
{
    public class DemoMiddleware
    {
        private readonly RequestDelegate next;
        public DemoMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Principio.");
            await this.next.Invoke(context);
            await context.Response.WriteAsync("Fin.");
        }
    }
}
