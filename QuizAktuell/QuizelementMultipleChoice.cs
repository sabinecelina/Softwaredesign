using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
                Console.WriteLine((i + 1) + ". " + answer[i].text);
            }
        }
        public override Boolean checkAnswers(string answers)
        {
            bool save = false;
            string[] text = answers.Split(',');
            int[] number = new int[] { };
            for (int i = 0; i < number.Count(); i++)
            {
                number[i] = Int32.Parse(text[i]);
            }
            for (int i = 0; i < number.Count(); i++)
            {
                foreach (Answer allanswers in answer)
                {

                    if (answer[number[i - 1]].isTrue == true)
                        save = true;
                    else
                        save = false;
                }
            }
            return save;
        }
    }
}
