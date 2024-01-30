namespace LogsEntry
{
    public class MyLogsEntry
    {
        public class LogEntry
        {
            public string? FileName { get; set; }
            public string? SourcePath { get; set; }
            public string? DestinationPath { get; set; }
            public DateTime Timestamp { get; set; }
        }

        // Classe pour représenter une liste de logs
        public class LogList
        {
            public List<LogEntry> Logs { get; set; } = new List<LogEntry>();

            public void AddLog(LogEntry log)
            {
                Logs.Add(log);
            }
        }
    }
}