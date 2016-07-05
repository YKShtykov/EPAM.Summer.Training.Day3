using System;

namespace BitLogic
{
  /// <summary>
  /// Class consists methods for binary operations with values
  /// </summary>
  public static class BitOperations
  {
    /// <summary>
    /// Method merdges two values, the second value places in i-j bits range of the first value
    /// </summary>
    /// <param name="int value1"></param>
    /// <param name="int value2"></param>
    /// <param name="int i"></param>
    /// <param name="int j"></param>
    /// <returns>Merged value</returns>
    /// <exception>ArgumentException</exception>
    public static int BinaryMerge(int value1, int value2, int i, int j)
    {
      if (i < 0 || j < 0)
      {
        throw new ArgumentException("i and j must be positive");
      }

      if (i > j)
      {
        throw new ArgumentException("i must be less than j");
      }

      int length = 8 * sizeof(int);
      int result = 0;
      int[] tempArr = new int[length];

      for (int k = 0; k < length; k++)
      {
        if (k >= i && k <= j)
        {
          tempArr[k] = value2 % 2;
          value2 = value2 >> 1;
        }
        else
        {
          tempArr[k] = value1 % 2;
        }

        value1 = value1 >> 1;
      }

      for (int k = 0; k < length; k++)
      {
        result = result + (int)Math.Pow(2, k) * tempArr[k];
      }

      return result;
    }
  }
}
