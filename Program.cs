using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            Penguin p = new Penguin(10);
            Console.WriteLine("10 y o penguin!");
            Console.Write("Celebration of 11th birthday! Now you are ");
            p.CelebrateBirthday();

            Console.WriteLine(p.Age);
            Console.Write("Celebration of 12th birthday! Now you are ");
            p.CelebrateBirthday();
            Console.WriteLine(p.Age);
            try
            {
                Console.WriteLine("You try to celebrate your 13th birthday...");
                p.CelebrateBirthday();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Write("You ask if you are alive: ...");
            Console.WriteLine(p.IsAlive);
            Console.Write("So you died at the age of ");
            Console.WriteLine(p.Age);

            Console.ReadKey();
        }
    }
}
