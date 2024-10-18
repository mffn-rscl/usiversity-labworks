using System;

public class ArithmeticProgression
{
    private double CommonDifference;
    private double FirstTerm;

    public ArithmeticProgression(double commonDifference, double FirstTerm)
    {
        this.CommonDifference = commonDifference;
        this.FirstTerm = FirstTerm;
    }

    public double this[int index]
    {
        get { return GetTerm(index); }
    }

    public double GetTerm(int index)
    {
        return FirstTerm + (index - 1) * CommonDifference;
    }

    public double ProgressionSum(int n)
    {
        return (n / 2.0) * (2 * FirstTerm + (n - 1) * CommonDifference);
    }

    public void Out(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(this[i] + " ");
        }
        Console.WriteLine();
    }
}
