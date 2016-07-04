using NUnit.Framework;
using System;
using Logic;

namespace LogicNUnitTests
{
  [TestFixture]
  public class GreatestCommonDivisorNUnitTests
  {
    [TestCase(8, 10, Result = 2)]
    [TestCase(0, 10, Result = 10)]
    [TestCase(-8, 6, Result = 2)]
    [TestCase(0, 0, ExpectedException = typeof(ArgumentException))]
    public int EuclidianGCDTest(int a, int b)
    {
      return GreatestCommonDivisor.EuclidianGCD(a, b);
    }

    [TestCase(58, 100, 566, Result = 2)]
    [TestCase(0, 100, 0, Result = 100)]
    [TestCase(-58, 100, 58, Result = 2)]
    [TestCase(0, 0, 0, ExpectedException = typeof(ArgumentException))]
    public int EuclidianGCDTest(int a, int b, int c)
    {
      return GreatestCommonDivisor.EuclidianGCD(a, b, c);
    }

    [TestCase(58, 100, Result = 2)]
    [TestCase(0, 100, Result = 100)]
    [TestCase(0, 0, ExpectedException = typeof(ArgumentException))]
    public int ShteinGCDTest(int a, int b)
    {
      return GreatestCommonDivisor.ShteinGCD(a, b);
    }

    [TestCase(66, 244, 164, 1100, Result = 2)]
    [TestCase(0, 100, 50, 0, Result = 50)]
    [TestCase(0, 0, 0, 0, ExpectedException = typeof(ArgumentException))]
    public int ShteinGCDTest(int a, int b, int c, int d)
    {
      return GreatestCommonDivisor.ShteinGCD(a, b, c, d);
    }
  }
}
