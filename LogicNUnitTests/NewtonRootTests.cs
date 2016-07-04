using System;
using NUnit.Framework;
using Logic;

namespace LogicNUnitTests
{
  [TestFixture]
  class NewtonRootTests
  {
    [TestCase(8,3,0.001)]
    [TestCase(8,1,0.001)]
    [TestCase(0,1,0.001)]
    [TestCase(8,1,2,ExpectedException =typeof(ArgumentException))]
    [TestCase(8, 1, -2, ExpectedException = typeof(ArgumentException))]
    [TestCase(8, 0, 0.1, ExpectedException = typeof(ArgumentException))]
    public void RootTest(double value, int power, double acuracy)
    {
      double excepted = Math.Pow(value, 1.0 / power);
      double actual = NewthonRoot.Root(value, power, acuracy);
      Assert.AreEqual(excepted, actual, acuracy);
    }
  }
}
