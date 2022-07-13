// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
    
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void Array(int[,] array)
{
    
    int a = Prompt("Введите номер строки > ");
    int b = Prompt("Введите номер столбца > ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (a <= array.GetLength(0) && b <= array.GetLength(1))
            {
                
                Console.WriteLine($"Значение элемента массива = {array[a - 1, b - 1]}");
                return;
            }
    }
            if(a > array.GetLength(0) && b > array.GetLength(1))
            {
                Console.WriteLine(" Элемента по заданной позиции не существует ");
            }
    }


int rows = Prompt("Введите количество строк > ");
int columns = Prompt("Введите количество столбцов > ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
Array(myArray);