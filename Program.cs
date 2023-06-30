// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// -------------------------------------Лекция

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//
// string[,] table = new string[2,5];
// String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// --------------------------------------------
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.WriteLine($"{matrix[i, j]} ");
//     }
// }
//------------------------
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
// }
// Console.WriteLine();
// }

//---------метод выводящий матрицу--------------------
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
// } }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);


//---------метод выводящий матрицу--------------------
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
// } }

// //---------метод заполняющий матрицу случайными числами--------------------
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);//[1; 10)
//         }
// }
// }
// // ------сама прога-----------------
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// //------- это метод выводящий массив но очень своеобразно 
// //0 он не печатае а печатает пробел а за место 1ставит +
// // void PrintImage(int[,] image)
// // {
// //     for (int i = 0; i < image.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < image.GetLength(1); j++)
// //         {
// //             if(image[i,j] == 0) Console.Write($" ");
// //             else Console.Write($"+");
// //         }
// //         Console.WriteLine();
// //     }
// // }


// // PrintImage(pic);
// //------- это метод выводящий массив но очень своеобразно 
// //0 он не печатае а печатает пробел а за место 1ставит +
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// //----  метод который красит______________________
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
// } }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);



// -------------------------- Рекуссия-
// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(5)); // 1 * 2 * 3 = 6

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i));
// }
// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }



// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
//---------------числа фибоначи------------
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));

// }

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }
// --------------------------------

// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(1,10);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }



// ----------------------------------
// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// // 77 3 8 1
// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];

// // Метод заполняет массив
// void Array()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Array();
// PrintArray();

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// _____________________________________
// int rows = int.Parse(Console.ReadLine());
// int colomns = int.Parse(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];

// // Метод заполняет массив
// void Array()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= j + i;
//         }
//     }
// }
// // Метод заполняющий массив согласно условию задачи
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Array();
// PrintArray();
// _______________________________________________
// Задача 49: Задайте двумерный массив. Найдите элементы,
//  у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];

// Array();
// PrintArray();
// ChangArray();
// PrintArray();

// // Метод заполняет массив
// void Array()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// // Изменяет массив(находит элемент с четными координами и возводит в квадрат)
// void ChangArray()
// {
//     Console.WriteLine("________");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((i%2==0)&&(j%2==0))
//             {
//                 matrix[i,j]= matrix[i,j] * matrix[i,j];
//             }
//         }
//     }
// }

// __________________________________
// Задача 51: Задайте двумерный массив. Найдите сумму
//  элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int rows = int.Parse(Console.ReadLine());
// int colomns = int.Parse(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];

// // Метод заполняет массив
// void FillingArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// // Находим элемент с координатами (0,0), (1,1) и т.д
// void SearchElementArray()
// {
//     int sum =0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((i==j))
//             {
//                 sum=sum+matrix[i,j];
//             }
//         }
//     }
//     Console.WriteLine($"Сумма равна: {sum}");
// }
// FillingArray();
// PrintArray();
// SearchElementArray();



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
Console.Write("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int colomns = Convert.ToInt32(Console.ReadLine());
// Построение матрицы
int[,] array = new int[rows, colomns];
// Метод заполняет массив
void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++) // строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            array[i, j] = new Random().Next(-1000, 1000);// рандомное заполнение массива случайными числами в заданном диапазоне
        }
    }
}
// Метод выводит матрицы
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write($"{array[i, j]} "); // вывод н аэкран
        }
        Console.WriteLine();

    }
}
// Просим пользователя ввести данные индксов строк и столбцов  для поиска
Console.Write("Введите индекс искомой строки в массиве = ");
int arraySearch1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс искомого столбца в массиве = ");
int arraySearch2 = Convert.ToInt32(Console.ReadLine());
// Метод поиска индексов
void SearchElementArray(int arraySearch1, int arraySearch2)
{
    if (arraySearch1 < array.GetLength(0) && arraySearch2 < array.GetLength(1)) // условие если и то и то
    {
        Console.WriteLine($"Число в массиве = [ {array[arraySearch1, arraySearch2]} ]");
    }
    else
    {
        Console.WriteLine($" {arraySearch1}, {arraySearch2} заданных индексов для поиска в существующем масииве нет ");
    }
}
// Выводы самой проги через методы
FillingArray();
SearchElementArray(arraySearch1, arraySearch2);
PrintArray();












// -------------Задача 52---------------------
//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.