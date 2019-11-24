using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizelementMultipleChoice : Quizelement
    {
        public List<Answer> answer = new List<Answer>();
        public QuizelementMultipleChoice(string question, List<Answer> answers)
        {
            this.question = question;
            this.answer = answers;
        }
        public override void display()
        {
            Console.WriteLine(question);
            Console.WriteLine("You have several correct answers. Please enter your answers like: xx,xx");
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(i + ". " + answer[i].text);
            }
        }
        public override Boolean checkAnswers(string answers)
        {
            bool save = false;
            string[] number = answers.Split(',');
            foreach (Answer allanswers in answer)
            {
                if (answers == allanswers.text)
                    save = true;
                else
                    save = false;
            }
            return save;
        }
    }
}
