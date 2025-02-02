namespace HelloCS446DotNetWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello CS446!");

            app.Run();
        }
    }
}
