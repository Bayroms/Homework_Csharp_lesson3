Console.WriteLine("Enter number:");
int num = int.Parse(Console.ReadLine());
int i = 1;

while (i <= num)
{
    System.Console.Write($"{i*i*i}, ");
    i++;
}