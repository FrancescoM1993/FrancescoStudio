
string path = @"Json/1.json";
AlbumService albumFibra = new(path);

/*
List<Album> albumFibra1 = albumFibra.CaricaAlbum();

foreach (var af in albumFibra1)
{

    System.Console.WriteLine($"Titolo : {af.Titolo}");
    System.Console.WriteLine($"Anno : {af.Anno}");
    System.Console.WriteLine($"Autore : {af.Autore}");
    
    foreach (var canzone in af.Canzoni)
    {
        Console.WriteLine($"Canzone :{canzone}");
    }

    System.Console.WriteLine($"Genere : {af.Genere}");
    System.Console.WriteLine($"Ascoltato : {af.Ascoltato}");
}
*/

var builder = WebApplication.CreateBuilder(args);

// Aggiungi i Controller 
// I Controller sono responsabili alla gestione delle richieste HTTP e della restituzione delle risposte.

builder.Services.AddControllers();

// Registro il servizio in memoria per i prodotti
// Vado a simulare un archivio di dati 

builder.Services.AddSingleton<AlbumService>();

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

var app = builder.Build();

// parte riguardante la configurazione dell'applicazione con l'uso di middleware

// il middleware è un componente che gestisce una funzionalità specifica dell'applicazione

// Middleware HTTPS e CORS

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

