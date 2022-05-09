var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/calc/add", (int a, int b) => {     return a + b; });
app.MapGet("/calc/subtract", (int a, int b) => { return a - b; });
app.MapGet("/calc/multiply", (int a, int b) => { return a * b; });

app.MapGet("/calculator/{equation}", (String equation) => {
    DataTable dt = new DataTable();
    var v = dt.Compute(equation, "");
    return v; 
});
app.Run();
