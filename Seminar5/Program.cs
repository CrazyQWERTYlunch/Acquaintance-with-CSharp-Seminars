// //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// // которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

// int [] CreatArray(int length){
//     int [] array = new int[length];
//     for (int i = 0; i < length; i++){
//         array[i] = new Random().Next(100,1000);
//     } return array;
// }


// int QuantityNumbers(int [] array){
//     int score = 0;
//     for (int i = 0; i < array.Length; i ++){
//         if (array[i] % 2 == 0) score += 1;
//     } return score;
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// // void PrintArray(int [] array){
// //     Console.Write("[");
// //     for (int i = 0; i < array.Length; i++){
// //         Console.Write($"{array[i]} ");
// //     } Console.WriteLine($"\b]");
// // } // Если есть желание увидеть созданный массив

// int [] array = CreatArray(size);

// // PrintArray(array); // вызов функции, показывающий массив 

// Console.WriteLine($"Количество чётных элементов массива равняется {QuantityNumbers(array)}");


// Задача 36: Задайте массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 | [-4, -6, 89, 6] -> 0


// int [] CreatArray(int length){
//     int [] array = new int[length];
//     for (int i = 0; i < length; i++){
//         array[i] = new Random().Next(100,1000);
//     } return array;
// }

// int SumNumbers(int [] array){
//     int result = array[1]; 
//     for (int i = 3; i < array.Length; i += 2){
//         result += array[i];
//     } return result;
// }


// // void PrintArray(int [] array){
// //     Console.Write("[");
// //     for (int i = 0; i < array.Length; i++){
// //         Console.Write($"{array[i]} ");
// //     } Console.WriteLine($"\b]");
// // }


// Console.Write("Укажите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] array = CreatArray(size);

// // PrintArray(array); 
// Console.WriteLine($"Сумма чётных элементов массива равна {SumNumbers(array)}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2



double [] InputArray(int lenght){
    double [] array = new double[lenght];
    for (int i = 0; i < lenght; i++){
        Console.Write($"Введите значение {i + 1} элемента: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }return array;
}


void PrintArray(double [] array){
    Console.Write("Разница между максимальным и минимальным элементами массива [");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} | "); // "|" - добавлена для удобства в разделении элементов
    } Console.WriteLine($"\b] составляет {DiffMinMax(array)}");
}

double DiffMinMax( double [] array){
    double min = array[0];
    double max = array[0];
    double result = 0;
    
    for (int i = 1; i < array.Length; i++){
        if ( array[i] < min ) min = array[i];
        else if (array[i] > max ) max = array[i];
    } return result = max - min;
}
Console.Write("Укажите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = InputArray(size);

PrintArray(array); 