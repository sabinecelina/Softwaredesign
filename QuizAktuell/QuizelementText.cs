using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementText : Quizelement
    {
        public Answer answer;

        public QuizelementText(string question, Answer answer)
        {
            this.question = question;
            this.answer = answer;
        }
        public override void display()
        {
            Console.WriteLine(question);
            Console.WriteLine("Please enter the correct answer - pay attention to uppercase, lowercase and space");
        }
        public override Boolean checkAnswers(string answer)
        {
            if (answer == this.answer.text)
                return true;
            else
                return false;
        }
    }
}
