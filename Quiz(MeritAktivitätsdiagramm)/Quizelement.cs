using System;
using System.Collections.Generic;

namespace Quiz
{
    public abstract class Quizelement
    {
        public string question;
        public abstract void display();
        public abstract Boolean checkAnswers(string answer);

    }
}