using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Hen : Birds
    {
        public LOVE Relationships()
        {
            return LOVE.POLY;
        }

        public Hen(int age = 0)
        {
            Age = age;
        }

        public Hen()
        {
            Age = 0;
        }

        public sealed override bool IsAbleToFly()
        {
            return false;
        }

        public sealed override bool IsAbleToSwim()
        {
            return false;
        }

        protected sealed override int MaxLifespan()
        {
            return 18;
        }
    }
}
