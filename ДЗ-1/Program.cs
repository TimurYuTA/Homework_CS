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

// Console.Write("Введите пятизначное число: " );
// int number = Convert.ToInt32(Console.ReadLine());

// int first = number / 10000;
// int second = number / 1000 % 10;
// int fourth = number / 10 % 10;
// int fifth = number % 10;

// if (number > 9999 & number < 100000){
//     if (first == fifth & second == fourth){
//         Console.Write($"{number} -> да, введенное число является палиндромом");
//     }
//     else{
//         Console.Write($"{number} -> нет, введенное число не является палиндромом");
//     }        
// }
// else{
//     Console.Write($"Число {number} не является пятизначным");
// }


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// double distance3D (int x1, int y1, int z1, int x2, int y2, int z2){
//     return Math.Sqrt ((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
// }

// Console.WriteLine("Введите координаты первой точки - A:");
// Console.Write("Ax = ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ay = ");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Az = ");
// int Az = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки - B:");
// Console.Write("Bx = ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("By = ");
// int By = Convert.ToInt32(Console.ReadLine());
// Console.Write("Bz = ");
// int Bz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Растояние между точкми A и B равно: {Math.Round(distance3D(Ax, Ay, Az, Bx, By, Bz), 2)}");


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write($"{number} -> ");

// if (number >=0){
//     for (int i = 1; i <= number; i++){
//         Console.Write($"{Math.Pow(i, 3)} ");
//     }
// }
// else{
//     for (int i = -1; i >= number; i--){
//         Console.Write($"{Math.Pow(i, 3)} ");
//     }
// }



// ДЗ-4

// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

// double natPow (int i, int power){
//     return Math.Pow (i, power);
// }
// Console.Clear();
// Console.Write("Введите необходимое количество повторений: ");
// int repeat = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < repeat; i++)
// {
//     Console.Write("Введите число A: ");
//     int A = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите степень B: ");
//     int B = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"Число {A} в натуральной степени {B} -> {natPow(A, B)}");
//     Console.WriteLine("----------------------------------");
// }


// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int sumN (int N)
{
    int partN = N;
    int sum = 0;
    while (N > 9)
    {
        partN = N % 10;
        sum = sum + partN;
        N = N / 10;
    }
    sum = sum + N;
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} равна -> {sumN(number)}");
