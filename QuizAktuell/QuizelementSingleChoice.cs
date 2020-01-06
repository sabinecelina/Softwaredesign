using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Console.WriteLine("You have just one correct answer. Please enter the correct number");
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(i + ". " + answer[i].text);
            }
        }
        public override Boolean checkAnswers(string answerone)
        {
            bool save = false;
            string[] text = answerone.Split(',');
            int[] number = new int[] { };
            for (int i = 0; i < number.Count(); i++)
            {
                number[i] = Int32.Parse(text[i]);
            }
            for (int i = 0; i < number.Count(); i++)
            {
                if (answer[number[i - 1]].isTrue == true)
                    save = true;
                else
                    save = false;
            }
            return save;
        }
    }
}
