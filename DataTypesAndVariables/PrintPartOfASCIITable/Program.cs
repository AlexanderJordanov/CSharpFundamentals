﻿int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

for (int i = startIndex; i <= endIndex; i++)
{
    char index = (char)i;
    Console.Write($"{index} ");
}