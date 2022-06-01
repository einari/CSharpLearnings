using ScaryStuff.Weather;

namespace ScaryStuff;

public class Program
{
    public static void Main()
    {
        // ListOfShapes.Execute();

        var builder = WebApplication.CreateBuilder();
        builder.Services.AddMvc();

        var app = builder.Build();
        app.UseRouting();

        app.UseEndpoints(_ => _.MapControllers());

        app.Run();
    }
}
