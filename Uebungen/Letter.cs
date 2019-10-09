public class Letter 
{
    static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen kleinen Satz eingeben");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = reverseLetters(text);
            string words = reverseWords(text);
            string sentence = reverseSentence(text);
            Console.WriteLine(sentence + "\n" + words + "\n" + letters);
        }
    public string reverseLetters(string text)
    {
        return text.Reverse();
    }

    public string reverseWords()
    {
        
    }

}