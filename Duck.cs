using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Duck : Birds, IFlyable, ISwimable
    {
        public LOVE Relationships()
        {
            return LOVE.POLY;
        }

        public Duck(int age = 0)
        {
            Age = age;
        }

        public Duck()
        {
            Age = 0;
        }

        protected sealed override int MaxLifespan()
        {
            return 20;
        }

        public void Fly()
        {
            Console.WriteLine("i am flying");
        }

        public void Swim()
        {
            Console.WriteLine("i am swiming");
        }
    }
}
