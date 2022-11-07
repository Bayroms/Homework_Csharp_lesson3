Console.WriteLine("Insert 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int rev1 = number / 10 % 10;
int rev2 = number % 10;
int lenght = number / 10000;

if (lenght < 1 || lenght > 9){
    Console.WriteLine($"{number} is not 5-digit number");
    }
    else if  (num1 == rev2 && num2 == rev1){
    Console.WriteLine($"{number} is a polydrome");
    }
    else{
    Console.WriteLine($"{number} is not a polydrome");
    }