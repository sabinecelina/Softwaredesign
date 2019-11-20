using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementText : Quizelement
    {
        public Answer answer;

        public override void display()
        {
            Console.WriteLine(question);
            Console.WriteLine("Please enter the correct answer");
        }
        public override Boolean checkAnswers(string answer)
        {
            if (answer == this.answer.text)
            {
                Console.WriteLine("Your Answer is correct!");
                return true;
            }
            else
            {
                Console.WriteLine("Your Answer is not correct!");
                return false;
            }
        }
    }
}
