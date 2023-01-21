// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay >= 1 && numberDay <= 5) 
{
    Console.WriteLine($"Введенное число {numberDay} рабочий день :(");
}
else if (numberDay >= 6 && numberDay <= 7)
{
    Console.WriteLine($"Введенное число {numberDay} ВЫХОДНОЙ!!!");
}
else
{
    Console.WriteLine($"Введенное число {numberDay} не является днем недели");
}