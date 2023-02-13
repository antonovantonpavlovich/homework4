/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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

int SumNumber (int a, int b)
{
    int sum = a;
    
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
    }
    return sum; 
}

int a = GetNumber ("Введите первое число");
int b = GetNumber ("Введите второе число");
int sum = SumNumber (a, b);
Console.WriteLine ($"{a}, {b} -> {sum}");



































/*
Задача 24 (решает преподаватель): 
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
/*
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

int GetSum (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;  // sum = sum + i;
    }

    return sum;
}

int number = GetNumber ("Введите число больше 0");
int sum = GetSum (number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
*/
////////////////////////////////////////////
////////////////////////////////////////////
////////////////////////////////////////////
/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
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

int GetCountOfDigits(int number)
{
    int Final = 0;
    
    while (number != 0)
    {
        number = number / 10;
        Final = Final + 1;
    }

    return Final;
}

int number = GetNumber ("Введите число");
int Final = GetCountOfDigits(number);
Console.WriteLine($"колличество цифр в числе {number} = {Final}");
*/
////////////////////////////////////////
////////////////////////////////////////
////////////////////////////////////////
/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
/*
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
long SumNumber (long number)
{
    long proizv = 1;
    for (int i = 1; i <= number; i++)
    {
        proizv = proizv * i;
    }

    return proizv;
}
int number = GetNumber ("Введите число");
long proizv = SumNumber(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {proizv}");
*/
////////////////////////////////////////////
////////////////////////////////////////////
////////////////////////////////////////////
/*
Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*
int[] array = new int [8];
void InitArray (int[] array)
{
    int length = array.Length;
    int index = 0;
    Random rnd = new Random();
    while (index < length)
    {
        array[index] = rnd.Next(0,2);
        index ++;
    }

}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine (array[i]);
    }
}

InitArray(array);
PrintArray(array);
*/
/*
как вводить данные с массивами
*/
/*
Console.WriteLine ("Введите числа через пробел");
string [] strArray = Console.ReadLine().Split(' ');

int [] result = new int[strArray.Length];
for (int i = 0; i < result.Length; i++)
{
    result[i] = int.Parse(strArray[i]);
} 
Console.WriteLine(string.Join(' ', result));
*/
/*
книга
https://www.chitai-gorod.ru/product/master-klass-sovershennyy-kod-2047176
*/