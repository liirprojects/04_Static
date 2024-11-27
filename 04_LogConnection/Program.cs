namespace _04_LogConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection = Logger.LogFilePath;
            Console.WriteLine("Path : {0}", connection);

            string messageToLogger = "Data added";
            Logger.MessageLogWriter(messageToLogger);

            int counter = Logger.CountMessages();
            Console.WriteLine("Count: {0}", counter);

            string errorOccurred = "Bugs were fixed";
            Logger.MessageLogWriter(errorOccurred);

            Console.WriteLine("Counter : {0}", Logger.CountMessages());

            Console.ReadKey();
        }
    }
    public static class Logger
    {
        private static string logFilePath;

        private static readonly List<string> Messages;

        public static int CountMessages()
        {
            return Messages.Count();
        }
        public static string LogFilePath
        {
            get { return logFilePath; }
            private set { logFilePath = value; }
        }

        static Logger()
        {
            logFilePath = "path to database connection";
            Messages = new List<string>();
        }

        public static void MessageLogWriter(string message)
        {
            string logEntry = $"[{DateTime.Now}] - {message}";
            Messages.Add(logEntry);

            Console.WriteLine($"Log message was added: \n -- [{message}] --");
        }
    }
}
