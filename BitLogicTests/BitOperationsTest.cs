using System;
using NUnit.Framework;
using BitLogic;

namespace BitLogicTests
{
  /// <summary>
  /// Class consists methods for Bit operations testing
  /// </summary>
  [TestFixture]
  public class BitOperationsTest
  {
    /// <summary>
    /// Method tests binary merge of two values
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <returns> Merged value</returns>
    [TestCase(7,4,3,5,Result =39)]
    [TestCase(100, 3, 3, 4, Result = 124)]
    [TestCase(7,4,-1,6,ExpectedException =typeof(ArgumentException))]
    [TestCase(7, 4, 6, -1, ExpectedException = typeof(ArgumentException))]
    [TestCase(7, 4, 6, 2, ExpectedException = typeof(ArgumentException))]
    public int BinaryMergeTest(int value1,int value2, int i,int j)
    {
      return BitOperations.BinaryMerge(value1,value2,i,j);
    }
  }
}
