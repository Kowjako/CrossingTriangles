namespace Library10
{
    /* Functionality of our program */
    public class Functionality
    {
        public static Triangle newTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return new Triangle(x1, y1, x2, y2, x3, y3);
        }
        public static int comapreTriangles(Triangle tmp1, Triangle tmp2)
        {
            return tmp1.CompareTo(tmp2);
        }
        public static bool checkIfCoveredByAnother(Triangle t1, Triangle t2)
        {
            //t1 - его точки проверяем на принадлежность к t2   
            bool test1 = isPointInsideTriangle(t1.vertex1, t2);
            bool test2 = isPointInsideTriangle(t1.vertex2, t2);
            bool test3 = isPointInsideTriangle(t1.vertex3, t2);
            if (test1 || test2 || test3) return true;
            return false;
        }
        private static bool isPointInsideTriangle(Point p1,Triangle t1)
        {
            int vector1 = (t1.vertex1.x - p1.x) * (t1.vertex2.y - t1.vertex1.y) - (t1.vertex2.x - t1.vertex1.x) * (t1.vertex1.y - p1.y);
            int vector2 = (t1.vertex2.x - p1.x) * (t1.vertex3.y - t1.vertex2.y) - (t1.vertex3.x - t1.vertex2.x) * (t1.vertex2.y - p1.y);
            int vector3 = (t1.vertex3.x - p1.x) * (t1.vertex1.y - t1.vertex3.y) - (t1.vertex1.x - t1.vertex3.x) * (t1.vertex3.y - p1.y);
            if ((vector1 > 0 && vector2 > 0 && vector3 > 0) || (vector1 < 0 && vector2 < 0 && vector3 < 0)) return true;
            return false;
        }
    }
}
