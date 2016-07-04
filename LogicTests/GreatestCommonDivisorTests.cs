﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Diagnostics;

namespace LogicTests
{
  [TestClass]
  public class GreatestCommonDivisorTests
  {
    [TestMethod]
    public void EuclidianGCD_WhenInputParameters560and430_Returns10()
    {
      //Arrange
      int a = 560;
      int b = 430;
      int excepted = 10;
      long Time;

      //Act
      int result = GreatestCommonDivisor.EuclidianGCD(out Time, a, b);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    public void EuclidianGCD_WhenInputParameters560and148and586_Returns2()
    {
      //Arrange
      int a = 560;
      int b = 148;
      int c = 586;
      long Time;
      int excepted = 2;

      //Act
      int result = GreatestCommonDivisor.EuclidianGCD(out Time, a, b, c);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }


    [TestMethod]
    public void EuclidianGCD_WhenInputParameters560and148and586and44_Returns2()
    {
      //Arrange
      int a = 560;
      int b = 148;
      int c = 586;
      int d = 44;
      long Time;
      int excepted = 2;

      //Act
      int result = GreatestCommonDivisor.EuclidianGCD(out Time, a, b, c, d);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    public void EuclidianGCD_WhenInputParameters0and430_Returns430()
    {
      //Arrange
      int a = 0;
      int b = 430;
      int excepted = 430;
      long Time;

      //Act
      int result = GreatestCommonDivisor.EuclidianGCD(out Time, a, b);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]

    public void EuclidianGCD_WhenInputParameters0and0_Returns0()
    {
      //Arrange
      int a = 0;
      int b = 0;

      //Act
      int result = GreatestCommonDivisor.EuclidianGCD(a, b);

      ///Assert is handled by ExceptedException 
    }

    [TestMethod]
    public void EuclidianGCD_WhenInputParametersMinus560andMinus148andMinus586and44_Returns2()
    {
      //Arrange
      int a = -560;
      int b = -148;
      int c = -586;
      int d = 44;
      long Time;
      int excepted = 2;

      //Act
      int result = GreatestCommonDivisor.EuclidianGCD(out Time, a, b, c, d);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    public void ShteinGCD_WhenInputParameters18and144_Returns18()
    {
      //Arrange
      int a = 18;
      int b = 144;
      int excepted = 18;
      long Time;

      //Act
      int result = GreatestCommonDivisor.ShteinGCD(out Time, a, b);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    public void ShteinGCD_WhenInputParameters18and144and586_Returns2()
    {
      //Arrange
      int a = 18;
      int b = 144;
      int c = 586;
      long Time;
      int excepted = 2;

      //Act
      int result = GreatestCommonDivisor.ShteinGCD(out Time, a, b, c);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }


    [TestMethod]
    public void ShteinGCD_WhenInputParameters18and144and586and1_Returns1()
    {
      //Arrange
      int a = 18;
      int b = 144;
      int c = 586;
      int d = 1;
      long Time;
      int excepted = 1;

      //Act
      int result = GreatestCommonDivisor.ShteinGCD(out Time, a, b, c, d);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    public void ShteinGCD_WhenInputParameters0and200_Returns200()
    {
      //Arrange
      int a = 0;
      int b = 200;
      int excepted = 200;
      long Time;

      //Act
      int result = GreatestCommonDivisor.ShteinGCD(out Time, a, b);
      Debug.WriteLine(Time.ToString());

      //Assert
      Assert.AreEqual(excepted, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShteinGCD_WhenInputParameters0and0_Returns0()
    {
      //Arrange
      int a = 0;
      int b = 0;

      //Act
      int result = GreatestCommonDivisor.ShteinGCD( a, b);

      //Assert is handled by ExceptedException
    }
  }
}
