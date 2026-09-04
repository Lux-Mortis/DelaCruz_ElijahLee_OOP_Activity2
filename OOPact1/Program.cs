using System;
using System.Collections.Generic;

class Program
{   
    static void Main(string[] args)
    {
        List<String> videogames = new List<string>();

        Console.WriteLine("Enter New Game to folder");

        Console.Write("What game do you wish to add to folder?: ");

        string newGame = Console.ReadLine();

        videogames.Add("Minecraft");
        videogames.Add("Valorant");
        videogames.Add(newGame);

        foreach (String item in videogames)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"There are {videogames.Count} videogames in folder");

        Console.ReadKey();
    }
}
