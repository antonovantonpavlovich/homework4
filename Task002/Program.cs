/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string messege) 
{
int result = 0;
while (true)
{
Console.WriteLine(messege);
if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
{
    break;
}
else
{
    Console.WriteLine("Ввели некорректное число. Повторите ввод!");
}
}
return result;
}

long GetCountOfDigits(long number)
{
    long Final = number;
    
    while (number < 0)
    {
        number = number / 10;
        Final = Final % 10;
    }

    return Final;
}

int number = GetNumber ("Введите число");
long Final = GetCountOfDigits(number);
Console.WriteLine($"колличество цифр в числе {number} = {Final}");

