//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

double stepen(double X, double Y) 
{
    double result = Math.Pow(X, Y);
    return result;
}

Console.Clear();
Console.Write("Введите число A ");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите число B ");
double B = double.Parse(Console.ReadLine());

Console.WriteLine($"Число A в натуральной степени B равно {stepen(A,B)}");