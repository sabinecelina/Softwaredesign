using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Answer
    {
        public string text;
        public Boolean isTrue;

        public Answer(bool isTrue, string text)
        {
            this.isTrue = isTrue;
            this.text = text;
        }
    }
}