// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string NaturalNumbers(int begin)
{
    if(begin==1) return begin.ToString();
    return (begin+", "+NaturalNumbers(begin-1));
}

int n = EnterData("Введите число N: ");
Console.Write(NaturalNumbers(n));
