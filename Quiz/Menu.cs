using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Menu
    {
        public static List<QuestionElement> question = new List<QuestionElement>()
        {
            new QuestionElement("Wie viele Weihnachtsbäume werden in Deutschland pro Jahr verkauft?", "10 Millionen", new List<string> { "20 Millionen", "50 Millionen" }),
            new QuestionElement("Welcher deutsche Bundeskanzler erhielt den Friedensnobelpreis?", "Willy Brandt", new List<string> { "Konrad Adenauer", "Helmut Schmidt", "Helmut Kohl" }),
            new QuestionElement("Wer war Franz Kafka?", "Schriftsteller", new List<string> { "Sänger", "Schauspieler", "Handwerker" })
        };

        public static QuestionElement questionelement = new QuestionElement("", "", new List<string> { "", "" });
        public static AddUserQuestion addeUserQuestion = new AddUserQuestion();
        public static AnswerQuestion answerQuestion = new AnswerQuestion();

        public static void Main()
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("Bitte wählen Sie zwischen: ");
            Console.WriteLine("1. eine neue Frage hinzufügen");
            Console.WriteLine("2. eine Frage beantworten");
            Console.WriteLine("3. Das Spiel verlassen");
            var number = Console.ReadLine();
            int x = Int32.Parse(number);
            if (x == 1)
            {
                questionelement = addeUserQuestion.addUserQuestion();
                question.Add(questionelement);
                menu();
            }
            else if (x == 2)
            {
                    int sizeOfList = question.Count();
                    Random random = new Random(); 
                    int questionNumber = random.Next(0,sizeOfList);
                    answerQuestion.answerQuestion(question[questionNumber]);
                    question.RemoveAt(questionNumber);
                menu();
            }
            else
            {
                Console.WriteLine("Die Eingabe war ungültig, bitte versuchen Sie es erneut");
                menu();
            }
        }
    }
}