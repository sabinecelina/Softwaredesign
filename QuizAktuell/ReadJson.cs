using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace Quiz
{
    public class ReadJson
    {
        private QuizelementTrueFalse readQuizTrueFalseJson()
        {
            string path = "C:/Json/QuizelementTrueFalseJ.json";
            List<QuizelementTrueFalse> quizList = new List<QuizelementTrueFalse>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                quizList = JsonConvert.DeserializeObject<List<QuizelementTrueFalse>>(json);
            }
            return quizList;
        }
        private void readQuizGuessJson()
        {
            string path = "C:/Json/QuizelementGuessJ.json";
            List<QuizelementGuess> quizList = new List<QuizelementGuess>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                quizList = JsonConvert.DeserializeObject<List<QuizelementGuess>>(json);
            }

            foreach (QuizelementGuess element in quizList)
            {
                quizelemente.Add(element);
            }
        }
        private void readQuizSingleChoiceJson()
        {
            string path = "C:/Json/QuizelementSingleChoiseJ.json";
            List<QuizelementSingleChoice> quizList = new List<QuizelementSingleChoice>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                quizList = JsonConvert.DeserializeObject<List<QuizelementSingleChoice>>(json);
            }
            foreach (QuizelementSingleChoice element in quizList)
            {
                quizelemente.Add(element);
            }
        }

        void readQuizTextJ()
        {
            string pathText = "C:/Json/QuizelementTextJ.json";
            List<QuizelementText> quizList = new List<QuizelementText>();

            using (StreamReader r = new StreamReader(pathText))
            {
                string json = r.ReadToEnd();
                quizList = JsonConvert.DeserializeObject<List<QuizelementText>>(json);
            }

            foreach (QuizelementText element in quizList)
            {
                quizelemente.Add(element);
            }
        }
    }
}