using System;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string a, char b, int c)
        {
            string decor = new string(b, c);
            return $"{decor} {a} {decor}";
        }

        private static void Main(string[] args)
        {
            string str = args[0];
            char Char = char.Parse(args[1]);
            Console.WriteLine(Decor(str,Char,int.Parse(args[2])));
        }

    }
}
