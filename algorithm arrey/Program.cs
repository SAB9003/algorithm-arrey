// See https://aka.ms/new-console-template for more information
Random random = new Random();
int[] arrey = new int[10]; //{1,2,3,4,5,6,7,8,9,9};
int max, max2;
for (int i = 0; i < 10; i++)
{
    arrey[i] = random.Next(-10, 11);
}
foreach (int item in arrey)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
max = -12;
max2 = -12;
for (int i = 1; i < 10; i++)
{
    if (arrey[i] > max)
    {
        max2 = max;
        max = arrey[i];
    }
    //Якщо max можу дорівнювати max2
    else if (arrey[i] > max2)
    {
        max2 = arrey[i];
    }
    //Якщо max не можу дорівнювати max2
    //else if (arrey[i] > max2 && arrey[i] != max)
    //{
    //    max2 = arrey[i];
    //}
}
Console.WriteLine($"The second maximum number is {max2}");