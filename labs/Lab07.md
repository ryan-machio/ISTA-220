using System;

namespace Classes
{ // allocates space on stack
    class Program //class namespace Program, a class is a type of program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Point anotherPoint = new Point(1, 1);
            Point anotherPoint2 = new Point(4, 5);
            distance = anotherPoint.DistanceTo(anotherPoint2);
            Console.WriteLine($"Distance is: {distance}");
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args) //static means the program cannot be instantiated, in this case the method main.  void means there is no return type, main is the name of the method
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

using System;

namespace Classes
{
    class Point
    {
        private int x = 0;
        private int y = 0;
        private static int objectCount = 0;
        public Point()
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }

        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}
