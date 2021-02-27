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

    internal sealed class Penguin : Birds
    {

        public LOVE Relationships()
        {
            return LOVE.MONO;
        }

        public Penguin()
        {
            Age = 0;
        }

        public Penguin(int age = 0)
        {
            Age = age;
        }

        public override bool IsAbleToFly()
        {
            return false; 
        }

        public override bool IsAbleToSwim()
        {
            return true;
        }

        protected sealed override int MaxLifespan()
        {
            return 12;
        }
    }
}
