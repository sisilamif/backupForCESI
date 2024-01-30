using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

public class BackupService
{
    public void PerformBackup(string sourceDirectory, string destinationDirectory)
    {
        // Créer un répertoire de logs
        string logDirectory = Path.Combine(destinationDirectory, "Logs");
        Directory.CreateDirectory(logDirectory);

        // Chemin du fichier JSON de logs
        string logFilePath = Path.Combine(logDirectory, "logs.json");

        // Liste pour stocker les logs
        var logs = new LogList();

        try
        {
            // Copier les fichiers
            CopyFiles(sourceDirectory, destinationDirectory, logs);

            // Sauvegarder les logs au format JSON
            SaveLogsToJson(logFilePath, logs);

            Console.WriteLine("Sauvegarde terminée avec succès.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur lors de la sauvegarde : {ex.Message}");
        }
    }

    private void CopyFiles(string sourceDirectory, string destinationDirectory, LogList logs)
    {
        // ... (le reste du code de copie des fichiers)
    }

    private void SaveLogsToJson(string logFilePath, LogList logs)
    {
        // ... (le reste du code de sauvegarde des logs au format JSON)
    }
}

// ... (les classes LogEntry et LogList restent les mêmes)

