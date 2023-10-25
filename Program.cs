// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным
// элементом массива.
Console.WriteLine("Введите размер массива");
int Length = Convert.ToInt32(Console.ReadLine());

//double min = 0;

double[ ] array = new double[Length];

for (int i = 0; i < Length; i++)
{
    double a = new Random().Next(100, 10000);
    double b = a / 100;
    array[i] = b;
    Console.Write(array[i] + " ");
}
 for (int i = 0; i < (Length - 2); i++)
 {
    double max = array[i];
    if(array[i + 1] > max) max = array[i + 1];
    if(array[i + 2] > max) max = array[i + 2];
    i++;
    Console.WriteLine(" -" + max);
  
 }
    

