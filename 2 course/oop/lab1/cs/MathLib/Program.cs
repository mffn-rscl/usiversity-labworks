using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var progression = new ArithmeticProgression(1, 2);
            Console.WriteLine("5-й елемент прогресії: " + progression[5]);
            Console.WriteLine("Сума перших 5 елементів: " + progression.Sum(5));

            var disk = new TDisk(5, 0, 0);
            Console.WriteLine(disk.ToString());
            Console.WriteLine("Площа круга: " + disk.Area());
            Console.WriteLine("Чи точка (3,4) всередині круга? " + disk.IsPointInside(3, 4));

            var ball = new TBall(3, 0, 0, 0);
            Console.WriteLine(ball.ToString());
            Console.WriteLine("Об'єм кулі: " + ball.Volume());
        }
    }
}
