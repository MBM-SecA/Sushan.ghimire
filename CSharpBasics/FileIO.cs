using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        //string fileContent = File.ReadAllText(@"D:\sixth sem\NCC\Lab\Sushan.ghimire\Readme.txt"); //@ is used to remove escape sequence. Can also use double slash(//)
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {
            string fileContent = File.ReadAllText("Iterion.cs");
            Console.WriteLine(fileContent);
        }

        File.WriteAllText(fileName, "This is just a text file");
    }

    public void LearnFileInfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"File size: {size} bytes");
        Console.WriteLine($"Created Date: {createdDate}");
    }

    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName); // makes a new directory
    }

    // Ques: Create a folder "ABC", create 10 sub folders in "ABC". Each subfolder
    // should contain a C# file with "Hello World" program.

    public void CreateDirectories()
    {
        string directoryName = @"D:\sixth sem\NCC\Parent";
        string subDirectoryName = "Subfolder";
        Directory.CreateDirectory(directoryName);

        string helloWorldProgram = File.ReadAllText(@"D:\sixth sem\NCC\Lab\Sushan.ghimire\Assignment-1\HelloWorld.cs");

        for (int i = 1; i <= 10; i++)
        {
            string subDirectory = $"{directoryName}/{subDirectoryName+i}";
            Directory.CreateDirectory(subDirectory);
            string fileName = $"{directoryName}/{subDirectoryName+i}/HelloWorld.cs";
            File.WriteAllText(fileName, helloWorldProgram);
        }
        Console.WriteLine("Created folders and files successfully!!");
    }
}