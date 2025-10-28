namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // add service here
            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            var app = builder.Build();
            // use cors as defined above
            app.UseCors("AllowAllOrigins");
            // add mappings
            app.MapControllers();
            app.MapGet("/", () => { return Results.Redirect("/api/v1/books"); });
            app.Run();
        }
    }
}