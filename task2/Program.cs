
// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4
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
int[] myArray = GenerateArray(10, 1, 99);
// System.Console.Write("["+ string.Join(" ", myArray) + "]");
// Создать функцию вывода массива в терминал 
void PrintArray(int[] array)
{
    System.Console.Write("["+ string.Join(", ", array) + "]");
}
//и вывести массив для проверки
PrintArray(myArray);
//  Решение задачи
int count = 0;
for (int i = 0; i < 10; i++) 
{
    if (myArray[i] % 2 ==0) count = count +1;
}
System.Console.WriteLine($" => {count}");
