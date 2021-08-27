namespace SuperCalculator
{
  public class Calculator
  {
    public int Sum(int a, int b)
    {
      return a + b;
    }

    public int Substract(int a, int b)
    {
      return a - b;
    }

    public int Multiply(int a, int b)
    {
      return a * b;
    }

    public int Divide(int a, int b)
    {
      return a / b;
    }

    // Business Logic
    // return total price with vat = orginialPrice + originalPrice * 10%
    public double CalculateTotalPriceWithVAT(double price)
    {
      double vat = 0.1;
      return price + price * vat;
    }
  }
}
