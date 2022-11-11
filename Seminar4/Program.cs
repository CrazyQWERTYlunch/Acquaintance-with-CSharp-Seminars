// Задание 1. Задача 25: Напишите программу, которая принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

// int DegreeOfNumber (int digit, int degree)
// {
//     int result = 1;
//     for (int i = 0; i < degree; i ++){
//         result *= digit;   
//     } return result;
// }

// Console.Write("Введите число, которое нужно возвести в степень: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Теперь, в какую степень: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{DegreeOfNumber(num,degree)}");

// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.


// int SumNumbers(int num){
//     int result = 0;
//     while (true){
//         if ( num > 0){
//             int temp = num % 10;
//             result += temp;
//             num /= 10;
//         } else break;
//     } return result;
// }

// Console.Write("Введите число: ");
// int numbers = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма цифр числа {numbers} составляет {SumNumbers(numbers)}");

// Задача 29: Напишите программу, которая создает массив заданного 
// пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

// int [] CreateArray( int lenght){
//     int [] array = new int[lenght];
//     for( int i = 0; i < lenght; i ++){
//         array[i] = new Random().Next(1, 100);
//     } return array;
// }

// void PrintArray(int [] array){
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]}, ");
//     } Console.Write("\b\b]");
// }

// Console.Write("Введите длину массива: ");
// int lenght = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateArray(lenght));