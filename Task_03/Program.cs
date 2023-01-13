// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int AccermanFunc(int m, int n)
{
    if(m==0) return n+1;
    if(n==0) return AccermanFunc(m-1, 1);
    return AccermanFunc(m-1, AccermanFunc(m,n-1));
}

int m = EnterData("Введите число M: ");
int n = EnterData("Введите число N: ");
Console.Write($"A({m},{n}) = "+AccermanFunc(m, n));

