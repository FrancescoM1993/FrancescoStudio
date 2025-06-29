string cartellaSorgente = @"Progetti";
string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
string cartellaDestinazione = @$"{cartellaSorgente}_{timestamp}";

/*
void Copia(string sorgente, string destinazione)
{
    Directory.CreateDirectory(destinazione);

    // cercare i files nella cartella sorgente
    string[] files = Directory.GetFiles(sorgente);
    // ciclo in modo da copiare i files nella cartella di destinazione
    for (int i = 0; i < files.Length; i++)
    {
        // ottengo le informazioni sul file corrente
        FileInfo fileInfo = new FileInfo(files[i]);
        string nuovoPercorso = $"{destinazione}/{fileInfo.Name}";
        File.Copy(files[i], nuovoPercorso, true);
    }

    // cercare le cartelle nella cartella sorgente
    string[] cartelle = Directory.GetDirectories(sorgente);
    for (int i = 0; i < cartelle.Length; i++)
    {
        DirectoryInfo info = new DirectoryInfo(cartelle[i]);
        string nuovaCartella = $"{destinazione}/{info.Name}";
        Copia(cartelle[i], nuovaCartella);
    }
}
Copia(cartellaSorgente, cartellaDestinazione);
Console.WriteLine($"Backup completati in: {cartellaDestinazione}");
*/
void Copia(string sorgente, string destinazione)
{
    Directory.CreateDirectory(destinazione);
    foreach (string file in Directory.GetFiles(sorgente))
    {
        string nomeFile = Path.GetFileName(file);
        File.Copy(file, Path.Combine(destinazione, nomeFile), true);
    }

    foreach (string sottoDir in Directory.GetDirectories(sorgente))
    {
        string nomeSottoDir = Path.GetFileName(sottoDir);
        string nuovaDest = Path.Combine(destinazione, nomeSottoDir);
        Copia(sottoDir, nuovaDest);
    }
}
Copia(cartellaSorgente, cartellaDestinazione);
Console.WriteLine($"Backup completati in: {cartellaDestinazione}");



