//Задача 19. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

// void Palindrome(int number){
//     int num1 = number / 1000;
//     int num2 = number % 100 / 10 + number % 10 * 10; // Выявляем последнюю и предпоследнюю цифру числа и меняем их местами
    
//     if (num1 == num2){
//         Console.WriteLine("Да");
//     } else Console.WriteLine("Нет");
// }

// void Request(){
//     Console.Write("Input a five-digit number: ");
//     int number = Convert.ToInt32(Console.ReadLine());

//     if (10000 <= number & number < 100000){
//         Palindrome(number);
//     } else{
//         Console.WriteLine("При вводе данных была допущена ошибка, пожалуйста повторите ввод: ");
//         Request();
//     }
// }

// Request();


//Задача 21. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(int xa, int ya, int za, int xb, int yb, int zb){
//     double abc = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
//     return abc;
// } 

// Console.Write("Введите значение xa: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение ya: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение za: ");
// int za = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение xb: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение yb: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение zb: ");
// int zb = Convert.ToInt32(Console.ReadLine());


// double distance = Distance(xa,ya,za,xb,yb,zb);
// Console.WriteLine($"Расстояние между точками ({xa}, {ya}), ({xb}, {yb}) и ({za},{zb}) равно {distance}");


//Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// void CubesOfNumbers(int number){
//     for ( int i = 1; i <= number; i++){
//         Console.WriteLine($"{i*i*i} ");
//     }
// }

// void NegativeCubesOfNumbers(int number){
//     for ( int i = -1; i >= number; i--){
//         Console.WriteLine($"{i*i*i} ");
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 0) Console.WriteLine("0");
// else if (number < 0) NegativeCubesOfNumbers( number );
// else CubesOfNumbers( number );
