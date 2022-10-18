//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int summa(int X) 
{
    int result = 0;
    do {
        result = result + X % 10;
        X = X / 10;
    }
    while (X>0);
    return result;
}

Console.Clear();
Console.Write("Введите число для анализа ");
int N = int.Parse(Console.ReadLine());


Console.WriteLine($"Сумма цифр в числе {N} равна {summa(N)}");