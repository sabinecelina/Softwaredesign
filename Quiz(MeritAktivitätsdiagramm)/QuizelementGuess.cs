using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementGuess : Quizelement
    {
        public float tolerance; 
        public float correctAnswer;
        public override void display()
        {

        }
        public override Boolean checkAnswers(string answer)
        {
            return true;
        }
    }
}
