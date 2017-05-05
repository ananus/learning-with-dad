using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert un number: ");
        string Input = Console.ReadLine();
        Int64 num = Int64.Parse(Input.Trim());
        string s=""; 
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                s = "0" + s;
            }
            else
            {
                s = "1" + s;
            }
            num /= 2;
        }
        Console.WriteLine(s);
    }
}