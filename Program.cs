// 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.WriteLine("Add m : ");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("Add n : ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
array[i, j] = rand.NextDouble() * 200 - 100;
}
}

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
System.Console.WriteLine($"{array[i, j]}");
}
System.Console.WriteLine("");
}



//50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

  Console.Write("Add m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Add n: ");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[m, n];
        Random rand = new Random();

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                array[i, j] = rand.NextDouble() * 200 - 100;
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write("{0:F2}\t", array[i, j]);
            }
            Console.WriteLine();
        }
        Console.Write("Add row number: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Add column number: ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < m && col >= 0 && col < n) {
            Console.WriteLine("Value at [{0}, {1}]: {2:F2}", row, col, array[row, col]);
        } else {
            Console.WriteLine("Does not exist");
        }