﻿int days = int.Parse(Console.ReadLine());
double dailyPlunder =  double.Parse(Console.ReadLine());
double expectedPlunder = double.Parse(Console.ReadLine());

double totalPlunder = 0;

for (int i = 1; i <= days; i++)
{
    totalPlunder += dailyPlunder;

    if (i % 3 == 0)
    {
        totalPlunder += dailyPlunder * 0.5;
    }

    if (i % 5 == 0)
    {
        totalPlunder = totalPlunder * 0.7;
    }
}

if (totalPlunder >= expectedPlunder)
{
    Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
}
else
{
    double diff = 100.0 * totalPlunder / expectedPlunder;
    Console.WriteLine($"Collected only {diff:f2}% of the plunder.");
}