using System;

public class ConsoleOutput : IOutput
    {
        public void Send(string message) => Console.WriteLine(message);
    }