using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question() { Vraag = "Op welke dag vieren we prinsjesdag?", Antwoord = "Dinsdag"};
    
            ChoiceQuestion q2 = new ChoiceQuestion();
            presentQuestion(q1);

        }

        public static void presentQuestion(Question q)
        {
            q.display();
            string gegevenAntwoord = "";
            gegevenAntwoord = Console.ReadLine();
            if (q.checkAnswer(gegevenAntwoord) == true)
            {
                Console.WriteLine("Goed");
            }
            else
            {
                Console.WriteLine("Fout");
            }
        }
    }

    public class Question
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }

        public Boolean checkAnswer(String answer)
        {
            return answer.Equals(Antwoord);
        }

        public void display()
        {
            Console.WriteLine(Vraag);
        }

    }

    public class ChoiceQuestion : Question
    {
        //private List<string> choices = new List<string>;

        
    }
}
