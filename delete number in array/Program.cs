// See https://aka.ms/new-console-template for more information
Random random = new Random();
int size = 10;
int[] arrey = new int[size]; 
for (int i = 0; i < size; i++)
{
    arrey[i] = random.Next(-10, 11);
}
Console.WriteLine("Array of {sixe} digits:\nArray:");
foreach (int item in arrey)
{
    Console.Write($"{item} ");
}
Console.WriteLine("\nInput of the number you want to delete (indexes start with 1)");
int index = int.Parse(Console.ReadLine());
if (index > size || index <= 0)
{
    Console.WriteLine("Error");
    return;
}
int[] new_array = new int[size-1];
index--;
for (int i = 0;i < index; i++)
{
    new_array[i] = arrey[i];
}
for (int i = index; i < size-1; i++)
{
    new_array[i] = arrey[i+1];
}
//arrey = new_array;
arrey = null; // Я не знаю як удалити масив але можу щоб він нічого не означав
Console.WriteLine("New array:");
foreach (int item in new_array)
{
    Console.Write($"{item} ");
}
