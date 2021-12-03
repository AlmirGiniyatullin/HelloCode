//## Почувствуй себя джуном*
//15. Дано число. Проверить кратно ли оно 7 и 23
/*int number15 =  161; //new Random().Next(10, 10000);
Console.WriteLine(number15);
if(number15%7==0 && number15%23==0) Console.WriteLine("{0} - кратно 7 и 23.",number15);
else Console.WriteLine("Число не кратно 7 и 23");  

//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.WriteLine("Task 16:    Введите номер дня недели:   ");
byte dayOfWeek = byte.Parse(Console.ReadLine());

if (dayOfWeek>7 || dayOfWeek<1) Console.WriteLine("Количество дней в неделе меньше 7");
else if (dayOfWeek==6 || dayOfWeek==7) Console.WriteLine("Этот день выходной");
else Console.WriteLine("Этот день не выходной");

//17.По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Task17      Enter number17a: ");

int number17a = int.Parse(Console.ReadLine());

int number17c = number17a * number17a;

Console.Write("Enter number17b: ");

int number17b = int.Parse(Console.ReadLine());

int number17d = number17b * number17b;

if (number17a > number17b && number17d == number17a) 
{
    Console.WriteLine("Answer 1       Ура, первое является квадратом второго");
}
else if (number17a < number17b && number17c == number17b) 
{
Console.WriteLine("Answer 1      2 является квадратом 1");
}   
else Console.WriteLine("Числа не является квадратами");


//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//Console.Write("Введите значение X true или false:   ");
//bool X = bool.Parse(Console.ReadLine());
//Console.Write("Введите значение Y true или false:   ");
//bool Y = bool.Parse(Console.ReadLine());
Console.WriteLine("Task18:   ");
bool Xf = false;
bool Xt = true;
bool Yf = false;
bool Yt = true;

string Method(bool X, bool Y)
{
    string result = String.Empty;
    Console.Write($"значение X: {X}\n");
    Console.Write("значение Y: {0}\n", Y);
    if(!(X || Y) == (!X && !Y)) result = "Истина";
    else result = "Ложь";
    return result;
}

string res = Method(Xt, Yt);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
res = Method(Xt, Yf);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
res = Method(Xf, Yt);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
res = Method(Xf, Yf);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");

//19.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// X ≠ 0 и Y ≠ 0 - границы четвертей,
//  0<x<N && 0<y<N   1 четверть
//  0<x<N && -N<y<0  2 четверть
//  -N<x<0 && -N<y<0 3 четверть
//  -N<x<0 && 0<y<N 4 четверть
Console.Write("Task19 - введите границу:   ");
int number19 = int.Parse(Console.ReadLine());
Console.Write("Координаты точки Х, не 0:   ");
int number19x = int.Parse(Console.ReadLine());
Console.Write("Координаты точки У, не 0:   ");
int number19y = int.Parse(Console.ReadLine());
if (0 < number19x && number19x < number19 && 0 < number19y && number19y < number19) Console.WriteLine("Вы в 1 четверти");
else if (0 < number19x && number19x < number19 && -number19 < number19y && number19y < 0) Console.WriteLine("Вы в 2 четверти");
else if (-number19 < number19x && number19x < 0 && -number19 < number19y && number19y < 0) Console.WriteLine("Вы в 3 четверти");
else if (-number19 < number19x && number19x < 0 && 0 < number19y && number19y < number19) Console.WriteLine("Вы в 4 четверти");
else Console.WriteLine("Вы выбрали границу четвертей или вышли за границы");
*/

//20. Задать номер четверти, показать диапазоны для возможных координат
/*Console.Write("Task20 - введите границу:   ");
int number20 = int.Parse(Console.ReadLine());
int number20x = number20;
int number20y = number20;

Console.Write("Ввидите номер четверти от 1 до 4:   ");
byte number20n = byte.Parse(Console.ReadLine());

if(number20n == 1 || number20n == 2) Console.WriteLine($"Диапазон для возможных координат по X: от 1 до {number20x}");
else if (number20n == 3 || number20n == 4) Console.WriteLine($"Диапазон для возможных координат по X: от {-number20x} до 1");

if (number20n == 1 || number20n == 4) Console.WriteLine($"Диапазон для возможных координат по У: от 1 до {number20y}");
else if (number20n == 2 || number20n == 3) Console.WriteLine($"Диапазон для возможных координат по У: от {-number20y} до 1");
else Console.WriteLine("Количество четвертей не может превышать 4");
*/

//21. Программа проверяет пятизначное число на палиндромом.
/*int i = 25452;
int a = int.Parse(Convert.ToString(i)[0].ToString());
int b = int.Parse(Convert.ToString(i)[1].ToString());
int c = int.Parse(Convert.ToString(i)[2].ToString());
int d = int.Parse(Convert.ToString(i)[3].ToString());
int e = int.Parse(Convert.ToString(i)[4].ToString());

if (a== e && b == d) Console.WriteLine("Yes");
else Console.WriteLine("Yes");*/
//22. Найти расстояние между точками в пространстве 2D/3D
int x1 = 2;
int x2 = 4;
int y1 = 9;
int y2 = 3;

double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(a);
