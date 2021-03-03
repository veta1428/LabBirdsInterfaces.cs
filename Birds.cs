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

    internal abstract class Birds 
    {
        protected abstract int MaxLifespan();
        protected bool isAlive = true;
        public bool IsAlive { get => isAlive; private set { } }

        public abstract LOVE Relationship();
        public void Kill()
        {
            if (isAlive == true)
            {
                isAlive = false;
            }
            else
            {
                throw new Exception("already dead");
            }
        }

        public Birds(int age = 0)
        {
            Age = age;
        }

        public void CelebrateBirthday()
        {
            if (isAlive == false)
            {
                throw new Exception("the dead cannot celebrate birthday");
            }
            else if (Age >= MaxLifespan())
            {
                Kill();
            }
            else
            {
                Age++;
            }
        }
        protected int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("incorrect age: you have never been born");
                }
                else if (value > MaxLifespan())
                {
                    throw new Exception("incorrect age: you are dead");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
