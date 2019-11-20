using System;
using System.Collections.Generic;

namespace Quiz
{
    public class AddQuizelement
    {
        public QuizelementText addQuizelementText()
        {
            QuizelementText quizelement = new QuizelementText();
            Console.WriteLine("Please enter your Question: ");
            Console.WriteLine("> ");
            quizelement.question = Console.ReadLine();
            Console.WriteLine("Please enter the right answer");
            var correctAnswer = Console.ReadLine();
            quizelement.answer = new Answer(true, correctAnswer);
            return quizelement;
        }
        public QuizelementTrueFalse addQuizelementTrueFalse()
        {
            QuizelementTrueFalse quizelement = new QuizelementTrueFalse();
            Console.WriteLine("Please enter your Question: ");
            Console.WriteLine("> ");
            quizelement.question = Console.ReadLine();
            Console.WriteLine("Please enter: Y if the answer is correct and N if not");
            var userinput = Console.ReadLine();
            if (userinput == "Y")
                quizelement.isTrue = true;
            else if (userinput == "N")
                quizelement.isTrue = false;
            return quizelement;
        }
        public QuizelementGuess addQuizelementGuess()
        {
            QuizelementGuess quizelement = new QuizelementGuess();
            Console.WriteLine("Please enter your Question: ");
            Console.WriteLine("> ");
            quizelement.question = Console.ReadLine();
            Console.WriteLine("Please enter the correct answer: x.xx ");
            Console.WriteLine("> ");
            var text = Console.ReadLine();
            float answer = float.Parse(text);
            Console.WriteLine("Please enter the tolerance beetween 0-1");
            Console.WriteLine("> ");
            var text2 = Console.ReadLine();
            float tolerance = float.Parse(text2);
            quizelement.tolerance = tolerance;
            return quizelement;
        }
        public QuizelementMultipleChoice addQuizelementMultipleChoice()
        {
            QuizelementMultipleChoice quizelement = new QuizelementMultipleChoice();
            List<Answer> answers = new List<Answer>();
            Answer correctanswer = new Answer(false, "");
            Answer wronganswer = new Answer(false, "");
            Console.WriteLine("Please enter your question");
            Console.WriteLine("> ");
            quizelement.question = Console.ReadLine();
            Console.WriteLine("Please enter the correct Answer");
            for (int i = 0; i < 5; i++)
            {
                Answer correctanswers = new Answer(false, "");
                Console.WriteLine("Please enter a new correct answer or save the quizelement with: quit");
                correctanswers.text = Console.ReadLine();
                correctanswers.isTrue = false;
                if (correctanswers.text == "quit")
                    break;
                else
                    answers.Add(correctanswers);
            }
            correctanswer.text = Console.ReadLine();
            correctanswer.isTrue = true;
            answers.Add(correctanswer);
            Console.WriteLine("Please enter a false answer");
            wronganswer.text = Console.ReadLine();
            wronganswer.isTrue = false;
            answers.Add(wronganswer);
            for (int i = 0; i < 5; i++)
            {
                Answer wronganswers = new Answer(false, "");
                Console.WriteLine("Please enter a new false answer or save the quizelement with: quit");
                wronganswers.text = Console.ReadLine();
                wronganswers.isTrue = false;
                if (wronganswers.text == "quit")
                    break;
                else
                    answers.Add(wronganswer);
            }
            quizelement.answer = answers;
            return quizelement;
        }
        public QuizelementSingleChoice addQuizelementSingleChoice()
        {
            QuizelementSingleChoice quizelement = new QuizelementSingleChoice();
            List<Answer> answers = new List<Answer>();
            Answer correctanswer = new Answer(false, "");
            Answer wronganswer = new Answer(false, "");
            Console.WriteLine("Please enter your question");
            Console.WriteLine("> ");
            quizelement.question = Console.ReadLine();
            Console.WriteLine("Please enter the correct Answer");
            correctanswer.text = Console.ReadLine();
            correctanswer.isTrue = true;
            answers.Add(correctanswer);
            Console.WriteLine("Please enter a false answer");
            wronganswer.text = Console.ReadLine();
            wronganswer.isTrue = false;
            answers.Add(wronganswer);
            for (int i = 0; i < 5; i++)
            {
                Answer wronganswers = new Answer(false, "");
                Console.WriteLine("Please enter a new false answer or save the quizelement with: quit");
                wronganswers.text = Console.ReadLine();
                wronganswers.isTrue = false;
                if (wronganswers.text == "quit")
                    break;
                else
                    answers.Add(wronganswer);
            }
            quizelement.answer = answers;
            return quizelement;
        }
    }
}
