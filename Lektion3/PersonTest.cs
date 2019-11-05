using System;

public class PersonTest
{
    public static void Main()
    {
        Person one = new Mann { Name = "Müller", Alter = 50 };
        Person two = new Frau { Name = "Dietlere", Alter = 22}; 
        Person three = new Mitarbeiter { Name = "Schleise", Alter = 21}; 
        Person four = new Mann { Name = "Haller", Alter = 25}; 
        Person five = new Mann { Name = "Lustig", Alter = 52}; 
        Person [] persona = {one, two, three, four, five}; 
        for(int i = 0; i<persona.Length; i++)
        {
                    Console.WriteLine(persona[i].GetAnrede());
        }
        
    }
}