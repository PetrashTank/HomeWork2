// Напишите программу, которая выводит 
// третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
string str = number.ToString();
int[] b = new int[3];

if (amount < 3)
{
    Console.WriteLine ("Третьей цифры нет");
}
else 
{
    for( int i=0; i< 3; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
Console.WriteLine($"Третья цифра числа {number} - {b[2]}");
}