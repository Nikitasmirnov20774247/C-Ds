﻿int i = 1;
bool not = true;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 == 0)
        {
            Console.Write(i + ", ");
            not = false;
        }
        i++;
}
if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}