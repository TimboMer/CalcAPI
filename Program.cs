using System.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/calc/add", (double a, double b) => { return a + b; });
app.MapGet("/calc/subtract", (double a, double b) => { return a - b; });
app.MapGet("/calc/multiply", (double a, double b) => { return a * b; });

app.MapGet("/calculator/{term}", (String term) => {
    DataTable dt = new DataTable();
    try
    {
        var result = dt.Compute(term, "");
        return result;
    }
    catch (System.Data.SyntaxErrorException ex)
    {
        return "Term not solvable.";
    }
     
});

app.Run();
