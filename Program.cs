using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decalracion_de_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                 ############## Lucky Cookie ################                  ");
            Console.WriteLine("                 #          Developed by DD2XALPHA          #                  ");
            Console.WriteLine("                 --------------------------------------------                  ");
            //starting randomness :)
            byte[] number = new byte[100];
            Random lucky = new Random();
            lucky.NextBytes(number);
            Random phrase = new Random();
            String[] luckyphrase = { "Never drink at night", "You must get a new love... When? who knows", "Look at the sky and be happy", "You are blessed by ''La rosa de guadalupe''", "Play a videogame, it will make you stress out", "dont worry, waste your money on electronics that you dont need", "Are you seious?, you must be crazy for believe in the lucky" };
            int luckphrIndex = phrase.Next(0, luckyphrase.Length);
            //show randomness .w.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("     Here is your lucky number: {0}", lucky.Next(0, 1000));
            Console.WriteLine(" Here is your lucky phrase: {0}", luckyphrase[luckphrIndex]);
            Console.ReadKey();
            /* So yeah, it is my first C# aplication, maybe it was already done by someone else, but for me is a new
             * thing and looks pretty awesome... it doesn't solve any problem, but, is so funny and cool
             * enjoy */
        }
    }
}
