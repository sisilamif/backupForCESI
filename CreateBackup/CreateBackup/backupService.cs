using System.Diagnostics;
using FilesCopy;
using LogsEntry;
namespace CreateBackup
{
    public class BackupService
    {
        public void PerformBackup(string sourceDirectory, string destinationDirectory)
        {
            // Create the logs diretory
            string logDirectory = Path.Combine(destinationDirectory, "Logs");
            Directory.CreateDirectory(logDirectory);

            // Logs.JSON file path
            string logFilePath = Path.Combine(logDirectory, "logs.json");

            // Create a list for the logs
            var logs = new MyLogsEntry.LogList();

            try
            {
                // Copier les fichiers
                filescopy.CopyFiles(sourceDirectory, destinationDirectory, logs);

                // Sauvegarder les logs au format JSON
                filescopy.SaveLogsToJson(logFilePath, logs);

                Console.WriteLine("Sauvegarde terminée avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la sauvegarde : {ex.Message}");
            }
        }
    }
}
