using System;
using System.IO;

public class Directories
{
    public void CreateDirectories()
    {
        string directoryName = @"D:\sixth sem\NCC\Lab\Sushan.ghimire\Assignment-2\ABC";
        string subDirectoryName = "Subfolder";
        Directory.CreateDirectory(directoryName);

        string helloWorldProgram = "Hello Wrld";

        for (int i = 1; i <= 10; i++)
        {
            string subDirectory = $"{directoryName}/{subDirectoryName + i}";
            Directory.CreateDirectory(subDirectory);
            string fileName = $"{directoryName}/{subDirectoryName + i}/HelloWorld.txt";
            File.WriteAllText(fileName, helloWorldProgram);
        }
        Console.WriteLine("Created folders and added Hello World program successfully!!");
    }
}