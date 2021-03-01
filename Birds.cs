using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    internal abstract class Birds 
    {
        protected abstract int MaxLifespan();
        protected bool isAlive = true;
        internal bool IsAlive { get => isAlive; private set { } }
        
        internal void Kill()
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
        
        internal void CelebrateBirthday()
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
        internal int Age
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
