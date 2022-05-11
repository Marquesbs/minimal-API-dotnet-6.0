var builder = WebApplication.CreateBuilder(args);
/*Internamente, a classe WebApplicationBuilder chama o método de extensão ConfigureWebHostDefaults() que configura a hospedagem para o aplicativo da Web, 
incluindo a configuração do Kestrel como o servidor da Web, adicionando middleware de filtragem de host e habilitando a integração do IIS.*/

//adiciona serviços ao contêiner DI
{
    var services = builder.Services;
    services.AddControllers();
}

var app = builder.Build();

// configura solicitação HTTP
{
    app.MapControllers();
}

app.Run();