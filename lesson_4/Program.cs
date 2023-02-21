// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] Nol_Ed=new int[8];
int count = Nol_Ed.Length;

Console.Write("[");
for (int i=0; i < count; i++)
{
Nol_Ed[i]=new Random().Next(0,2);
if(i==count-1)
{
    Console.Write($"{Nol_Ed[i]}");
    break;
}
Console.Write($"{Nol_Ed[i]}, ");
}
Console.WriteLine("]");
