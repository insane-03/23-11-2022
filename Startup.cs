namespace TestCustomApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleWareClass>();
        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {

            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("\n\nI'm first middleware-1");
                await context.Response.WriteAsync("\n\nIn log, we added your entry-1");
                context.Response.StatusCode = 200;
                await next();
                await context.Response.WriteAsync(text: "\n\nIn log, we added your exit-1");

            });
            app.UseMiddleware<CustomMiddleWareClass>();
            app.Map("/custom", CustomMiddleWare);
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("\n\nI'm second middleware-2");
                await context.Response.WriteAsync("\n\nYou have access-2");
                context.Response.StatusCode = 200;
                await next();
                await context.Response.WriteAsync(text: "\n\nSee you later-2");

            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("\n\n>>>>>>>>>>> >> > I'm run middleware-3");


            });*/
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private void CustomMiddleWare(IApplicationBuilder app)
        {
            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync(text: "\n\n-----------Mapped Middle ware");
                await next();
            }); 
        }
    }
}
