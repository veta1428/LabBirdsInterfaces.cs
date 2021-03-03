using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal sealed class Hen : Birds
    {
        public override sealed LOVE Relationship()
        {
            return LOVE.POLY;
        }

        public Hen(int age = 0): base(age)
        {

        }

        public Hen()
        {
            Age = 0;
        }

        protected sealed override int MaxLifespan()
        {
            return 18;
        }
    }
}
