// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
string str = number.ToString();
int[] b = new int[3];

if (amount < 3 || amount > 3)
{
    Console.WriteLine ("Вы ввели не трехзначное число");
}
else 
{
    for( int i=0; i< 3; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
Console.WriteLine($"Вторая цифра числа {number} - {b[1]}");
}