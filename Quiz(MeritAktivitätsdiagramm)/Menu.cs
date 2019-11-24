using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Quiz
{
    public class Menu
    {
        public List<Quizelement> quizelemente = new List<Quizelement>()
        {
            new QuizelementGuess("wie viele Einwohner hat die Mongolei in Millionen??", 3f , 0.2f),
            new QuizelementSingleChoice("Wie viele Weihnachtsbäume werden in Deutschland pro Jahr verkauft?", new List<Answer> {new Answer(true, "10 Millionen"), new Answer(false, "20 Millionen"), new Answer(false, "30 Millionen")}),
            new QuizelementSingleChoice("Welcher deutsche Bundeskanzler erhielt den Friedensnobelpreis?", new List<Answer> {new Answer(true, "Willy Brandt"),new Answer(false,"Konrad Adenauer"), new Answer(false,"Helmut Schmidt"), new Answer(false,"Helmut Kohl")}),
            new QuizelementMultipleChoice("Wer war Franz Kafka?", new List<Answer> {new Answer(true, "Schriftsteller"),new Answer(false,"Sänger"), new Answer(false,"Schauspieler"), new Answer(true,"Mensch")}),
            new QuizelementText("Wie bezeichnet man Briefmarkensammler? ", new Answer(true, "Philatelisten"))
        };
        public int score = 0;
        public static int questionnumber = 0;
        public AddQuizelement addQuizelement = new AddQuizelement();
        public static Menu menumenu = new Menu();

        public static void Main()
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("Please choose beetween: ");
            Console.WriteLine("1. add a new Question");
            Console.WriteLine("2. answer a question");
            Console.WriteLine("3. exit game");
            string number = Console.ReadLine();
            int x = 0;
            x = Int32.Parse(number);
            try
            {
                if (x == 1)
                {
                    menumenu.addQuestion();
                    menu();
                }
                else if (x == 2)
                {
                    menumenu.quizelemente[questionnumber].display();
                    string console = Console.ReadLine();
                    bool check = menumenu.quizelemente[questionnumber].checkAnswers(console);
                    if (check == true)
                    {
                        number += 1;
                        questionnumber += 1;
                        Console.WriteLine("Your Answer is correct!");
                        Console.WriteLine("___________________________ \n");
                    }
                    else
                    {
                        questionnumber += 1;
                        Console.WriteLine("Your Answer is not correct!");
                        Console.WriteLine("___________________________ \n");
                    }
                    Console.WriteLine("your score: " + menumenu.score);
                    Console.WriteLine("previously answered questions:  " + questionnumber);
                    menu();
                }
                else if (x == 3)
                {
                    Debugger.Break();
                }
            }
            catch
            {
                Console.WriteLine("Die Eingabe war ungültig, bitte versuchen Sie es erneut");
                menu();
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
        public void playQuiz()
        {

        }
        public void addQuestion()
        {
            Console.WriteLine("Please choose the quiztype");
            Console.WriteLine("1: Text");
            Console.WriteLine("2: True-False");
            Console.WriteLine("3: Guess");
            Console.WriteLine("4: Multiple answers");
            Console.WriteLine("5: Single answers");
            Console.WriteLine("6: return to menu");
            string number = Console.ReadLine();
            int x = 0;
            x = Int32.Parse(number);
            switch (x)
            {
                case 1:
                    quizelemente.Add(addQuizelement.addQuizelementText());
                    break;
                case 2:
                    quizelemente.Add(addQuizelement.addQuizelementTrueFalse());
                    break;
                case 3:
                    quizelemente.Add(addQuizelement.addQuizelementGuess());
                    break;
                case 4:
                    quizelemente.Add(addQuizelement.addQuizelementSingleChoice());
                    break;
                case 5:
                    quizelemente.Add(addQuizelement.addQuizelementMultipleChoice());
                    break;
                case 6:
                    menu();
                    break;
            }
        }
    }
}
