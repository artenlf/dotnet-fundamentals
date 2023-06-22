using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetFundamentals.Common.Models
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public void IntroduceYourself()
    {
      Console.WriteLine($"Hello, my name is {Name} and my age is {Age} years old");
    }
  }
}