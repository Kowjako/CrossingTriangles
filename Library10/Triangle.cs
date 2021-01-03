using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library10
{
    public class Triangle : IComparable<Triangle>
    {
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            vertex1 = new Point(x1, y1);
            vertex2 = new Point(x2, y2);
            vertex3 = new Point(x3, y3);
        }
        public Point vertex1 { get; set; }
        public Point vertex2 { get; set; }
        public Point vertex3 { get; set; }
        public int CompareTo(Triangle obj)
        {
            return this.square().CompareTo(obj.square());
        }
        public double square()
        {
            double line1 = lineLength(vertex1, vertex2);
            double line2 = lineLength(vertex2, vertex3);
            double line3 = lineLength(vertex1, vertex3);
            double p = (line1 + line2 + line3) / 2.0;
            return Math.Sqrt(p * (p - line1) * (p - line2) * (p - line3));
        }
        private double lineLength(Point x1, Point x2)
        {
            return Math.Sqrt(Math.Pow(x2.y - x1.y, 2) + Math.Pow(x2.x - x1.x, 2));
        }
    }
}
