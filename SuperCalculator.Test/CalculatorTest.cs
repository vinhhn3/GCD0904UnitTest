using NUnit.Framework;

namespace SuperCalculator.Test
{
  [TestFixture]
  class CalculatorTest
  {
    [Test]
    public void SumTwoInt()
    {
      // Arrange
      var cal = new Calculator();
      int a = 10;
      int b = 20;

      // Act 
      var result = cal.Sum(a, b);

      // Assert
      int expectedResult = 30;
      Assert.AreEqual(expectedResult, result);
    }
    [Test]
    public void TestCalculateVAT()
    {
      // Arrange
      var cal = new Calculator();
      var originalPrice = 123.456;
      // Act
      var actualResult = cal.CalculateTotalPriceWithVAT(originalPrice);

      // Assert
      var expectedResult = 135.8016;
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
