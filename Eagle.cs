using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Eagle : Birds
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

        public sealed override bool IsAbleToFly() //has it any sense to mark this method as sealed?
        {
            return true;
        }

        public sealed override bool IsAbleToSwim()
        {
            return false;
        }

        protected sealed override int MaxLifespan()
        {
            return 65;
        }
    }
}
