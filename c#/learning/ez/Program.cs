using System;

class Program
{
    static string ToBin(Int64 dec, Int64 b)
    {
        string s = "";
        while (dec > 0)
        {
            s = dec % b + s;
            dec /= b;
        }
        return s;
    }

    static void Main(string[] args)
    {
        Console.Write("Please insert un number: ");
        string Input = Console.ReadLine();
        string trimmed = Input.Trim();
        Int64 num;
        if (Int64.TryParse(trimmed, out num))
        {
            for (int b = 2; b <= 9; b++)
            {
                string s = ToBin(num, b);
                Console.WriteLine("COnverted \"{0}\" to {1} using base {2}" , Input, s, b);
            }
        }
        else
        {
            Console.WriteLine("Input \"{0}\" is not a valid number." , Input);
        }
       
    }
}