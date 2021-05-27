

using System;

namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "This is a demo";
            demo.PrintToConsole();
            "Hello there".PrintToConsole();

            var logger = new SimpleLogger();
            logger.LogError("This is an error");
        }
    }
    public static class ExtendSimpleLogger
    {
        public static void LogError(this SimpleLogger logger, string message)
        {
            var defaultColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");
            Console.ForegroundColor = defaultColour;
        }
    }
    public class SimpleLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
        public void Log(string message, string messageType)
        {
            Log($"{messageType}: {message}");
        }
    }
}
