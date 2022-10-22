//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. БЕЗ ИСПОЛЬЗОВАНИЯ СТРОК

int FindThirdDigit(int number){
    int numberMin = 100;
    int numberMax = 1000;
    int divider = 1;
    while (true) {
        if (numberMin <= number & number < numberMax){
        int result = number / divider % 10;
        return result;
        } else {   
            numberMin *= 10;
            numberMax *= 10;
            divider *= 10;
        }
    }
}

Console.Write("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());

if ( number > 100){
    int result = FindThirdDigit(number);
    Console.WriteLine(result);
} else{
     Console.WriteLine("Третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// void Request(){
//     Console.Write("Input number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
    
//     if ( 0 < number & number < 8){
//         CheckWeekends(number);
//     } else {
//         Console.WriteLine("Вы совершили ошибку ввода, пожалуйста, введите число от 1 до 7: ");
//         Request();
//     }
// }

// void CheckWeekends(int number){
//     if ( number > 5){
//          Console.WriteLine("Да");
//     } else{
//         Console.WriteLine("Нет");
//     }
// }   

// Request();
