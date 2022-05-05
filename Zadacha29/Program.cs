/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Нужно пользователю ввести строку - ряд чисел через запятую, а программа превращает эту строку в 
полноценный массив и выводит.*/

Console.WriteLine("Введите 8 чисел через запятую: ");
string numbers = Console.ReadLine();
int count = numbers.Length;
string [] array = new string[8];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    string m = string.Empty;
    while(numbers[j]!= ',')
    {
    string n = Convert.ToString(numbers[j]);
    m = m + n;
    j++;
    if (j == count)
        break;
    }
    array[i]=m;
    j++;
    Console.Write($"{array[i]} ");
}

