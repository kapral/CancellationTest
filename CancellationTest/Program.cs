var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (CancellationToken token) => new HttpClient().GetAsync("https://localhost:7270/", token));

app.Run();