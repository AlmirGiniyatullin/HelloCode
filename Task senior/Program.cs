//31. Задать массив из 8 элементов и вывести их на экран 
//int[] m = { 1, 2, 3, 4, 5, 6, 7, 8 };
//Array.ForEach(m, Console.WriteLine);

/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];

FillArray(array);

PrintArray(array);
Console.WriteLine();

Array.ForEach(array, Console.WriteLine); //Заменяет метод PrintArray(array);
 */
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(2);  // от 0 до 1, второе число не включительно
        //index = index + 1;
        index++;
    }
}

int[] array = new int[10];

FillArray(array);

Array.ForEach(array, Console.WriteLine); //Заменяет метод PrintArray(array); */

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(-9, 10);  // от 0 до 9, второе число не включительно
//         //index = index + 1;
//         index++;
//     }
// }

// void SumItems(int[] collection)
// {
//     int length = collection.Length;
//     int positive = 0;
//     int negative = 0;
//     for (int index = 0; index < length; index++)
//     {
//         if (collection[index] >= 0)
//         {
//             positive++;            
//         }
//         else
//         {
//             negative++;
//         }
//     }
//     Console.WriteLine("Сумма полочительных чисел в массиве: " + positive);
//     Console.WriteLine("Сумма отрицательных чисел в массиве: " + negative);
// }

// int[] array = new int[12];

// FillArray(array);

// Array.ForEach(array, Console.WriteLine); //Заменяет метод PrintArray(array);

// SumItems(array);


//34. Написать программу замену элементов массива на противоположные
/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);  // от -9 до 9, второе число не включительно
        //index = index + 1;
        index++;
    }
}
void ChangeItems(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = -collection[index];
    }
}



int[] array = new int[7];

FillArray(array);

Array.ForEach(array, Console.WriteLine); //Заменяет метод PrintArray(array);

Console.WriteLine();

ChangeItems(array);

Array.ForEach(array, Console.WriteLine); //Заменяет метод PrintArray(array); */

//35. Определить, присутствует ли в заданном массиве, некоторое число 

/* void FillArray(int[] collection) // создание массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) // печать массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // подсчет количества указанного числа в массиве
{
    int count = collection.Length;
    int once = 0;
    for (int index = 0; index < count; index++)
    {
        if (collection[index] == find)
        {
            once++;
        }
    }
    return once;    
}

int[] array = new int[10];

FillArray(array);

PrintArray(array);
Console.WriteLine("Task35 - введите искомое в массиве число:   ");
int number35 = int.Parse(Console.ReadLine());

int pos = IndexOf(array, number35);
Console.WriteLine("Искомое число " + number35 + " встречается в массиве " + pos + " раз"); */


//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
/* Console.WriteLine("Task36  ");
void FillArray(int[] collection) // создание массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) // печать массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void evenOdd(int[] collection) // подсчет количества нечетных\четных чисел в массиве
{
    int count = collection.Length;
    int even = 0;
    int odd = 0;
    for (int index = 0; index < count; index++)
    {
        if (collection[index] % 2 == 0)
        {
            even++; // четные
        }
        else
        {
            odd++;  // нечетные
        }
    }
    Console.WriteLine("количества нечетных чисел в массиве " + odd + " раз");
    Console.WriteLine("количества четных чисел в массиве " + even + " раз");
}

int[] array = new int[10];

FillArray(array);

PrintArray(array);

evenOdd(array); */


//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// Console.WriteLine("Task37   ");
// void FillArray(int[] collection) // создание массива
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(110);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col) // печать массива без переноса на новую строку
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         //Console.Write(col[position]);  - переносится на новую строку
//         Console.Write($"{col[position]} "); // без переноса на новую строку
//         position++;
//     }
//     Console.WriteLine();
// }

// int IndexOf(int[] collection, int find, int find1) // подсчет количества элементов из отрезка [10,99]
// {
//     int count = collection.Length;
//     int once = 0;
//     for (int index = 0; index < count; index++)
//     {
//         if (collection[index] >= find && collection[index] <= find1)
//         {
//             once++;
//         }
//         else
//         {
//             Console.Write($"{collection[index]},  ");
//         }
//     }
//     return once;    
// }

// int[] array = new int[123];

// FillArray(array);

// PrintArray(array);

// int pos = IndexOf(array, 10, 99);
// Console.WriteLine ();
// Console.WriteLine("Количества элементов из отрезка от 10 до 99, которые встречаются в массиве " + pos + " раз"); 

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// Console.WriteLine("Task38   ");
// void FillArray(int[] collection) // создание массива
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col) // печать массива без переноса на новую строку
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         //Console.Write(col[position]);  - переносится на новую строку
//         Console.Write($"{col[position]} "); // без переноса на новую строку
//         position++;
//     }
//     Console.WriteLine();
// }

// int Sum(int[] collection) // подсчет суммы чисел одномерного массива стоящих на нечетной позиции
// {
//     int count = collection.Length;
//     int negative = 0;
//     int index = 0;
//     while (index < count)
//     {
//         negative= negative + collection[index];
//         index = index + 2;

//     }
//     return negative;
// }

// int[] array = new int[10];

// FillArray(array);

// PrintArray(array);

// int pos = Sum(array);
// Console.WriteLine();
// Console.WriteLine("Суммы чисел одномерного массива стоящих на нечетной позиции: " + pos);

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// void FillArray(int[] collection) // создание массива
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(10);
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col) // печать массива без переноса на новую строку
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         //Console.Write(col[position]);  - переносится на новую строку
//         Console.Write($"{col[position]} "); // без переноса на новую строку
//         position++;
//     }
//     Console.WriteLine();
// }

// void Prod(int[] collection) // Найти произведение пар чисел в одномерном массиве.
// {
//     int count = collection.Length; // длина массива
//     int k = count / 2;                 // середина массива
//     int result = 0;
//     for (int i = 0; i < k; i++) Console.WriteLine("Произведение '{0}' пары чисел = {1}", i, collection[i]* collection[count- i -1]);

// }

// int[] array = new int[10];

// FillArray(array);

// PrintArray(array);

// Prod(array);

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом 
Console.WriteLine("Task40   ");
void FillArray(double[] collection) // создание массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100000) / 100.0;  // число от 0 до 1000 (100000/100) два элемента после запятой 
        //index = index + 1;
        index++;
    }
}

void PrintArray(double[] col) // печать массива без переноса на новую строку
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]); // - переносится на новую строку
        //Console.Write($"{col[position]} "); // без переноса на новую строку
        position++;
    }
    Console.WriteLine();
}

double Raznost(double[] collection) // разницу между максимальным и минимальным элементом
{
    int count = collection.Length;
    double max = collection[0];
    double min = collection[0];
    for (int i = 1; i < count; i++)
    {
        if (collection[i] > max) max = collection[i];
        else if (collection[i] < min) min = collection[i];
    }

    return max - min;
}

double[] array = new double[10];

FillArray(array);

PrintArray(array);

double pos = Raznost(array);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом: " + pos);


