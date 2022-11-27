// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int [,] CreateArray (){
//     Console.Write("Введите количество строк в массиве: ");
//     int rows = Convert.ToInt32(Console.ReadLine()); 
//     Console.Write("Введите количество столбцов в массиве: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение элементов в массиве: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение элементов в массиве: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int [,] array = new int [rows, columns];

//     for (int i = 0; i < rows; i++) 
//         for (int j = 0; j < columns; j ++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }

// void ShowArray (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i ++){
//         for (int j = 0; j < array.GetLength(1); j ++){
//             Console.Write(array[i,j] + " ");
//         } Console.WriteLine();
//     } Console.WriteLine();
// }


// int [,] DecreasingNumbers (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i ++){
//         for (int j = 0; j < array.GetLength(1); j ++){
//             for ( int n = 0; n < array.GetLength(1) - 1; n ++){
//                 int temp = Math.Min(array[i, n], array[i,n + 1]);
//                 array[i, n] = Math.Max(array[i, n], array[i,n + 1]);
//                 array[ i, n + 1] = temp;
//             }
//         }
//     } return array;
// }


// int [,] newArray = CreateArray();
// ShowArray(newArray);
// DecreasingNumbers(newArray);
// ShowArray(newArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int [,] CreateArray (){
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine()); 
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение элементов: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение элементов: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int [,] array = new int [rows, columns];

//     for (int i = 0; i < rows; i++) 
//         for (int j = 0; j < columns; j ++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }

// void ShowArray (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i ++){
//         for (int j = 0; j < array.GetLength(1); j ++){
//             Console.Write(array[i,j] + " ");
//         } Console.WriteLine();
//     } Console.WriteLine();
// }

// int RowsWins (int [,] array){
     
//     int [] newArray = new int [array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i ++){
//         int result = 0;
//         for (int j = 0; j < array.GetLength(1); j ++){
//             result += array[i,j];
//         newArray[i] = result;
//         }
//     }
//     int rowsWinner = 0;
//     for (int i = 1; i < newArray.Length; i ++){
//         if (newArray[rowsWinner] > newArray[i]) rowsWinner = i;
//     } return rowsWinner + 1;
// }

// int [,] newArray = CreateArray();
// ShowArray(newArray);
// int winner = RowsWins(newArray);
// Console.Write($"{winner} строка");



// Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// // int [,] CreateArray (){
// //     Console.Write("Введите количество строк в массиве: ");
// //     int rows = Convert.ToInt32(Console.ReadLine()); 
// //     Console.Write("Введите количество столбцов в массиве: ");
// //     int columns = Convert.ToInt32(Console.ReadLine());
// //     Console.Write("Введите минимальное значение элементов в массиве: ");
// //     int minValue = Convert.ToInt32(Console.ReadLine());
// //     Console.Write("Введите максимальное значение элементов в массиве: ");
// //     int maxValue = Convert.ToInt32(Console.ReadLine());

// //     int [,] array = new int [rows, columns];

// //     for (int i = 0; i < rows; i++) 
// //         for (int j = 0; j < columns; j ++)
// //             array[i,j] = new Random().Next(minValue,maxValue+1);
// //     return array;
// // }

// void ShowArray (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i ++){
//         for (int j = 0; j < array.GetLength(1); j ++){
//             Console.Write(array[i,j] + " ");
//         } Console.WriteLine();
//     } Console.WriteLine();
// }


// int [,] ProductArrays (int [,] firstArray, int[,] secondArray){
    
//     int [,] resultMatrix = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

//     if (firstArray.GetLength(0) == secondArray.GetLength(1) || secondArray.GetLength(0) == firstArray.GetLength(1)){
//         for (int i = 0; i < firstArray.GetLength(0); i++){
//             for (int j = 0; j < firstArray.GetLength(1); j ++){
//                 int sum = 0;
//                 for (int k = 0; k < firstArray.GetLength(1); k++){
//                     sum += firstArray[i,k] * secondArray[k,j];
//                 } resultMatrix[i,j] = sum;
//             }
//         }
//     } return resultMatrix;
// }



// int [,] firstArray = {{2,4},{3,2}}; //CreateArray();
// int [,] secondArray = {{3,4}, {3,3}};//CreateArray();
// ShowArray(firstArray);
// ShowArray(secondArray);

// int [,] newArray = ProductArrays(firstArray, secondArray);


// ShowArray(newArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:



int [,] CreateArray (int size){
    
    int[,] array = new int[size, size];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size){
        array[i, j] = num;
        if (i <= j + 1 & i + j < size - 1)
            ++j;
        else if (i < j & i + j >= size - 1)
            ++i;
        else if (i >= j & i + j > size - 1)
            --j;
        else
            --i;
        num ++;
    } return array;
}



void ShowArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i ++){
        for (int j = 0; j < array.GetLength(1); j ++){
            Console.Write(array[i,j] + " ");
        } Console.WriteLine();
    } Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 

int [,] newArray = CreateArray(size);
ShowArray(newArray);