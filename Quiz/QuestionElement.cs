using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuestionElement
{
    public string question = "";
    public List<string> wrongAnswers = new List<string>();
    public string correctAnswer = "";

    public QuestionElement(string question, string correctAnswer, List<string> wrongAnswers)
    {
        this.question = question;
        this.correctAnswer = correctAnswer;
        this.wrongAnswers = wrongAnswers;
    }
}