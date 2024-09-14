using LH_PETS.Classes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto web - LH Pets Versão 1");

app.UseStaticFiles();

Banco banco = new Banco();

app.MapGet("/listaClientes", (HttpContext context) => {
    context.Response.WriteAsync(banco.GetListaString());
});

app.Run();
