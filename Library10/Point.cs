using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library10
{
    /*Representation of specific point*/
    public class Point
    {
        protected internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; set; }
        public int y { get; set; }
        public override string ToString()
        {
            return $"x= {x}, y= {y}";
        }
    }
}
