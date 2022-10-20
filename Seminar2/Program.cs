// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int SecondDigit(int number){
    return (number / 10) % 10;
}

Console.Write("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecondDigit(number));

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

/*int FindThirdDigit(int number, int index){
    int divider = 1;
    for (int i = 3; i < index; i++){
        divider *= 10;
    }
    int result = number / divider % 10;
    return result;
}


Console.Write("Input number: ");

string number = (Console.ReadLine());

int num = Convert.ToInt32(number);

int index = Convert.ToInt32(number.Length);


if ( num > 100){
    int result = FindThirdDigit(num,index);
    Console.WriteLine(result);
}
else{
     Console.WriteLine("Третьей цифры нет");
}*/

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*bool CheckWeekends(int number){
    if (number > 5){
        return true;
    }
    return false;
}

Console.Write("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckWeekends(number);

if (result){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}*/