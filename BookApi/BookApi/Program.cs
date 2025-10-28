namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // add service here
            builder.Services.AddControllers();
            var app = builder.Build();

            // add mappings
            app.MapControllers();
            app.MapGet("/", () =>
            {
                return Results.Redirect("/api/v1/books");
            });
            app.Run();
        }
    }
}
