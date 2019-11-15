using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class AnswerQuestion
    {
        public int points = 0;
        public void answerQuestion(QuestionElement questionelement)
        {
            int sizeOfList = questionelement.wrongAnswers.Count();
            List<string> answers = new List<string>();
            for (int i = 0; i < sizeOfList; i++)
            {
                answers.Add(questionelement.wrongAnswers[i]);
            }
            answers.Add(questionelement.correctAnswer);
            Console.WriteLine("Beantworte folgende Frage: ");
            Console.WriteLine(questionelement.question);
            Random rng = new Random();
            var something = answers.OrderBy(a => rng.Next());
            answers = something.ToList<String>();
            writeIt(answers);
            Console.WriteLine("Bitte schreiben Sie die korrekte Antwort hin: ");
            Console.Write(">");
            var text = Console.ReadLine();

            if (text == questionelement.correctAnswer)
            {
                points += 1;
                Console.WriteLine("\n Diese Antwort ist korrekt. \n");
            }
            else
            {
                Console.WriteLine("\n Diese Antwort ist falsch. Die richtige Antwort lautet:" + questionelement.correctAnswer + "\n");
            }
        }

        public static void writeIt(List<String> liste)
        {
            foreach (String s in liste)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(".....");
        }

    }
}
