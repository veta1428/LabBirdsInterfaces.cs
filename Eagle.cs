using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Eagle : Birds, IFlyable
    {
        public override sealed LOVE Relationship()
        {
            return LOVE.POLY;
        }

        public Eagle(int age = 0): base (age)
        {

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
