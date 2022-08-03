using System;

Console.Write("Insert x please: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15);
Console.WriteLine(Math.Abs(x) * Math.Sin(x));
Console.WriteLine(2 * Math.PI * x);

Console.Write("Insert y please: ");
double y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max between " + x + ", " + y + " is " + Math.Max(x, y));

var now = DateTime.Now;
var NY23 = new DateTime(DateTime.Now.Year + 1, 1, 1);
var NY22 = new DateTime(DateTime.Now.Year, 1, 1);

Console.WriteLine((NY23 - now).Days + " days left to New Year");
Console.WriteLine((now - NY22).Days + " days passed from New Year");




