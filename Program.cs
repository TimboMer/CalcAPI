var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/calc/add", (int a, int b) => { return a + b; });
app.MapGet("/calc/subtract", (int a, int b) => { return a - b; });
app.MapGet("/calc/multiply", (int a, int b) => { return a * b; });

app.Run();
