
// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 
// массив [10 21 14 93 23] => 2
// Проба пера
// int N = new Random().Next(1, 10);
// System.Console.WriteLine(N);

// Создаем функцию по заполнению массива
int[] GenerateArray (int size, int leftRange, int rightRange) 
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++) 
    {
        tempArray[i] = rand.Next(leftRange, rightRange +1);
    }
return tempArray;
}
//Заполняем требуемый массив
int[] myArray = GenerateArray(10, 10, 99);
// System.Console.Write("["+ string.Join(" ", myArray) + "]");
// Создать функцию вывода массива в терминал 
void PrintArray(int[] array)
{
    System.Console.Write("["+ string.Join(", ", array) + "]");
}
//и вывести массив для проверки
PrintArray(myArray);
//  Решение задачи
int i = 0;
int count = 0;
while (i < 10) 
{
    if (myArray[i] >=20 && myArray[i] <=90) count =count +1;
    i++;
}
System.Console.WriteLine($" => {count}");
