using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bitte einen kleinen Satz eingeben");
            //Console.Write("> ");
            string text = "Ich liebe Käse";
            string letters = ReverseLetters(text);
            //string words = ReverseWords(text);
            //string sentence = ReverseSentence(text);
            Console.WriteLine(text + "\n" + sentence + "\n" + words + "\n" + letters);
        }

        static string ReverseLetters(string text)
        {
            // I create an array with chars of the sentence in it and reverse the array with the c# function: Reverse

            char [] letters = text.ToCharArray();
            Array.Reverse(letters);
            return new String(letters);
        }
                static string ReverseWords(string text)
        {
            //I create a string array, split every word when it has a blank and reverse the array with the function: Reverse

            string [] words = text.Split(" ");
            Array.Reverse(words);

            //convert array to string with string.join

            string wordsreversed = string.Join(" ", words);
            return wordsreversed;
        }
        
        static string ReverseSentence(string text)
        {
            //first I reverse the letters than i reverse the words

            text = ReverseLetters(text);
            return ReverseWords(text);
        }

}