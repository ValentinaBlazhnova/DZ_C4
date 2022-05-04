/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
string numberString = Console.ReadLine();
int sum = 0;
for (int i = 0; i < numberString.Length; i++)
{
    sum += Convert.ToInt32(numberString[i].ToString());
}
Console.WriteLine("Ответ: " + sum);