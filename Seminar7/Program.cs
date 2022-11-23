//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] CreateArray(int m, int n, int minValue, int maxValue){
//     double [,] array = new double [n,m];
//     for ( int i = 0; i < m; i++)
//         for (int j = 0; j < n; j ++){
//             array[i,j] = Math.Round(new Random().Next(minValue,maxValue) + new Random().NextDouble(), 2);
//         } return array;
// }

// void ShowArray(double [,] array){
//     for (int i = 0; i < array.GetLength(0); i++){ 
//         for (int j = 0; j < array.GetLength(1); j ++){
//             Console.Write(array[i,j] + " ");
//         } Console.WriteLine();
//     } Console.WriteLine();
// }


// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число m: "); 
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateArray(n, m, min, max));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] CreateArray(int m, int n){
//     int [,] array = new int [n,m];
//     for ( int i = 0; i < m; i++)
//         for (int j = 0; j < n; j ++){
//             array[i,j] = new Random().Next(0,100); 
//         }return array;
// }

// void FindNumber(int[,] array, int row, int column){
//     if ( row > array.GetLength(0) || column > array.GetLength(1) || row < 0 || column < 0 ){
//         Console.WriteLine($"Данного элемента не существует ");
//     } else {
//         Console.WriteLine($"На {row + 1} строке {column + 1} столбца находится {array[row,column]}");
//     }
// }

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число m: "); 
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int [,] tableArr = CreateArray(n, m);

// /*void ShowArray (int [,] array){ // строки с 68 по 76 добавлены для удобства проверки
//     for (int i = 0; i < array.GetLength(0); i++){ 
//         for (int j = 0; j < array.GetLength(1); j ++){
//             Console.Write(array[i,j] + " ");
//         } Console.WriteLine();
//     } Console.WriteLine();
// }

// ShowArray(tableArr);
// */
// FindNumber(tableArr, row -1, column -1);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int [,] CreateArray(int m, int n){
//     int [,] array = new int [n,m];
//     for ( int i = 0; i < m; i++)
//         for (int j = 0; j < n; j ++){
//             array[i,j] = new Random().Next(0,11); 
//         }return array;
// }

// double [] ArithmeticMean(int [,] array){
//     double [] sumArray = new double [array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j ++){
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i ++){
//             sum += array[i,j]; 
//         } sumArray[j] = Math.Round(sum / array.GetLength(0),2);      
//     } return sumArray;
// }

// void ShowSumArray (double [] array){ 
//     Console.Write("Среднее арифметическое каждого столбца: | ");
//     for (int i = 0; i < array.Length; i++){ 
//             Console.Write(array[i] + " | ");
//     }
// }

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число m: "); 
// int m = Convert.ToInt32(Console.ReadLine());


// int [,] tableArr = CreateArray(n, m);
// double [] sum = ArithmeticMean(tableArr);

// /*void ShowArray (int [,] array){ 
//     for (int i = 0; i < array.GetLength(0); i++){ 
//         for (int j = 0; j < array.GetLength(1); j ++){
//             Console.Write(array[i,j] + " ");
//         } Console.WriteLine();
//     } Console.WriteLine();
// }
// ShowArray(tableArr);*/

// ShowSumArray(sum);


