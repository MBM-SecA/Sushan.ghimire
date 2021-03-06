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
}