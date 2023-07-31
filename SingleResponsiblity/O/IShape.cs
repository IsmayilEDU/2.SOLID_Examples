using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblity.O
{
    internal interface IShape
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }
    }
}
