using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

class Startup
{
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        app.Run(async context =>
        {
            await context.Response.WriteAsync("Hello, World!");
        });

        app.Map("/acos", context => 
        {
            context.Run(async ctx => 
            {
                await ctx.Response.WriteAsync("Hello world, Acos!");
            });
        });
    }
}