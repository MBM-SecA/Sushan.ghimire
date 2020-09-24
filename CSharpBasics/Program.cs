using System.IO;
using System.Linq;
using System;
using LearnCollections;

public class Program
{
    static void Main()
    {
        // // Main program for collection:
        // Collections collections = new Collections();
        // collections.LearnDictionary();



        // // Main program for Inheritence:
        // var square = new Square(5.5);
        // square.Display();
        // square.GetDiagonal();
        
        // var rectangle = new Rectangle(5.5, 2.5);
        // rectangle.Display();


        // Main program for FileIO:
        // FileIO fileIO = new FileIO();
        // fileIO.LearnDirectories();


        // // Main program for listing countires whose name starts with N
        // string countriesText = File.ReadAllText("Countries.txt");
        // string[] countries = countriesText.Split("\r\n");

        // var countriesWithNInitial = countries.Where(x => x.StartsWith("N")).Select(x => x);
        // foreach (var country in countriesWithNInitial)
        // {
        //     Console.WriteLine(country);
        // }


        // Main program for creating  directories question
        FileIO makeDirectories = new FileIO();
        makeDirectories.CreateDirectories();
    }
}