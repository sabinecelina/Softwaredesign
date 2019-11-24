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
            Console.WriteLine(question);
            Console.WriteLine("You have just one correct answer. Please enter your answer");
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(i + ". " + answer[i].text);
            }
        }
        public override Boolean checkAnswers(string answerone)
        {
            bool save = false;
            for (int i = 0; i < answer.Count; i++)
            {
                if (answerone == this.answer[i].text)
                    save = true;
            }
            return save;
        }
    }
}
