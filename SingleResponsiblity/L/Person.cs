using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblity.L
{
    internal abstract class Person
    {
        public virtual void AboutMe()
        {
            Console.WriteLine("I am person");
        }
    }
}
