# METODI FILES E FOLDERS

// Creare un file
```csharp

string pathTest = @"test.txt";
File.Create(pathTest).Close(); // Chiudere il file dopo la creazione permette di poterci scrivere dentro

// Creare un file con il timestamp con nome

string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
string path = $"test_{timestamp}.txt;
File.Create(path).Close();

// Scrivere su un file

File.WriteAllText(path, "test di scrittura su un file\n");scrive il testo nel file, sovrascrivendo il contenuto esistente

// Scrivere una collezione di stringhe su un file
List<string> lines = new List<string> { "linea1", "linea2", "linea3"};
File.WriteAllLines(path,lines); // Scrive ogni stringa della lista su una nuova riga del file

// aggiungere testo ad un file

File.AppendAllText(path, "test di append\n"); // Aggiunge il testo alla fine del fine del file senza sovrascrivere il contenuto

// aggiungere una lista di stringe ad un file

File.AppendAllLines(path, lines); // aggiunge ogni stringa della lista alla fine del file, una per riga

// Leggere da un file

string content = File.ReadAllText(path); // Legge tutto il contenuto del file in una stringa

// stampo il contenuto del file

Console.WriteLine(content);

// Leggere riga per riga da un file

string[] lines = File.ReadAllLines(path);

// stampo le righe lette

foreach (string line in lines)
{
Console.WriteLine(line);
}

for (int i = 0; i <line.Lenght; i++)
{
    Console.WriteLine($"riga{i + 1}; {lines[i]}");
}

// eliminare un file

if (File.Exists(path))
{
    File.Delete(path); // elimina il file se esiste
}
else
{
    Console.WriteLine("Il file non esiste.");
}

// Copiare un file

string sourcePath = "source.txt";
string destinationPath = "destination.txt";

if (File.Exists(sourcePath))
{
    File.Copy(sourcePath, destinationPath, true); // Copia il file, sovrascrivendo se esiste gia
    // il parametro true che indica di sovrascrivere il file di sestinazione se esiste gia
}
else 
{
    Console.WriteLine("Il file di origine non esiste.");
}

// Rinonimare un file
string oldFileName = @"oldname.txt";
string oldFileName = @"newname.txt";

if (File.Exists(oldFileName))
{
    File.Move(oldFileName, newFileName); // Rinomina il file
}
else
{
    Console.Writeline("Il file da rinominare non esiste.");
}

// Folders

// creare una directory
string dir  @"test";
Directory.CreateDirectory(dir);

// verificare se una directory esiste
if (Directory.Exist(dir))
{
    Console.WriteLine("Directory exists");
}

// Eliminare una directory
Directory.Delete(dir);

// ottenere informazioni su un file
FileInfo info = new FileInfo(path);
Console.WriteLine(info.Length);
Console.WriteLine(info.CreationTime);
Console.WriteLine(info.LastWriteTime);
Console.WriteLine(info.Extension);
Console.WriteLine(info.Name);
Console.WriteLine(info.DirectoryName);

// ottenere informazioni su una directory

DirectoryInfo dirInfo = new DirectoryInfo(dir);
Console.WriteLine(dirInfo.CreationTime);
Console.WriteLine(dirInfo.LastWriteTime);
Console.WriteLine(dirInfo.Name);

// Elencare i file in una directory
string[] files = Directory.GetFiles(dir);
foreach (string file in)


titttu
```