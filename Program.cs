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
 double max = array[0];
 for (int i = 0; i < (array.Length - 1); i++)
 {
        if(array[i + 1] > max) max = array[i + 1];
             
 }
//Console.Write(" -" + max);

double min = array[0];
 for (int i = 0; i < (array.Length - 1); i++)
 {
        if(array[i + 1] < min) min = array[i + 1];
             
 }
//Console.Write(" -" + min);
 double result = max - min;
Console.Write(" -" + result);


