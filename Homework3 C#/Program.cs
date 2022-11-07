Console.WriteLine("Enter point 1 coordinates (X,Y,Z)");
int num1X = Convert.ToInt32(Console.ReadLine());
int num1Y = Convert.ToInt32(Console.ReadLine());
int num1Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter point 2 coordinates (X,Y,Z)");
int num2X = Convert.ToInt32(Console.ReadLine());
int num2Y = Convert.ToInt32(Console.ReadLine());
int num2Z = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((num2X-num1X),2) + Math.Pow((num2Y-num1Y),2) + Math.Pow((num2Z - num1Z),2));
System.Console.WriteLine($"Distance is {dist}");