// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным
// элементом массива.
Console.WriteLine("Введите размер массива");
int Length = Convert.ToInt32(Console.ReadLine());

double[] array = new double[Length];

for (int i = 0; i < Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
