namespace BookAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This is creating the builder for the web application
            var builder = WebApplication.CreateBuilder(args);

            // Here we can add additional services to the builder
            builder.Services.AddControllers(); // we tell our application that we've created controllers and we want to use them inside the application

            // Now, we need to enable CORS (Cross-Origin Resource Sharing) to allow our Angular application to communicate with this API
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyCors", builder => // name and define a CORS policy
                {
                    builder
                    .WithOrigins("http://localhost:4200") // the origin of our Angular application
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            // Then, this is build the web application startup
            var app = builder.Build();

            // Now, here we add the CORS policy to the middleware pipeline, we need to specify the name of the policy we created earlier
            app.UseCors("MyCors");

            // Here we can add mapping for routes and other configurations
            app.MapControllers(); // with this, everything will be automatically mapped to the controllers we created

            // Adding a redirect
            app.MapGet("/", () =>
            {
                return Results.Redirect("api/books"); // if someone goes to the root URL, they will be redirected to the books API endpoint
            });

            app.Run();
        }
    }
}
