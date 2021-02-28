using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal enum LOVE
    {
        POLY, MONO
    }

    internal sealed class Penguin : Birds, ISwimable
    {

        public LOVE Relationships()
        {
            return LOVE.MONO;
        }

        public void Swim()
        {
            Console.WriteLine("i am swiming");
        }

        public Penguin()
        {
            Age = 0;
        }

        public Penguin(int age = 0)
        {
            Age = age;
        }

        protected sealed override int MaxLifespan()
        {
            return 12;
        }
    }
}
