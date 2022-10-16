//Урок 1. Знакомство с языком программирования С#

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if( a > b ){
    Console.WriteLine($"max = {a}, min = {b}");
}
else{
    Console.WriteLine($"max = {b}, min = {a}");
}



//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.


/*Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if( max > b){
    if( max > c){
        Console.WriteLine($"max number = {max}");
    }
    else{
        max = c;
        Console.WriteLine($"max number = {max}");
    }
}
else{
    max = b;
    if( max > c){
       Console.WriteLine($"max number = {max}");
    }
    else{
        max = c;
        Console.WriteLine($"max number = {max}"); 
    }
}*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


/*Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if( number % 2 == 0){
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}*/


//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.


/*Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());*/


/*for( int i = 1; i <= number; i++){
    if(i % 2 == 0){
        Console.Write(i + " ");
    }
}*/

// 2 решение

/*if (number % 2 == 0 ){
    for( int i = 1; number > i;){
        Console.Write( number + " ");
        number -= 2;
    }
}
else{
    number -= 1;
    for( int i = 1; number > i;){
        Console.Write( number + " ");
        number -= 2;
    }
}*/
