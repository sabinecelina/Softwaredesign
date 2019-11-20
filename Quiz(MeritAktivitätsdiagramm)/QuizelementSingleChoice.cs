using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementSingleChoice : Quizelement
    {
        public List<Answer> answer = new List<Answer>();

        public QuizelementSingleChoice(string question, List<Answer> answers)
        {
            this.question = question; 
            this.answer = answers;
        }
        public override void display()
        {

        }
        public override Boolean checkAnswers(string answer)
        {
            return true;
        }
    }
}
