Console.Write("Enter numberA: ");

int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter numberB: ");

int numberB = int.Parse(Console.ReadLine());

int num = numberA / numberB;

if(num == numberB) Console.WriteLine("Ура, первое является квадратом второго");
else  Console.WriteLine("Первое не является квадратом второго");
