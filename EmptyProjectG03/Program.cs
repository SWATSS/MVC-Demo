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

            app.Run();


        }
    }
}
