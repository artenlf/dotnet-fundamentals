﻿using DotnetFundamentals.Common.Models;

// Instance Person
Person p = new Person();

// Name and Age variables attribution
p.Name = "John Doe";
p.Age = 22;

// Calls IntroduceYourself method
p.IntroduceYourself();

// Types of variables

string hello = "Hello, world!";

int quantity = 1;

double height = 1.75;

decimal price = 1.99M;

bool condition = true;

Console.WriteLine(hello);
Console.WriteLine($"Quantity value is {quantity}");
Console.WriteLine($"How tall are you? {height}");
Console.WriteLine($"What's the price of this? {price} USD");
Console.WriteLine($"Is Earth a globe? {condition}");

// Type DateTime

DateTime todayDate = DateTime.Now;

Console.WriteLine(todayDate);

// Simplified date format without seconds
Console.WriteLine(todayDate.ToString("dd/MM/yyyy HH:mm"));


// Math basic operations
Calculator calc = new Calculator();

calc.Add(3, 2);
calc.Subtract(10, 5);
calc.Multiply(2, 2);
calc.Divide(10, 2);
calc.Module(10, 3);
calc.Power(10, 3);
calc.Sine(30);
calc.Cosine(30);
calc.Tangent(30);
calc.Squared(16);

// Interactive Menu

string option;
bool showMenu = true;

while (showMenu)
{
  Console.WriteLine("Select your option");
  Console.WriteLine("1 - Register new User");
  Console.WriteLine("2 - Search for existing User");
  Console.WriteLine("3 - Delete existing User");
  Console.WriteLine("4 - Exit");

  option = Console.ReadLine();

  switch (option)
  {
    case "1":
      Console.WriteLine("Option Selected: Register new User");
      break;

    case "2":
      Console.WriteLine("Option Selected: Search for existing User");
      break;

    case "3":
      Console.WriteLine("Option Selected: Delete existing User");
      break;

    case "4":
      Console.WriteLine("Option Selected: Exit");
      showMenu = false;
      // Environment.Exit(0); // this line exits application and anything below it, will not be excuted.
      break;

    default:
      Console.WriteLine("Invalid option!");
      break;
  }
}

Console.WriteLine("Exiting Menu");

// Array Examples

// For example
Console.WriteLine("Array For Example");
int[] intArray = new int[4];

intArray[0] = 10;
intArray[1] = 32;
intArray[2] = 42;
intArray[3] = 98;

for (int counter = 0; counter < intArray.Length; counter++)
{
  Console.WriteLine($"Index position {counter}: {intArray[counter]}");
}

// Foreach Example
Console.WriteLine("Array Foreach Example");

int foreachArrayCounter = 0;
foreach (int value in intArray)
{
  Console.WriteLine($"Index position {foreachArrayCounter}:  {value}");
  foreachArrayCounter++;
}

// List For Example
Console.WriteLine("List For Example");

List<string> stringList = new List<string>();

stringList.Add("Hello");
stringList.Add("World");
stringList.Add("John");
stringList.Add("Doe");

for (int counter = 0; counter < stringList.Count; counter++)
{
  Console.WriteLine($"List index position {counter}: {stringList[counter]}");
}

// List Foreach Example
Console.WriteLine("List Foreach Example");
int foreachListCounter = 0;
foreach (string item in stringList)
{
  Console.WriteLine($"List index position {foreachListCounter}: {item}");
  foreachListCounter++;
}