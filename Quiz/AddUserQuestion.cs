using System;
using System.Collections.Generic;

namespace Quiz
{
    public class AddUserQuestion
    {
        List<QuestionElement> questionelement = new List<QuestionElement>();
        public QuestionElement addUserQuestion()
        {
            Console.WriteLine("Quizelement erstellen");
            Console.WriteLine("Bitte gib eine Frage ein");
            Console.WriteLine("> ");
            var question = Console.ReadLine();
            Console.WriteLine("Bitte gib die richtige Antwort ein");
            var correctAnswer = Console.ReadLine();
            Console.WriteLine("Bitte gib eine falsche Antwort ein");
            var wrongAnswer = Console.ReadLine();
            List<string> wrongAnswers = new List<string>();
            wrongAnswers.Add(wrongAnswer);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bitte gib wieder eine falsche Antwort ein oder beende das Programm, indem du die: beenden schreibst.");
                var text = Console.ReadLine();
                if (text == "beenden")
                    break;
                else
                    wrongAnswers.Add(text);
            }
            QuestionElement quizelemente = new QuestionElement(question, correctAnswer, wrongAnswers);
            questionelement.Add(quizelemente);
            return quizelemente;
        }
    }
}