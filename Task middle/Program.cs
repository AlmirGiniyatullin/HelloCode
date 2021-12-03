

//23. Показать таблицу квадратов чисел от 1 до N 
/*Console.Write("Task23 - введите число:   ");
int number23 = int.Parse(Console.ReadLine());
int number23a = 1;
for (number23a = 1; number23a <= number23; number23a++)
{
    Console.WriteLine(number23a*number23a);
}



//24. Найти кубы чисел от 1 до N
Console.Write("Task24 - введите число:   ");
int number24 = int.Parse(Console.ReadLine());
int number24a = 1;
for (number24a = 1; number24a <= number24; number24a++)
{
    Console.WriteLine(Math.Pow(number24a,3));
}

25. Найти сумму чисел от 1 до А   
Console.Write("Task25 - введите число:   ");
int number25 = int.Parse(Console.ReadLine());
int number25sum = 0;
for (int i = 0; i <= number25; i++)
{
    number25sum = number25sum + i;
}
Console.Write("Summa:   " + number25sum);


26. Возведите число А в натуральную степень B используя цикл 
int number26a = 2;
int number26b = 4;
int number26step = 1;

for (int i = 0; i < number26b; i++)
{
    number26step = number26step * number26a;
}
Console.WriteLine(Math.Pow(number26a,number26b));
Console.WriteLine(number26step);


27. Определить количество цифр в числе 
int number27a = 123456789;
string number27b = number27a.ToString (); //Преобразование числа в строку

Console.WriteLine("The length of '{0}' is {1}", number27b, number27b.Length);




28. Подсчитать сумму цифр в числе */
/* int number28a = 1234567891;
int number28b = 0;
string number28str = number28a.ToString(); //Преобразование числа в строку
int length = number28str.Length;
int number28sum = 0;
for (int i = 0; i < length; i++)
{
    number28b = int.Parse(Convert.ToString(number28a)[i].ToString());
    number28sum = number28sum + number28b;
}
Console.Write("Summa:   " + number28sum); */





//29. Написать программу вычисления произведения чисел от 1 до N
/* Console.Write("Task29 - введите число:   ");
int number29 = int.Parse(Console.ReadLine());
int number29multi = 1;
for (int i = 1; i <= number29; i++)
{
    number29multi = number29multi * i;
}
Console.Write("Произведение:   " + number29multi);
 */


//30. Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Task30   ");
int number30 = new Random().Next(1, 100);
Console.WriteLine(number30); // если число четное то и куб четное
int number30math = (int)Math.Pow(number30, 3);
if (number30math % 2 == 0) Console.WriteLine(number30math + "  четное"); //если число четное оно заканчивается на четное число
