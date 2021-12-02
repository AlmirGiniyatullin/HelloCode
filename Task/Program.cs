/* / See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 0. Вывести квадрат числа

Console.Write("Task0      Enter number: ");

int num = int.Parse(Console.ReadLine());

int quadrat = num * num;

Console.WriteLine("Answer 0 quadrat - {0}", quadrat); 


// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Task1      Enter numberA: ");

int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter numberB: ");

int numberB = int.Parse(Console.ReadLine());

int numberC = numberA / numberB;

if(numberC == numberB) Console.WriteLine("Answer 1       Ура, первое является квадратом второго");
else  Console.WriteLine("Answer 1      Первое не является квадратом второго");

// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine("Task 2");
int task3First = 24;
int task3Second = 124;

if (task3First > task3Second)
{
    Console.WriteLine("Большее:  " + task3First);
    Console.WriteLine("Меньшее:  " + task3Second);
}
else if (task3First < task3Second)
{
    Console.WriteLine("Большее:  " + task3Second);
    Console.WriteLine("Меньшее:  " + task3First);
}
else Console.WriteLine("Числа равны");

// 3. По заданному номеру дня недели вывести его название
Console.WriteLine("Task 3:    Введите номер дня недели:   ");

byte dayOfWeek = byte.Parse(Console.ReadLine());

if (dayOfWeek == 1) Console.WriteLine("Это понедельник");
else if (dayOfWeek == 2) Console.WriteLine("Это вторник");
else if (dayOfWeek == 3) Console.WriteLine("Это среда");
else if (dayOfWeek == 4) Console.WriteLine("Это четверг");
else if (dayOfWeek == 5) Console.WriteLine("Это пятница");
else if (dayOfWeek == 6) Console.WriteLine("Это суббота");
else if (dayOfWeek == 7) Console.WriteLine("Это воскресенье");
else Console.WriteLine("Количество дней в неделе меньше 7");

string [] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (dayOfWeek>7 || dayOfWeek<1)
{
    Console.WriteLine("Количество дней в неделе меньше 7");
}
else Console.WriteLine(array[dayOfWeek - 1]);


// 4. Найти максимальное из трех чисел
Console.WriteLine("Task 4");
byte a = 1;
byte b = 8;
byte c = 3;
byte max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.WriteLine("Максимальное число - " + max);

// 5. Написать программу вычисления значения функции y = f(a)
/* Задана функция у =  х + 1 , при х >= 0
                  у =  |х|, x < 0

int x = 1
int y = 0
if (x>=0)  y = x + 1
else 

// 6. Выяснить является ли число чётным
*/


// 7. Показать числа от -N до N
/*
int n = 5;
int m = -1 * n;
while (m<n)
{
    Console.WriteLine(m);
    m++; 
}
*/

// 8. Показать четные числа от 1 до N
/*
int n = 11;
int index = 1;
while (index<n)
{
if (index%2 == 0 ) Console.WriteLine(index);
    index++; 
}
*/

// 9. Показать последнюю цифру трёхзначного числа

//Console.WriteLine(tri % 10);

//10. Показать вторую цифру трёхзначного числа
// int tri = 156/10
//Console.WriteLine(tri % 10);

//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
/*
int numberAA = new Random().Next(10, 99);
Console.WriteLine(numberAA);
int des = numberAA/10;
int edin = numberAA % 10;
if (des>edin) Console.WriteLine("Максимальное число - " + des);
else if(des<edin) Console.WriteLine("Максимальное число - " + edin);
else Console.WriteLine("Они равны");
*/

/*
//12. Удалить вторую цифру трёхзначного числа
int chislo = 415;
int sot = chislo/100;
int edin12 = chislo % 10;
int chislo12 = sot*10 +edin12;
Console.WriteLine("Искомое число - " + chislo12);



//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.



//14. Найти третью цифру числа или сообщить, что её нет
*/
int number14 = new Random().Next(10, 10000);
Console.WriteLine(number14);
int sot14 = (number14/100) % 10;
if (sot14 == 0) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine("Третья цифра - " + sot14);


// Почувствуй себя джуном
//15. Дано число. Проверить кратно ли оно 7 и 23
//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
//17. По двум заданным числам проверять является ли одно квадратом другого
//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
//20. Задать номер четверти, показать диапазоны для возможных координат
//21. Программа проверяет пятизначное число на палиндромом.
//22. Найти расстояние между точками в пространстве 2D/3D


