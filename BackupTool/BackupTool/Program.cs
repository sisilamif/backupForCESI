using System;

class Program
{
    static void Main()
    {
        // Create source and destination directory
        Console.WriteLine("Enter the source file path");
        string ?sourceDirectory = Console.ReadLine();
        Console.WriteLine("Enter destination file path");
        string ?destinationDirectory = Console.ReadLine();
        
        // use the backupservice librairy
        var backupService = new CreateBackup.BackupService();
        backupService.PerformBackup(sourceDirectory, destinationDirectory);

        Console.ReadLine();
    }
}
