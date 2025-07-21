namespace BackendMusic.Utils
{
    // Questa classe statica si occupa di tracciare le operazioni che avvengono nel sito
    //
    public static class LoggerHelper
    {
        // Log fatto a mano
        public static void Log(string message)
        {
            // Crea una stringa di log con timestmap
            string logline = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            // Scrive il log su console
            Console.WriteLine(logline);
            // Scrive sul file di log
            File.AppendAllText("log.txt", logline + Environment.NewLine); // Farlo con Environment o qualcosa del genere
            //
        }
    }
}
