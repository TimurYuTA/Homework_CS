﻿// ДЗ-1

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

// Console.Write("Введите трёхзначное число: " );
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > -1000 & number < -99 ^ number > 99 & number < 1000 ){
//     int tens = number % 100 / 10;
//     if (tens < 0){
//         tens = tens * -1;
//     }
//     Console.Write("Вторая цифра числа " + number + " -> " + tens);
// }
// else{
//     Console.Write("Число " + number + " не является трёхзначным!");
// }


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// Console.Write("Введите число: " );
// int number = Convert.ToInt32(Console.ReadLine());
// int numberOrig = number;
// int thousand = number;

// if (number < 0){
//     number = number * -1;
//     thousand = number;
// }

// while (thousand > 999){
//     number = number / 10;
//     thousand = number;
// }
// if (number < 100){
//     Console.WriteLine("В числе " + numberOrig + " - третьей цифры нет!");
// }
// else{
//     int third = thousand % 10;
//     Console.WriteLine("Третья цифра числа " + numberOrig + " -> " + third);
// }


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

// Console.Write("Введите номер дня недели (ПН-1 ... ВС-7): " );
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 1 ^ number > 7){
//     Console.Write("Вы ввели некорректный номер");
// }
// else{
//     if (number < 6){
//         Console.Write(number + "-й день - Эх... он не является выходным...");
//     }
//     if (number > 5){
//         Console.Write(number + "-й день - Ура! Это выходной!");
//     }
// }


// ДЗ-3

// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: " );
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 10000;
int second = number / 1000 % 10;
int fourth = number / 10 % 10;
int fifth = number % 10;

if (number > 9999 & number < 100000){
    if (first == fifth & second == fourth){
        Console.Write($"{number} -> да, введенное число является палиндромом");
    }
    else{
        Console.Write($"{number} -> нет, введенное число не является палиндромом");
    }        
}
else{
    Console.Write($"Число {number} не является пятизначным");
}
