using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Penguin : Birds, ISwimable
    {

        public override sealed LOVE Relationship()
        {
            return LOVE.MONO;
        }

        public void Swim()
        {
            Console.WriteLine("i am swiming");
        }

        public Penguin(int age = 0) : base(age)
        {
            
        }

        protected sealed override int MaxLifespan()
        {
            return 12;
        }
    }
}
