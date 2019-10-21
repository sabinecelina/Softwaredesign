using System;

namespace NumberSystems
{

    public class NumberSystems
    {
        public static int ConvertDecimalToHexal(int dec)
        {
            int ergebnis = 0; 

            while(dec>5)
            {
                int rest = dec%6; 
                dec = dec/6; 
                ergebnis = rest + ergebnis + (dec*10); 
            }
            return ergebnis;
        }

        public static int ConvertHexalToDecimal(int hexal)
        {
            int ergebnis = 0; 
            while(hexal>9)
            {
            int rest = hexal%10; 
            hexal = hexal/10;
            ergebnis += rest + (hexal*6); 
            }
            return ergebnis;
        }

        public static int ConvertToBaseFromDecimal(int toBase, int dec)
        {
            int ergebnis = 0; 
            while(dec>toBase-1)
            {
                int rest = dec%toBase;
                dec = dec/toBase; 
                ergebnis += rest + (dec*10);
            }
            return ergebnis;
        }

        public static int ConvertToDecimalFromBase(int fromBase, int number)
        {
            int ergebnis = 0; 
            while(number>fromBase-1)
            {
            int rest = number%10;
            number = number/10; 
            ergebnis += rest + (number * fromBase); 
            }
            return ergebnis;
        }
        static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase)
        {
            int dec = ConvertToDecimalFromBase(fromBase, number);

            return ConvertToBaseFromDecimal(toBase, dec);
        }
        public static void Main()
        {
            Console.WriteLine(ConvertDecimalToHexal(15)); 
            Console.WriteLine(ConvertHexalToDecimal(23));
            Console.WriteLine(ConvertToBaseFromDecimal(6,15));
        }
    }
}
