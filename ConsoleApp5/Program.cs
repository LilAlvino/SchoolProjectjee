using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question() { Vraag = "Op welke dag vieren we prinsjesdag?", Antwoord = "Dinsdag" };

            ChoiceQuestion q2 = new ChoiceQuestion() { Vraag = "Wanneer is het eerste kerstdag?"};
            q2.addChoice("24 december", false);
            q2.addChoice("25 december", true);
            q2.addChoice("26 december",false);
            q2.addChoice(" 5 december", false);


            presentQuestion(q1);
            presentQuestion(q2);

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
        public List<String> choices = new List<string>();

        public void addChoice(string possibleAnswer, Boolean measure)
        {
            choices.Add(possibleAnswer);
            if (measure == true)
            {
                Antwoord = possibleAnswer;
            }
        }
        
        public new void display()
        {
            Console.WriteLine(Vraag);
            choices.ForEach(el => Console.WriteLine(el));


        }
    }
}
