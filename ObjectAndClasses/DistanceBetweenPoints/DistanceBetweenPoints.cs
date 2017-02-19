namespace DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointCordinate = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var first = new Point
            {
                X = firstPointCordinate[0],
                Y = firstPointCordinate[1]
            };

            var secondPointCordinate = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var second = new Point
            {
                X = secondPointCordinate[0],
                Y = secondPointCordinate[1]
            };
            var result = CalculateDistance(first, second);
            Console.WriteLine(result.ToString("0.000"));
        }

        public static double CalculateDistance(Point fistPoint, Point secondPoint)
        {
            var diffX = fistPoint.X - secondPoint.X;
            var diffY = secondPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX+ powY);
        }
    }
}
