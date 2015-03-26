using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string path = "C:\\hello\\world";
        string newText = path.Substring(path.LastIndexOf('\\') + 1);


        Console.WriteLine(newText);

        Console.WriteLine("Done!");
        Console.ReadLine();
    }
}