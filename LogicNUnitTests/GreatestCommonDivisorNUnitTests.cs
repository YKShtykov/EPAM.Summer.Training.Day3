using NUnit.Framework;
using System;
using Logic;
using System.Diagnostics;

namespace LogicNUnitTests
{
  /// <summary>
  /// Class of NUnit tests for Greathest Common Divisor methods
  /// </summary>
  [TestFixture]
  public class GreatestCommonDivisorNUnitTests
  {
    /// <summary>
    /// Test for simple EuclidianGCD method, various cases
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    [TestCase(8, 10, Result = 2)]
    [TestCase(0, 10, Result = 10)]
    [TestCase(-8, 6, Result = 2)]
    [TestCase(0, 0, ExpectedException = typeof(ArgumentException))]
    public int EuclidianGCDTest(int a, int b)
    {
      return GreatestCommonDivisor.EuclidianGCD( a, b);
    }

    /// <summary>
    /// Test for overloaded EuclidianGCD method with three parameters, various cases
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    [TestCase(58, 100, 566, Result = 2)]
    [TestCase(0, 100, 0, Result = 100)]
    [TestCase(-58, 100, 58, Result = 2)]
    [TestCase(0, 0, 0, ExpectedException = typeof(ArgumentException))]
    public int EuclidianGCDTest(int a, int b, int c)
    {
      return GreatestCommonDivisor.EuclidianGCD(a, b, c);
    }

    /// <summary>
    /// Test for simple ShteinGCD method, various cases
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    [TestCase(58, 100, Result = 2)]
    [TestCase(0, 100, Result = 100)]
    [TestCase(0, 0, ExpectedException = typeof(ArgumentException))]
    public int ShteinGCDTest(int a, int b)
    {
      return GreatestCommonDivisor.ShteinGCD(a, b);
    }

    /// <summary>
    /// Test for overloaded ShteinGCD method with four paramethers, various cases
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    [TestCase(66, 244, 164, 1100, Result = 2)]
    [TestCase(0, 100, 50, 0, Result = 50)]
    [TestCase(0, 0, 0, 0, ExpectedException = typeof(ArgumentException))]
    public int ShteinGCDTest(int a, int b, int c, int d)
    {
      return GreatestCommonDivisor.ShteinGCD(a, b, c, d);
    }
  }
}
