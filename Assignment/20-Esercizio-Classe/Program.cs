

/*Senza classe
using Newtonsoft.Json.Linq;

string json = @"{
    ""Marca"":""Lamborghini"",
    ""Anno_immatricolazione"": 2006,
    ""Modello"": ""Sportiva"",
    ""Assicurazione_attiva"": true,
}";

JObject automobile = JObject.Parse(json);

Console.WriteLine($"Marca: {automobile["Marca"]}");
Console.WriteLine($"Anno_immatricolazione: {automobile["Anno_immatricolazione"]}");
Console.WriteLine($"Modello: {automobile["Modello"]}");
Console.WriteLine($"Assicurazione_attiva: {automobile["Assicurazione_attiva"]}");
*/

/* Con classe senza costruttore

using Newtonsoft.Json;

string json = @"{
    ""Marca"":""Lamborghini"",
    ""Anno_immatricolazione"": 2006,
    ""Modello"": ""Sportiva"",
    ""Assicurazione_attiva"": true,
}";

Automobile automobile = JsonConvert.DeserializeObject<Automobile>(json);

Console.WriteLine($"Marca: {automobile.Marca}");
Console.WriteLine($"Anno_immatricolazione: {automobile.Anno_immatricolazione}");
Console.WriteLine($"Modello: {automobile.Modello}");
Console.WriteLine($"Assicurazione_attiva : {automobile.Assicurazione_attiva}");

public class Automobile
{
    public string Marca { get; set; }
    public int Anno_immatricolazione { get; set; }
    public string Modello { get; set; }
    public bool Assicurazione_attiva { get; set; }
}

*/

// Con classe senza costruttore

using Newtonsoft.Json;

Automobile automobile = new Automobile(
    marca: "Lamborghini",
    annoImmatricolazione: 2006,
    modello: "Sportiva",
    assicurazioneAttiva: true
);


Console.WriteLine("Marca: ");
automobile.Marca = Console.ReadLine();
Console.WriteLine($"Anno di Immatricolazione:");
automobile.AnnoImmatricolazione = int.Parse(Console.ReadLine());
Console.WriteLine($"Modello:");
automobile.Modello = Console.ReadLine();
Console.WriteLine($"Assicurazione:true o false");
automobile.AssicurazioneAttiva = bool.Parse(Console.ReadLine());


/*
Automobile automobile = new Automobile(); // Creo un libro di default
new Automobile("Titolo", 2025, "Fantascienza", false); // Andiamo a creare un libro personalizzato
Console.WriteLine($"Titolo: {automobile.Marca}");
*/