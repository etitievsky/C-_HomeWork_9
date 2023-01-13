// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumNumbers(int a, int b)
{
    if(a>b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    if(a==b) return b;
    return (a + SumNumbers(a+1, b));
}

int m = EnterData("Введите число M: ");
int n = EnterData("Введите число N: ");
Console.Write("Сумма чисел в промежутке от M до N = "+SumNumbers(m, n));
