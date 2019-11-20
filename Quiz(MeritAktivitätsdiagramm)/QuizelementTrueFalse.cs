using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementTrueFalse : Quizelement
    {
        public Boolean isTrue;

        public override void display()
        {

        }
        public override Boolean checkAnswers(string answer)
        {
            return true;
        }
    }
}