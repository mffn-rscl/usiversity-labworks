using System;

public class TBall : TDisk
{
    private double ZCenter;

    public TBall(double r, double xCenter, double yCenter, double zCenter) 
        : base(r, xCenter, yCenter)
    {
        this.ZCenter = zCenter;
    }

    public override string ToString()
    {
        return $"TBall: Center=({XCenter}, {YCenter}, {ZCenter}), Radius={R}";
    }

    public double Volume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
    }
}
