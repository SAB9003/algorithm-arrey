// See https://aka.ms/new-console-template for more information
Random random = new Random();
int size = 5, sum = 0;
int[,] array = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        array[i, j] = random.Next(0, 11);
    }
}
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($" {array[i, j],3} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0;i < size; i++)
{
    sum += array[i, i];
}
Console.WriteLine($" {sum} ");
