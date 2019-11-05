using System;

namespace TicTacToe
{
    public class TicTacToe
    {
        public static string[,] playfield = new string[,] { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };
        public static int player = 1;
        public static void generatePlayfield()
        {
            Console.WriteLine(playfield[0, 0] + playfield[0, 1] + playfield[0, 2]);
            Console.WriteLine(playfield[1, 0] + playfield[1, 1] + playfield[1, 2]);
            Console.WriteLine(playfield[2, 0] + playfield[2, 1] + playfield[2, 2]);
            Console.WriteLine("______________________________________________");

        }
        public static void play()
        {
            Console.WriteLine("Bitte nächsten Zug eingeben (Position zeile.spalte)");
            Console.Write("> ");
            string zahl = Console.ReadLine();
            string[] number = zahl.Split(".");
            int reihe = Int32.Parse(number[0]) - 1;
            int spalte = Int32.Parse(number[1]) - 1;

            generatePlayfield();

            try
            {
                if (player == 1 && playfield[reihe, spalte] == "-")
                {
                    playfield[reihe, spalte] = "x";
                    player = 2;
                    generatePlayfield();
                    player = 2;
                    getWinner();
                    play();
                }
            }
            catch
            {
                Console.WriteLine("Ungültiger Zug, bitte erneut eingeben");
                play();
            }
            try
            {

                if (player == 2 && playfield[reihe, spalte] == "-")
                {
                    playfield[reihe, spalte] = "o";
                    generatePlayfield();
                    player = 1;
                    getWinner();
                    play();
                }
            }
            catch
            {
                Console.WriteLine("Ungültiger Zug, bitte erneut eingeben");
                play();
            }
        }

        public static void getWinner()
        {

            if (playfield[0, 0] == "x" && playfield[0, 1] == "x" && playfield[0, 2] == "x" || playfield[1, 0] == "x" && playfield[1, 1] == "x" && playfield[1, 2] == "x" || playfield[2, 0] == "x" && playfield[2, 1] == "x")
            {
                Console.WriteLine(player + " is Winner");
            }
            else if (playfield[0, 0] == "o" && playfield[0, 1] == "o" && playfield[0, 2] == "o" || playfield[1, 0] == "o" && playfield[1, 1] == "o" && playfield[1, 2] == "o" || playfield[2, 0] == "o" && playfield[2, 1] == "o")
            {
                Console.WriteLine(player + " is Winner");
            }
        }
        public static void Main()
        {
            generatePlayfield();
            play();
        }
    }
}