
DateTime birthDate = new DateTime(1993, 10, 30); // Inserisci la tua data
Console.WriteLine($"Sei nato il {birthDate}"); // Stampa la data di nascita

DateTime today = DateTime.Today; //oggi
Console.WriteLine($"Oggi è {today}"); // Stampa la data odierna 

// Conversioni

Console.WriteLine($"Oggi è {today.ToShortDateString()}"); // Stampa la data odierna in formato breve
Console.WriteLine($"Oggi è {today.ToLongDateString()}"); // Stampa la data odierna in formato lunga
Console.WriteLine($"Oggi è {today.ToString("dddd/MMMM/yy")}");
Console.WriteLine($"Il giorno della settimana e: {birthDate.DayOfWeek}");

// Parse
// DateTime.Parse e un metodo che converte una stringa in un oggetto DateTime (Ad esempio quandi un utente inserisce una data)
string dateString = "2024-12-31";
DateTime date = DateTime.Parse(dateString);
Console.WriteLine($"La data convertita e: {date}");

// Try parse
DateTime parseDate;
if (DateTime.TryParse("2024-12-31", out parseDate))
{
    Console.WriteLine(parseDate);
}
else
{
    Console.WriteLine("Errore nella conversione della data");
}

// Operazioni con le date

DateTime domani = today.AddDays(1);
Console.WriteLine($"Domani è:{domani}");
DateTime ieri = today.AddDays(-1);
Console.WriteLine($"Ieri era:{ieri}");
Console.WriteLine($"Ieri era:{ieri: dddd}");
Console.WriteLine($"domani è:{domani: dddd}");

// Time Span indica un intervallo di tempo

TimeSpan timeSpan = new TimeSpan(5, 3, 10, 0, 0); // 5 giorno, 3 ore, 5 minuti, 10 secondi e 0 millisecondi 0 microsecondi
TimeSpan age = today - birthDate; // Calcola l' eta in giorni
Console.WriteLine($"La tua età in giorni è: {age.Days}");

Console.WriteLine($"La tua età in giorni è: {age.Days / 365} anni");

DateTime nextYear = new DateTime(today.Year + 1, 1, 1);
Console.WriteLine($"Mancano {nextYear - today} giorni a Capodanno");

DateTime nextMonth = today.AddMonths(1);
Console.WriteLine($"Mancano {nextMonth - today} giorni al prossimo mese");

// Compare

DateTime date1 = DateTime.Today;
DateTime date2 = new DateTime(2024, 12, 31);
int result = DateTime.Compare(date1, date1);
Console.WriteLine($"Confronto tra date:{result}");

if ( result < 0)
{
    Console.WriteLine("La data2 è antecedente");

}
else if ( result == 0)
{
    Console.WriteLine("il risultato è giusto");

}

else if ( result > 0)
{
 
    Console.WriteLine($"La data2 è successiva");
    
}




