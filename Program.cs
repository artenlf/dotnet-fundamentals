using DotnetFundamentals.Models;

Person p = new Person();

p.Name = "John Doe";
p.Age = 22;

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
