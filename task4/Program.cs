
// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]
// Создаем функцию для ввода числа
int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// и ее используем
int N = ReadInt("Введите натуральное число от 1 до 100000 N=: ");
if (N >99999)
{
    System.Console.WriteLine("Введено не верное число");
}
int M = N;
int[] array = new int[5];
int i =0;
while (N>0) 
{
    array[5-1-i] = N%10;
    N/=10;
     i= i + 1;
}
int size = i;
int[] newarray = new int[size];
for ( int j = 0; j < size; j++)
{
newarray[j] = array[j + 5 - size];
}

 System.Console.Write(M + " =>  ["+ string.Join("  ", newarray) + "]");
