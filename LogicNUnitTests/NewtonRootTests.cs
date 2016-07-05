using System;
using NUnit.Framework;
using Logic;

namespace LogicNUnitTests
{
  /// <summary>
  /// Class consists one method for NUnit testing Root calculation
  /// </summary>
  [TestFixture]
  class NewtonRootTests
  {
    /// <summary>
    /// NUnit test for method calculating Root of value, various cases
    /// </summary>
    /// <param name="value"></param>
    /// <param name="power"></param>
    /// <param name="acuracy"></param>
    [TestCase(8, 3, 0.001)]
    [TestCase(8, 1, 0.001)]
    [TestCase(0, 1, 0.001)]
    [TestCase(8, 1, 2, ExpectedException = typeof(ArgumentException))]
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
