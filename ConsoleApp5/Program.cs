using System;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Question
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
    }

    public class ChoiceQuestion : Question
    {
        // hoi
    }
}
