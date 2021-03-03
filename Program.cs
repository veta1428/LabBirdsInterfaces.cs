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
            Hen h = new Hen(7);
            Duck donald = new Duck(3);
            Eagle e = new Eagle(5);

            Birds[] array = { (Birds)p, (Birds)h, (Birds)donald, (Eagle)e };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Age.ToString() + " y.o., now you are celebrating birthday");
                array[i].CelebrateBirthday();
                Console.WriteLine("  now you are " + array[i].Age.ToString());
            }
            ISwimable[] arr = { p, donald };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Swim();
            }

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("You ask if you are alive: ...");
            Console.WriteLine(p.IsAlive);
            Console.Write("So you died at the age of ");
            Console.WriteLine(p.Age);

            Console.ReadKey();
        }
    }
}
