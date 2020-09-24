// Ques: Create a folder "ABC", create 10 sub folders in "ABC". Each subfolder
// should contain a C# file with "Hello World" program.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Directories makeDirectories = new Directories();
        makeDirectories.CreateDirectories();
    }
}

