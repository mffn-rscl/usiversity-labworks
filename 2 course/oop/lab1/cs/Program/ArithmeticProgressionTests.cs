using NUnit.Framework;

[TestFixture]
public class ArithmeticProgressionTests
{
    [Test]
    public void TestGetTerm()
    {
        var progression = new ArithmeticProgression(2, 1);
        Assert.AreEqual(1, progression.GetTerm(1));
        Assert.AreEqual(3, progression.GetTerm(2));
        Assert.AreEqual(5, progression.GetTerm(3));
    }

    [Test]
    public void TestIndexer()
    {
        var progression = new ArithmeticProgression(3, 2);
        Assert.AreEqual(2, progression[1]);
        Assert.AreEqual(5, progression[2]);
        Assert.AreEqual(8, progression[3]);
    }

    [Test]
    public void TestProgressionSum()
    {
        var progression = new ArithmeticProgression(1, 2);
        Assert.AreEqual(15, progression.ProgressionSum(5));
    }
}
