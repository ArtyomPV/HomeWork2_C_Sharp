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

/*
Получить число, проверить его разрядность, если разрядность меньше трех 
то  выводим надпись, введенное число меньше 3 символови выявить третью цифру слева невозможно,
иначе вычисляем количество разрядов, введенного числа (bitDepth).отсекаем те разряды которые, 
больше трех, получаем трехзначное число. Из полученного числа, делением с остатком п=олучаем искомое число.
*/
// ввод числа
int InputNumber()
{
    Console.Write("Enter any  positive number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// поиск третьей цифры введенного числа
void SearchThirdFigure(int num)
{
    int tempNum = num; 
    int count = 0;
    int index = 1; 
    
    if (num < 100) Console.WriteLine("Third simbol is absent.");
    else
    {
        while (tempNum != 0)
        {
            tempNum = tempNum / 10;
            count++;
        }
        count = count - 3;
        for(int i = 0; i<count; i++){
            index = index * 10;
        }
            int figure = (num/index)%10;
        Console.WriteLine($"Third simbol is {figure}");
    }
}

int enteredNumber = InputNumber();
SearchThirdFigure(enteredNumber);


//================== Задача 15 ========================