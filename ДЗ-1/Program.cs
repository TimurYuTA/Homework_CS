// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите число: a = " );
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: b = " );
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     Console.WriteLine("max = " + a + ", min = " + b);
// if (a < b)
//     Console.WriteLine("max = " + b + ", min = " + a);
// if (a == b)
//     Console.Write("Числа равны");


// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

// Console.Write("Введите число: a = " );
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: b = " );
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: c = " );
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > a) max = b;
// if (c > a) max = c;
// if (b > c) max = b;

// Console.Write("max = " + max);


// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число: " );
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.Write("ДА, число чётное!");
else
    Console.Write("НЕТ, число нечётное!");
