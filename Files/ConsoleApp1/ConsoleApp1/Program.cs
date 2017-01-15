using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Writing test file.");
        File.WriteAllText("./testing.txt", "This is a file write test");
    }
}