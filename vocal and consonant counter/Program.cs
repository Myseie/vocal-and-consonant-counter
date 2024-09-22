using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Skriv in en mening så vi kan räkna konsonanter :");
        string input = Console.ReadLine().ToLower();

        int vowels = 0;
        int consonants = 0;

        string vowelList = "aeiou";

        foreach (char c in input)
        {
            if (vowelList.Contains(c))
            {
                vowels++;
            }
            else if (char.IsLetter(c))
            {
                consonants++;
            }
        }

        Console.WriteLine($"Antal vokaler {vowels}");
        Console.WriteLine($"Antal konsonanter {consonants}");
    }
}