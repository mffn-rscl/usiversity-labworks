using NUnit.Framework;

[TestFixture]
public class TDiskTests
{
    [Test]
    public void TestSquare()
    {
        var disk = new TDisk(3, 0, 0);
        Assert.AreEqual(Math.PI * 9, disk.Square(), 1e-10);
    }

    [Test]
    public void TestIsPointInside()
    {
        var disk = new TDisk(5, 0, 0);
        Assert.IsTrue(disk.IsPointInside(3, 4));   
        Assert.IsFalse(disk.IsPointInside(6, 8));  
    }

    [Test]
    public void TestMultiplicationOperator()
    {
        var disk = new TDisk(2, 0, 0);
        var result = disk * 3;
        Assert.AreEqual(6, result.R);  
    }
}
