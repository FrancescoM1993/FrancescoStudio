using Backend.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Aggiungi i Controller 
// I Controller sono responsabili alla gestione delle richieste HTTP e della restituzione delle risposte.

builder.Services.AddControllers();

// Registro il servizio in memoria per i prodotti
// Vado a simulare un archivio di dati 

builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<PurchaseService>();

// Configurare CORS per permettere tutte le origini (sviluppo locale)
// Cross Origin Resource Sharing, è una politica di sicurezza che permette o blocca le richieste tra domini diversi

builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    }
);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "BackendV2 API",
        Version = "v1",
        
    });
});

var app = builder.Build();
// all interno di builder.Services


// parte riguardante la configurazione dell'applicazione con l'uso di middleware

// il middleware è un componente che gestisce una funzionalità specifica dell'applicazione

// Middleware HTTPS e CORS

// subito dopo app = builder.Build():
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BackendV2 API V1");
   
});

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseCors();

// Mappa i controller API 
// Mappa le rotte dei controller API per gestire le richieste HTTP

app.MapControllers();

app.Run();