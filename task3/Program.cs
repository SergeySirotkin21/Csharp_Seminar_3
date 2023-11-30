
// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива
// [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28
// Создаем функцию для ввода размера массива
int ReadInt(string text) 
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// и ее используем
int size = ReadInt("Введите размер массива: ");
// объявляем массив из вещественных чисел
double[] array = new double[size];
// и его заполняем
Random rand = new Random();
for (int i =0; i < size; i++) 
{
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}
// проверяем что в массиве
System.Console.Write("["+ string.Join("  ", array) + "]");

//  Решение задачи
double max = array[0];
double min = array[0];
for (int i = 1; i < size; i++) 
{
   if (array[i] > max) max = array[i];
   if (array[i] < min) min = array[i];
}
double delta = Math.Round(max - min, 2);
System.Console.WriteLine($"  => {delta}");
