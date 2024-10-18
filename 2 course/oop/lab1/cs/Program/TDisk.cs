using System;

public class TDisk
{
    protected double R;
    protected double XCenter;
    protected double YCenter;

    public TDisk() : this(0, 0, 0) { }

    public TDisk(double r, double xCenter, double yCenter)
    {
        this.R = r;
        this.XCenter = xCenter;
        this.YCenter = yCenter;
    }

    public TDisk(TDisk previousTDisk) : this(previousTDisk.R, previousTDisk.XCenter, previousTDisk.YCenter) { }

    public override string ToString()
    {
        return $"TDisk: Center=({XCenter}, {YCenter}), Radius={R}";
    }

    public double Square()
    {
        return Math.PI * R * R;
    }

    public bool IsPointInside(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x - XCenter, 2) + Math.Pow(y - YCenter, 2));
        return distance <= R;
    }

    public static TDisk operator *(TDisk disk, double factor)
    {
        return new TDisk(disk.R * factor, disk.XCenter, disk.YCenter);
    }

    public static TDisk operator *(double factor, TDisk disk)
    {
        return disk * factor;
    }
}
