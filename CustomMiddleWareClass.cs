using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace TestCustomApi
{
    public class CustomMiddleWareClass: IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("\n\nFrom Custom Middleware from seperate file");
            await next(context);
            await context.Response.WriteAsync("\n\nleaving Custom Middleware from seperate file");
        }
    }
}
