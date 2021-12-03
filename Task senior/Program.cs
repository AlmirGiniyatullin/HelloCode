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
/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(10);  // от 0 до 9, второе число не включительно
        //index = index + 1;
        index++;
    }
}

int[] array = new int[12];

FillArray(array);

Array.ForEach(array, Console.WriteLine); //Заменяет метод PrintArray(array); */


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
Console.WriteLine("Task37   ");
void FillArray(int[] collection) // создание массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(110);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) // печать массива без переноса на новую строку
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        //Console.Write(col[position]);  - переносится на новую строку
        Console.Write($"{col[position]} "); // без переноса на новую строку
        position++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find, int find1) // подсчет количества элементов из отрезка [10,99]
{
    int count = collection.Length;
    int once = 0;
    for (int index = 0; index < count; index++)
    {
        if (collection[index] >= find && collection[index] <= find1)
        {
            once++;
        }
    }
    return once;    
}

int[] array = new int[123];

FillArray(array);

PrintArray(array);

int pos = IndexOf(array, 10, 99);
Console.WriteLine("Количества элементов из отрезка от 10 до 99, которые встречаются в массиве " + pos + " раз"); 

/*38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом */