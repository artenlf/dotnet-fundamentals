using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetFundamentals.Common.Models
{
  public class Calculator
  {
    public void Add(int x, int y)
    {
      Console.WriteLine($"Add: {x} + {y} = {x + y}");
    }

    public void Subtract(int x, int y)
    {
      Console.WriteLine($"Subtract: {x} - {y} = {x - y}");
    }

    public void Multiply(int x, int y)
    {
      Console.WriteLine($"Multiply: {x} * {y} = {x * y}");
    }

    public void Divide(int x, int y)
    {
      Console.WriteLine($"Divide: {x} / {y} = {x / y}");
    }

    public void Module(int x, int y)
    {
      Console.WriteLine($"Module: {x} % {y} = {x % y}");
    }

    public void Power(int x, int y)
    {
      double power = Math.Pow(x, y);
      Console.WriteLine($"Power: {x} ^ {y} = {power}");
    }

    public void Sine(double angle)
    {
      double radius = angle * Math.PI / 180;
      double sine = Math.Sin(radius);
      Console.WriteLine($"Sine: {angle}º = {Math.Round(sine, 4)}");
    }

    public void Cosine(double angle)
    {
      double radius = angle * Math.PI / 180;
      double cosine = Math.Cos(radius);
      Console.WriteLine($"Cosine: {angle}º = {Math.Round(cosine, 4)}");
    }

    public void Tangent(double angle)
    {
      double radius = angle * Math.PI / 180;
      double tangent = Math.Tan(radius);
      Console.WriteLine($"Tangent: {angle}º = {Math.Round(tangent, 4)}");
    }

    public void Squared(double x)
    {
      double squared = Math.Sqrt(x);
      Console.WriteLine($"Squared: {x} = {squared}");
    }
  }
}