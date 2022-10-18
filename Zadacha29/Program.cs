//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]

//6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

int [] MakeArray(int Dlina, int Max) 
{
    int [] result = new int[Dlina];
    Random rnd = new Random();
    for (int i = 0; i < Dlina; i++)
    {
        result[i] = rnd.Next(1, Max);        
    }
    return result;
}

void PrintArray(int [] Array)
{
    int Dlina = Array.Length;
    Console.Write("[");
    for (int i = 0; i < Dlina-1; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.WriteLine($"{Array[Dlina-1]}]");
}


Console.Clear();
Console.Write("Введите количество элементов в массиве ");
int Kolvo = int.Parse(Console.ReadLine());
Console.Write("Массив будет сгенерирован из случайных чисел от 1 до N. Введите N ");
int MaxRand = int.Parse(Console.ReadLine());

int [] GeneratedArray = MakeArray(Kolvo, MaxRand);
PrintArray(GeneratedArray);