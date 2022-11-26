// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Random rnd = new Random();
Console.WriteLine("Введите число, которое хотите найти");
int number = Convert.ToInt32(Console.ReadLine());
int[,] numbersArray = new int [10,10];
FillArrayRandomNumbers(numbersArray);
PrintArray(numbersArray);
if (CheckNumber(number) == numbersArray[10,10])
{
    Console.WriteLine("Такого числа в массиве нет");
}


int CheckNumber(int number)
{
    for (int i = 0; i < numbersArray.GetLength(1); i++)
    {
        for (int j = 0; j < numbersArray.GetLength(0);j++)
        {
            if (number == numbersArray[j,i]) 
            {
                Console.WriteLine ($"Число находиться в позиции: ");
                break;
                return numbersArray[j,i];
            }
        }
    }
    return numbersArray[10,10];

}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next();
        }
    }
}

void PrintArray(int[,] array)
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