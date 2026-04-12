using System;
using System.Collections.Generic;
using System.IO;

namespace AgenciaTurismo.Services
{
    public class LogService
    {
        public static List<string> Logs = new List<string>();

        public static void LogToConsole(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static void LogToFile(string mensagem)
        {
            File.AppendAllText("log.txt", mensagem + Environment.NewLine);
        }

        public static void LogToMemory(string mensagem)
        {
            Logs.Add(mensagem);
        }
    }
}