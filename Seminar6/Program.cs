// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CheckingForPositivity(int [] array){
//     int result = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] > 0) result ++;
//     } return result;
// }

// Console.Write("Введите элементы через пробел: ");
// int [] userNumbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

// // Первые неудачные попытки
// /*int [] userNumbers = new int [] { }; 
// int count = 0;
// while (true){
//     Console.Write("Введите число: ");
//     string temp = Console.ReadLine();
//     if (temp == "q"){
//         Console.WriteLine("Хо-хо, ха-ха");
//         break;
//     } else {
//         int a = Convert.ToInt32(temp);
//         userNumbers[count] = a;
//         count ++;    
//     }
// }*/

// Console.WriteLine(CheckingForPositivity(userNumbers));


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void FindingIntersections(double b1, double k1, double b2, double k2){
    if (k1 == k2){
        Console.WriteLine("Прямые параллельны");
    } else if ((k1 == k2) && (b1 == b2)){
        Console.WriteLine("Прямые совпадают");
    } else {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine(x);
        Console.WriteLine($"Прямые пересекаются в точках: {x}, {y}");
    } 
}


Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
FindingIntersections(b1, k1, b2, k2);

