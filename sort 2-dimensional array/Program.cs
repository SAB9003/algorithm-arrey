// See https://aka.ms/new-console-template for more information
Random random = new Random();
int size = 5, index = 0;
int[,] array = new int[size,size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        array[i,j] = random.Next(-100, 101);
    }
}
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($" {array[i,j],4} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int size_sort_array = size * size;
int[] sort_array = new int[size_sort_array];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        sort_array[index++] =array[i,j];
    }
}
Array.Sort(sort_array);
//for (int i = 0; i < size_sort_array; i++)
//{
//    for (int j = 0; j < size_sort_array-i-1; j++)
//    {
//        if (sort_array[j] > sort_array[j+1])
//        {
//            (sort_array[j], sort_array[j+1]) = (sort_array[j+1],  sort_array[j]);
//        }
//    }
//}
//Console.WriteLine();
//for (int i = 0; i < size_sort_array; i++)
//{
//    Console.Write($"{sort_array[i]} ");
//}
index = 0;
for (int i = 0; i < size; i++)
{
    for(int j = 0;j < size; j++)
    {
        array[i,j ]= sort_array[index++];
    }
} 
Console.WriteLine();
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($" {array[i, j],4} ");
    }
    Console.WriteLine();
}