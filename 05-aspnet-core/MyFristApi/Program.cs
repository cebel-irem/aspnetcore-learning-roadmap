var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "");

//Rota Parametresş ve json nesnesi dönüşü
app.MapGet("/users/{id}", (int id) => {
    return Results.Ok(new { Id = id, Name = $"User {id}", Role = "Developer" });
});
app.Run();
