using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;


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
        public static int score = 0;
        public static int questionnumber = 0;
        public AddQuizelement addQuizelement = new AddQuizelement();
        public static Menu menumenu = new Menu();

        public static void Main()
        {
            menu();
        }
        public void QuizelementQuestion()
        {

        }
        public static void menu()
        {
            Console.WriteLine("Please choose beetween: ");
            Console.WriteLine("Press 1 to play the quiz");
            Console.WriteLine("Press two to add a quizelement");
            Console.WriteLine("Press three to exit the game");
            string number = Console.ReadLine();
            int x = 0;
            x = Int32.Parse(number);
            try
            {
                if (x == 1)
                {
                    menumenu.playQuiz();
                    Console.WriteLine("If you want to continue the quiz press 1, if you want to go back to the menu press 2");
                    Console.WriteLine("> ");
                    var text = Console.ReadLine();
                    int numberfromtext = Int32.Parse(text);
                    if (numberfromtext == 1)
                        menumenu.playQuiz();
                    else if (numberfromtext == 2)
                        menu();
                }
                else if (x == 2)
                {
                    menumenu.addQuestion();
                    menu();
                }
                else if (x == 3)
                {
                    Debugger.Break();
                }
            }
            catch
            {
                Console.WriteLine("invalid input,  please try it again");
                menu();
            }
        }
        public void playQuiz()
        {
            menumenu.quizelemente[questionnumber].display();
            string console = Console.ReadLine();
            bool check = menumenu.quizelemente[questionnumber].checkAnswers(console);
            if (check == true)
            {
                score += 1;
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
            Console.WriteLine("your score: " + score);
            Console.WriteLine("previously answered questions:  " + questionnumber);
            Console.WriteLine("___________________________ \n");
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
