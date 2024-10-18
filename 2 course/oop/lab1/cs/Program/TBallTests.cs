using NUnit.Framework;

[TestFixture]
public class TBallTests
{
    [Test]
    public void TestVolume()
    {
        var ball = new TBall(3, 0, 0, 0);
        Assert.AreEqual((4.0 / 3.0) * Math.PI * Math.Pow(3, 3), ball.Volume(), 1e-10);
    }

    [Test]
    public void TestToStringOverride()
    {
        var ball = new TBall(2, 1, 1, 1);
        Assert.AreEqual("TBall: Center=(1, 1, 1), Radius=2", ball.ToString());
    }
}
