
                      //------------------Задача 47---------
// Задайте двумерный массив размером m×n
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// // Просим пользователя ввести данные о количестве строк и столбцов
// Console.Write("Введите количество строк = ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов = ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double[rows,colomns]; // создаем сам двумерный массив из вещественных чисел

// // Метод заполняет массив
// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строки
//     {
//          for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             array[i,j]= Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 3); // просто заполнили целыми числами рандомными и добавили рандомные дробные с 3 знаками после запятой
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();

//     }
// }

// FillingArray();
// PrintArray();






//---------------------Задача 50------------------
//  Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Просим пользователя ввести данные о количестве строк и столбцов
// Console.Write("Введите количество строк = ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов = ");
// int colomns = Convert.ToInt32(Console.ReadLine());
// // Построение матрицы
// int[,] array = new int[rows, colomns];
// // Метод заполняет массив
// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++) // строки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             array[i, j] = new Random().Next(-1000, 1000);// рандомное заполнение массива случайными числами в заданном диапазоне
//         }
//     }
// }
// // Метод выводит матрицы
// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++) //строки
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{array[i, j]} "); // вывод н аэкран
//         }
//         Console.WriteLine();

//     }
// }
// // Просим пользователя ввести данные индксов строк и столбцов  для поиска
// Console.Write("Введите индекс искомой строки в массиве = ");
// int arraySearch1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс искомого столбца в массиве = ");
// int arraySearch2 = Convert.ToInt32(Console.ReadLine());
// // Метод поиска индексов
// void SearchElementArray(int arraySearch1, int arraySearch2)
// {
//     if (arraySearch1 < array.GetLength(0) && arraySearch2 < array.GetLength(1)) // условие если и то и то
//     {
//         Console.WriteLine($"Число в массиве = [ {array[arraySearch1, arraySearch2]} ]");
//     }
//     else
//     {
//         Console.WriteLine($" {arraySearch1}, {arraySearch2} заданных индексов для поиска в существующем масииве нет ");
//     }
// }
// // Выводы самой проги через методы
// FillingArray();
// SearchElementArray(arraySearch1, arraySearch2);
// PrintArray();












// -------------Задача 52---------------------
//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Просим пользователя ввести данные о количестве строк и столбцов 
Console.Write("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int colomns = Convert.ToInt32(Console.ReadLine());
// Построение матрицы
int[,] array = new int[rows, colomns]; // задали двкмерный массив
// Метод заполняет масиив случайными целыми числами
void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
// Метод вывода массива
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++) // строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {

            Console.Write($"{array[i, j]} "); // вывод на аэкран
        }
        Console.WriteLine("");

    }
}
// Поиск среднеарифмитического значения элемента каждом столбце
void ArithmetMean()
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double arithmeticMean = 0; // промежуточная переме
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticMean += array[i,j];
        }
        Console.Write($"[{arithmeticMean /= array.GetLength(0),2}] ");
    }
    Console.WriteLine("");
}
// Выводы
FillingArray();
Console.WriteLine("");
Console.WriteLine("      Среднее      ");
ArithmetMean();
Console.WriteLine("");
Console.WriteLine("       Массив       ");
PrintArray();