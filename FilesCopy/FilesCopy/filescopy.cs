using System;
using System.Collections.Generic;
using System.IO;
using LogsEntry;
using static LogsEntry.MyLogsEntry;
using Newtonsoft.Json;
namespace FilesCopy
{
    public class filescopy
    {
        static public void CopyFiles(string sourceDirectory, string destinationDirectory, MyLogsEntry.LogList logs)
        {
            // Vérifier si le répertoire source existe
            if (!Directory.Exists(sourceDirectory))
            {
                throw new DirectoryNotFoundException($"Le répertoire source '{sourceDirectory}' n'existe pas.");
            }

            // Créer le répertoire de destination s'il n'existe pas
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            // Copier les fichiers
            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(destinationDirectory, fileName);

                File.Copy(filePath, destinationPath, true);

                // Ajouter un log
                logs.AddLog(new MyLogsEntry.LogEntry
                {
                    FileName = fileName,
                    SourcePath = filePath,
                    DestinationPath = destinationPath,
                    Timestamp = DateTime.Now
                });
            }
        }

        static public void SaveLogsToJson(string logFilePath, LogList logs)
        {
            // Convertir les logs en format JSON et écrire dans le fichier
            string jsonLogs = JsonConvert.SerializeObject(logs, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(logFilePath, jsonLogs);
        }
    }
}



