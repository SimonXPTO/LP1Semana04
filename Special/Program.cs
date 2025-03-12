using System;

namespace Special
{
    public class Program
    {
        private static int GetSpecial(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return  1;
            }
            else
            {   
                return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
            }
        }
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }
    }
}
