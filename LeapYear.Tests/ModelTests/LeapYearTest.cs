using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear.Models;
namespace LeapYear.Tests
{
  [TestClass]
  public class LeapYearTest
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }
  }
}
