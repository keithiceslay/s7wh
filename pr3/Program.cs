// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random rnd = new Random();
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbersArray = new double [m,n];
FillArrayRandomNumbers(numbersArray);
PrintArray(numbersArray);
AverageInColumn(numbersArray);

void AverageInColumn (double[,] array)
{
    for (int j = 0; j < numbersArray.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbersArray.GetLength(0); i++)
    {
        avarage = (avarage + numbersArray[i, j]);
    }
    avarage = avarage / n;
    Console.WriteLine($"Среднее значение в столбце {j+1} = " + avarage + "; ");
}
Console.WriteLine();
}

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next();
        }
    }
}

void PrintArray(double[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{array[i,j]}    ");
        }
        Console.WriteLine();
    }
}