// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.


// void PrintNumbers(int n){
//     if (n > 1) {
//         Console.Write($"{n} "); PrintNumbers(n -1);
//     } else Console.Write($"{1}");
// }

// Console.Write("Введите значение числа N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int SumDigits(int m, int n){
//     if ( Math.Min(m,n) != Math.Max(m,n)) return Math.Max(n,m) + SumDigits(Math.Min(m,n), Math.Max(m,n)-1);
//     else return Math.Max(n,m);
// }


// Console.Write("Введите значение числа N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение числа M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{SumDigits(m,n)}");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.




int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");