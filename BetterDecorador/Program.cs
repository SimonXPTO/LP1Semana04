using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Primary method.
        /// Print the output of the string decorated.
        /// Takes numerous arguments. 
        /// Converts them to the desired type.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if (args.Length==3)
            {
                string str = args[0];
                char Char = char.Parse(args[1]);
                Console.WriteLine(Decor(str,Char,int.Parse(args[2])));
            }
            else
            {
                Console.WriteLine(Decor());
            }
        }

        /// <summary>
        /// This method takes 3 arguments, a string, a char and a int, converts them to string, decorates a string using the multiplied character.
        /// </summary>
        /// <param name="s">String that is being decorated</param>
        /// <param name="dec">Char who is decorating the string</param>
        /// <param name="count">multiplies the char</param>
        /// <returns>Decorated String</returns>
        private static string Decor(string s, char dec, int count)
        {
            string decor = new string(dec, count);
            return $"{decor} {s} {decor}";
        }

        /// <summary>
        /// This method uses the method Decor using this arguments Decor("User did not specify args !", '=', 3)
        /// </summary>
        /// <returns>=== User did not specify args! ===</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
