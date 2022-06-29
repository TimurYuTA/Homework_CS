// ДЗ-1

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

// Console.Write("Введите число: " );
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
//     Console.Write("ДА, число чётное!");
// else
//     Console.Write("НЕТ, число нечётное!");


// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

// Console.Write("Введите число: " );
// int number = Convert.ToInt32(Console.ReadLine());
// int step = 2;

// if (number < 2)
//     Console.Write("Чётных чисел нет!");

// while (step <= number)
// {
//     Console.Write(step + "   ");
//     step += 2;
// }


// ДЗ-2

// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трёхзначное число: " );
int number = Convert.ToInt32(Console.ReadLine());

if (number > -1000 & number < -99 ^ number > 99 & number < 1000 ){
    int tens = number % 100 / 10;
    if (tens < 0){
        tens = tens * -1;
    }
    Console.Write("Вторая цифра числа " + number + " -> " + tens);
}
else{
    Console.Write("Число " + number + " не является трёхзначным!");
}
