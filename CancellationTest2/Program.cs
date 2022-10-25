var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (CancellationToken token) =>
{
    while (!token.IsCancellationRequested)
    {
        await Task.Delay(1000);
        Console.WriteLine("Running.");
    }

    Console.WriteLine("Cancelled.");
});

app.Run();