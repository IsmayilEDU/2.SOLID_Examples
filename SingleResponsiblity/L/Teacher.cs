using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblity.L
{
    internal class Teacher : Person
    {
        public override void AboutMe()
        {
            Console.WriteLine("I am a teacher");
        }
    }
}
