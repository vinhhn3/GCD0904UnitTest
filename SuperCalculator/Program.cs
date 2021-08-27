using System;

namespace SuperCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculator cal = new Calculator();

      double orginalPrice = 100;  // Include VAT = 110

      var priceWithVAT = cal.CalculateTotalPriceWithVAT(orginalPrice);

      Console.WriteLine(priceWithVAT); // 110 => OK

      Console.ReadLine();

    }
  }
}
