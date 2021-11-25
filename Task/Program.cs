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
*/
// 3. По заданному номеру дня недели вывести его название
Console.WriteLine("Task 3:    Введите номер дня недели:   ");

byte dayOfWeek = byte.Parse(Console.ReadLine());

if (dayOfWeek == 1) Console.WriteLine("Это понедельник");

else if (dayOfWeek == 2) Console.WriteLine("Это вторник");
else if (dayOfWeek == 3) Console.WriteLine("Это среда");
else if (dayOfWeek == 4) Console.WriteLine("Это четверг");
else if (dayOfWeek == 5) Console.WriteLine("Это пятница");
else if (dayOfWeek == 6) Console.WriteLine("Это суббота");
else if (dayOfWeek == 7) Console.WriteLine("Это воскресение");
else Console.WriteLine("Количество дней в неделе меньше 7");


// 4. Найти максимальное из трех чисел
// 5. Написать программу вычисления значения функции y = f(a)
// 6. Выяснить является ли число чётным
// 7. Показать числа от -N до N
// 8. Показать четные числа от 1 до N
// 9. Показать последнюю цифру трёхзначного числа
//10. Показать вторую цифру трёхзначного числа
//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
//12. Удалить вторую цифру трёхзначного числа
//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//14. Найти третью цифру числа или сообщить, что её нет

// Почувствуй себя джуном
//15. Дано число. Проверить кратно ли оно 7 и 23
//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
//17. По двум заданным числам проверять является ли одно квадратом другого
//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
//20. Задать номер четверти, показать диапазоны для возможных координат
//21. Программа проверяет пятизначное число на палиндромом.
//22. Найти расстояние между точками в пространстве 2D/3D


