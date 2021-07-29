using Microsoft.AspNetCore.Http;
using RentItAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Middleware
{
    public class ErrorHandlingMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try 
            {
                await next.Invoke(context);
            }
            catch(RepeatPasswordException repeatpasswordexception)
            {
                context.Response.StatusCode = 500;
                context.Response.WriteAsync(repeatpasswordexception.Message);
            }
        }
    }
}
