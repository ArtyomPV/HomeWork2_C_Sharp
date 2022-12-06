//================== Задача 10 ======================== 
/*
Напишите программу, которая принимает 
на вход трехзначное число и на выходе 
показывает вторую цифру этого числа
*/

// int InputNummber()
// {
//     Console.Write("Введите трехзначное число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void SearchSecondFigure( int num)
// {
//     if (num > 99 && num <1000)
//     {
//         int result = (num/10)%10;
//         Console.WriteLine($"Второе число - {result}");
//     } 
//     else 
//     {
//         Console.WriteLine("Введено не трехзначное число! ");
//     }
// }

// SearchSecondFigure(InputNummber());

//================== Задача 13 ========================
/*
Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет
*/


// ввод числа
// int InputNumber()
// {
//     Console.Write("Enter any  positive number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// // поиск третьей цифры введенного числа
// void SearchThirdFigure(int num)
// {
//     int tempNum = num; 
//     int count = 0;
//     int index = 1; 
    
//     if (num < 100) Console.WriteLine("Third simbol is absent.");
//     else
//     {
//         while (tempNum != 0)
//         {
//             tempNum = tempNum / 10;
//             count++;
//         }
//         count = count - 3;
//         for(int i = 0; i<count; i++){
//             index = index * 10;
//         }
//             int figure = (num/index)%10;
//         Console.WriteLine($"Third simbol is {figure}");
//     }
// }

// int enteredNumber = InputNumber();
// SearchThirdFigure(enteredNumber);


//================== Задача 15 ========================
/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

int InputNumberOfWeek()
{
    Console.Write("Enter number day of week (1-7): ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void IsDayOff (int num)
{
    if(num < 1 || num > 7 ) 
    {
        Console.WriteLine("Entered a wrong number!");
    }
    else
    {
        if(num == 6 || num == 7) 
        {
            Console.Write("Yes, this day is a day off");
        }
        else
        {
            Console.Write("No, this day is not a day off");
        }
    }
}

int enteredNumber = InputNumberOfWeek();
IsDayOff(enteredNumber);