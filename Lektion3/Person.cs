using System;

abstract class Person
{
    public string Name;
    public int Alter;

    public abstract string GetAnrede();

}

class Frau : Person
{
    public override string GetAnrede()
    {
        if (Alter < 18)
        {
            return "Hey " + Name;
        }
        else
            return "Sehr geehrte Frau " + Name;
    }
}
class Mann : Person
{
    public override string GetAnrede()
    {
        if (Alter < 18)
            return "Hey " + Name;
        else
            return "Sehr geehrter Herr " + Name;
    }
}
class Mitarbeiter : Person
{
    public int Personalnummer;

        public override string GetAnrede()
    {
        if (Alter < 18)
            return "Hey " + Name;
        else
            return "Sehr geehrte(r) Herr/Frau " + Name;
    }
}
