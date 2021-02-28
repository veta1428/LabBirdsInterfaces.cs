using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Eagle : Birds, IFlyable
    {
        public LOVE Relationships()
        {
            return LOVE.POLY;
        }

        public Eagle()
        {
            Age = 0;
        }

        public Eagle(int age = 0)
        {
            Age = age;
        }

        protected sealed override int MaxLifespan()
        {
            return 65;
        }

        public void Fly()
        {
            Console.WriteLine("i am flying");
        }
    }
}
