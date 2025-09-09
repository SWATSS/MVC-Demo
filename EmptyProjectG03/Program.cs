using Microsoft.AspNetCore.Routing.Constraints;

namespace EmptyProjectG03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Notes

            //MVC Pattern:
            //- Model
            //- View
            //- Controller

            //Types of Applications:
            //- MPA (Multiple Page Application)
            //- SPA (Single Page Application)
            //- RESTful Services
            //- Real-time Apps

            //HTTP Protocol:
            //- Request
            //- Response

            //Important Protocols:
            //- HTTP
            //- FTP
            //- TCP

            //URL : Uniform Resource Locator

            //Server & Hosting:
            //- IIS
            //- Apache / Nginx
            //- Kestrel
            //- Hosting Models:
            //  - In-Process
            //  - Out-of-Process

            //Routing:
            //- Conventional Routing
            //- Attribute Routing
            //- Route Constraints

            #endregion

            var builder = WebApplication.CreateBuilder(args);

            // Services
            builder.Services.AddControllersWithViews();

            var app = builder.Build();



            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/Index", () => "Hellow From Index!");

            //app.MapControllerRoute(
            //        name: "Default",
            //        pattern: "{controller=Movies}/{action=Index}/{id:regex(^\\d{2}$)?}/{name:alpha?}"
            //        //pattern: "{Controller=Movies }/{Action=Index}/{Id:int?",
            //        //defaults: new { Actrion = "Index", Controller = "Movies" },
            //        /*constraints: new { Id = @"\d{2}" }*/// Digits {2 numbers (10, 12, 50)}
            //        //constraints : new { Id = new IntRouteConstraint()}
            //    );
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Movies}/{action=Index}/{id:regex(^\\d{{2}}$)?}/{name:alpha?}"
            );


            //app.MapGet("/{name}", async context =>
            //app.MapGet("/X{name}", async context =>
            //{
            //    //var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");
            //    });

            app.Run();


        }
    }
}
