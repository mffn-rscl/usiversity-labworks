using System;

public class ClientProgram
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select class to test:");
            Console.WriteLine("1. ArithmeticProgression");
            Console.WriteLine("2. TDisk");
            Console.WriteLine("3. TBall");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    TestArithmeticProgression();
                    break;
                case "2":
                    TestTDisk();
                    break;
                case "3":
                    TestTBall();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    private static void TestArithmeticProgression()
    {
        Console.Write("Enter first term: ");
        double firstTerm = double.Parse(Console.ReadLine());
        
        Console.Write("Enter common difference: ");
        double commonDiff = double.Parse(Console.ReadLine());
        
        var progression = new ArithmeticProgression(commonDiff, firstTerm);

        Console.Write("Enter index to get term: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"Term at index {index}: {progression[index]}");

        Console.Write("Enter number of terms for sum: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum of first {n} terms: {progression.ProgressionSum(n)}");
        progression.Out(n);
    }

    private static void TestTDisk()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Enter X center: ");
        double xCenter = double.Parse(Console.ReadLine());

        Console.Write("Enter Y center: ");
        double yCenter = double.Parse(Console.ReadLine());

        var disk = new TDisk(radius, xCenter, yCenter);
        Console.WriteLine($"Disk: {disk}");
        Console.WriteLine($"Area: {disk.Square()}");

        Console.Write("Enter point X: ");
        double xPoint = double.Parse(Console.ReadLine());

        Console.Write("Enter point Y: ");
        double yPoint = double.Parse(Console.ReadLine());

        Console.WriteLine($"Point ({xPoint}, {yPoint}) inside disk? {disk.IsPointInside(xPoint, yPoint)}");

        Console.Write("Enter scale factor for radius: ");
        double factor = double.Parse(Console.ReadLine());

        var scaledDisk = disk * factor;
        Console.WriteLine($"Scaled disk: {scaledDisk}");
    }

    private static void TestTBall()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Enter X center: ");
        double xCenter = double.Parse(Console.ReadLine());

        Console.Write("Enter Y center: ");
        double yCenter = double.Parse(Console.ReadLine());

        Console.Write("Enter Z center: ");
        double zCenter = double.Parse(Console.ReadLine());

        var ball = new TBall(radius, xCenter, yCenter, zCenter);
        Console.WriteLine($"Ball: {ball}");
        Console.WriteLine($"Volume: {ball.Volume()}");

        Console.Write("Enter scale factor for radius: ");
        double factor = double.Parse(Console.ReadLine());

        var scaledBall = ball * factor;
        Console.WriteLine($"Scaled ball: {scaledBall}");
    }
}
