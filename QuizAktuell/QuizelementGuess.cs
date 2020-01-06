using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementGuess : Quizelement
    {
        public float tolerance;
        public float correctAnswer;
        public QuizelementGuess(string question, float tolerance, float correctAnswer)
        {
            this.question = question;
            this.tolerance = tolerance;
            this.correctAnswer = correctAnswer;
        }

        public override void display()
        {
            Console.WriteLine(question);
            Console.WriteLine("Please enter your estimation: ");
        }
        public override Boolean checkAnswers(string answer)
        {
            float userinput = float.Parse(answer);
            float correctanswerWithTolerance = correctAnswer * tolerance;
            float tolerance1 = correctAnswer - correctanswerWithTolerance;
            float tolerance2 = correctAnswer + correctanswerWithTolerance;

            if (userinput == correctAnswer)
                return true;

            else if (userinput >= tolerance1 && userinput <= tolerance2)
            {
                Console.WriteLine("The correct answer is: " + correctAnswer);
                return true;
            }
            else
                return false;
        }
    }
}
