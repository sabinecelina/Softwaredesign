using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementTrueFalse : Quizelement
    {
        public Boolean isTrue;
        public QuizelementTrueFalse(string question, bool isTrue)
        {
            this.question = question;
            this.isTrue = isTrue;
        }

        public override void display()
        {
            Console.WriteLine(question);
            Console.WriteLine("Please enter :Y: if the answer is correct and :N: if not");
        }
        public override Boolean checkAnswers(string answer)
        {
            bool save = false;
            bool correct = false;
            if (answer == "Y")
                save = true;
            if (save == true)
                Console.WriteLine("BliBlaBlub");
            if (save == isTrue)
                correct = true;
            if (save == true)
                Console.WriteLine("BliBlaBlubNummer2");
            else if (save == false)
                correct = false;
            if (save == true)
                Console.WriteLine("BliBlaBlubNummer3");
            return correct;
        }
    }
}