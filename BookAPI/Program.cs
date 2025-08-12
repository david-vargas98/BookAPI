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

            // Then, this is build the web application startup
            var app = builder.Build();

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
