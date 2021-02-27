using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Duck : Birds
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
        
        public sealed override bool IsAbleToFly()
        {
            return true;
        }

        public sealed override bool IsAbleToSwim()
        {
            return true;
        }

        protected sealed override int MaxLifespan()
        {
            return 20;
        }
    }
}
