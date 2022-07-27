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

// int sumN (int N)
// {
//     int partN = N;
//     int sum = 0;
//     while (N > 9)
//     {
//         partN = N % 10;
//         sum = sum + partN;
//         N = N / 10;
//     }
//     sum = sum + N;
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма цифр числа {number} равна -> {sumN(number)}");


// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// int[] CreateArray (int N, int start, int end)
// {
//     int[] Array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }  

// void ShowArray (int[] myArray)
// {
//     Console.Write("[");
//     for (int i = 0; i < myArray.Length; i++){
//         Console.Write(myArray[i]);
//         if (i < myArray.Length - 1){
//             Console.Write(", ");
//         }
//     }
//     Console.WriteLine("]");
// }

// Console.Clear();
// Console.Write("Введите количество элементов в массиве: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите диапазон чисел для генерации элементов в массиве");
// Console.Write("Введите начало диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateArray(number, min, max);

// Console.Write($"Сгенерированный массив из {number} элементов -> ");
// ShowArray(myRandomArray);


// ДЗ-5

// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int N, int start, int end){
//     int[] Array = new int[N];
//     for (int i = 0; i < Array.Length; i++){
//         Array[i] = new Random().Next(start, end + 1);
//     }
//     return Array;
// }
// void ShowArray(int[] Array){
//     Console.Write("[");
//     for (int i = 0; i < Array.Length; i++){
//         Console.Write(Array[i]);
//         if (i < Array.Length - 1){
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }
// int[] inputArray(){
//     Console.Clear();
//     Console.Write("Введите количество элементов в массиве: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     while (number < 1){
//         Console.WriteLine("Массив пустой!");
//         Console.Write("Введите количество элементов в массиве: ");
//         number = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Введите диапазон для создания массива в пределах от 100 до 999");
//     Console.Write("Введите начало диапазона: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     while (min < 100 || min > 999){
//         Console.WriteLine("Ошибка! Диапазон для создания массива должен быть в пределах от 100 до 999");
//         Console.Write("Введите начало диапазона: ");
//         min = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.Write("Введите конец диапазона: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     while (max < 100 || max > 999 || max < min){
//         Console.WriteLine("Ошибка! Диапазон для создания массива должен быть в пределах от 100 до 999. Значение конца диапазона не должно быть меньше его начала!");
//         Console.Write("Введите конец диапазона: ");
//         max = Convert.ToInt32(Console.ReadLine());
//     }
//     int[] ArrayIn = {number, min, max};
//     return ArrayIn;
// }

// int[] ArrayIn = inputArray();
// int[] Array = CreateArray(ArrayIn[0], ArrayIn[1], ArrayIn[2]);
// int count = 0;
// for (int i = 0; i < Array.Length; i++){
//     if (Array[i] % 2 == 0 ){
//         count ++;
//     }
// }
// Console.WriteLine("Количество чётных чисел в массиве:");
// ShowArray(Array);
// Console.Write($" -> {count}");


// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

// int[] CreateArray(int N, int start, int end){
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < RandomArray.Length; i++){
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] Array){
//     Console.Write("[");
//     for (int i = 0; i < Array.Length; i++){
//         Console.Write(Array[i]);
//         if (i < Array.Length - 1){
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }
// int[] InputArray(){
//     Console.Clear();
//     Console.Write("Введите количество элементов в массиве: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     while (number < 1){
//         Console.WriteLine("Массив пустой!");
//         Console.Write("Введите количество элементов в массиве: ");
//         number = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Задайте значения диапазона для создания массива:");
//     Console.Write("1. Введите начальное значение диапазона: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("2. Введите конечное значение диапазона: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     while (max < min){
//         Console.WriteLine("Конечное значение диапазона не может быть меньше начального значения!");
//         Console.Write("2. Введите конечное значение диапазона: ");
//         max = Convert.ToInt32(Console.ReadLine());
//     }
//     int[] InArray = {number, min, max};
//     return InArray;
// }
// int[] InArray = InputArray();
// int[] RandomArray = CreateArray(InArray[0], InArray[1], InArray[2]);
// int sumOdd = 0;
// for (int i = 0; i < RandomArray.Length; i+=2){
//     sumOdd = sumOdd + RandomArray[i];
// }
// Console.WriteLine("Cумма элементов массива, стоящих на нечётных позициях:");
// ShowArray(RandomArray);
// Console.WriteLine($" -> {sumOdd}");


// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива

// double[] CreateArray(int N, int start, int end){
//     double[] RandomArray = new double[N];
//     for (int i = 0; i < RandomArray.Length; i++){
//         RandomArray[i] = Math.Round(new Random().Next(start, end) + new Random().NextDouble(), 1);
//     }
//     return RandomArray;
// }
// void ShowArray(double[] Array){
//     Console.Write("[");
//     for (int i = 0; i < Array.Length; i++){
//         Console.Write(Array[i]);
//         if (i < Array.Length - 1){
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }
// int[] InputArray(){
//     Console.Clear();
//     Console.Write("Введите количество элементов в массиве: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     while (number < 1){
//         Console.WriteLine("Массив пустой!");
//         Console.Write("Введите количество элементов в массиве: ");
//         number = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Задайте значения диапазона для создания массива:");
//     Console.Write("1. Введите начальное значение диапазона: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("2. Введите конечное значение диапазона: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     while (max == min){
//         Console.WriteLine("Диапазон не может быть равен нулю для решения данной задачи!");
//         Console.Write("1. Введите начальное значение диапазона: ");
//         min = Convert.ToInt32(Console.ReadLine());
//         Console.Write("2. Введите конечное значение диапазона: ");
//         max = Convert.ToInt32(Console.ReadLine());
//     }
//     int A = min;
//     int B = max;
//     if (max < min){
//         A = max;
//         B = min;
//     }
//     int[] InArray = {number, A, B};
//     return InArray;
// }
// int[] InArray = InputArray();
// double[] RandomArray = CreateArray(InArray[0], InArray[1], InArray[2]);
// double minArray = RandomArray[0];
// double maxArray = RandomArray[0];
// for (int i = 0; i < RandomArray.Length; i++){
//     if (RandomArray[i] > maxArray) maxArray = RandomArray[i];
//     if (RandomArray[i] < minArray) minArray = RandomArray[i];
// }
// double DifMaxMin = maxArray - minArray;
// Console.WriteLine("Разница между максимальным и минимальным значениями элементов массива:");
// ShowArray(RandomArray);
// Console.WriteLine($" -> {DifMaxMin}");



// ДЗ-6

// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void ShowArray(int[] Array){     // метод вывода массива в консоль
//     for (int i = 0; i < Array.Length; i++){
//         Console.Write(Array[i]);
//         if (i < Array.Length - 1){
//             Console.Write(", ");
//         }
//     }
// }
// int[] InArray(){     // метод ввода данных с консоли
//     int M = 0;
//     while (M < 1){
//         Console.Write("Введите количество сравниваемых чисел: ");
//         M = Convert.ToInt32(Console.ReadLine());
//         if (M < 1){
//             Console.WriteLine("Количество не можен быть отрицательным или равным нулю!");
//         }
//     }
//     int[] CreateArray = new int[M];
//     int count = 1;
//     for (int i = 0; i < CreateArray.Length; i++){
//         Console.Write($"Введите {count}-е число: ");
//         CreateArray[i] = Convert.ToInt32(Console.ReadLine());
//         count++;
//     }
//     return CreateArray;
// }

// int posNum(int[] Array){     // метод счёта количества чисел больше 0
//     int countI = 0;
//     for (int i = 0; i < Array.Length; i++){
//         if (Array[i] > 0) countI++;
//     }
//     return countI;
// }

// Console.Clear();
// int[] InputArray = InArray();
// Console.WriteLine("\nКоличество введённых чисел больше нуля:");
// ShowArray(InputArray);
// Console.WriteLine($" -> {posNum(InputArray)}\n");


// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Clear();
// Console.WriteLine("Введите значения k1 и b1 для прямой, заданной уравнением y = k1 * x + b1:");
// Console.Write("k1 = ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b1 = ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значения k2 и b2 для прямой, заданной уравнением y = k2 * x + b2:");
// Console.Write("k2 = ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b2 = ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2){
//     if (b1 == b2){
//         Console.WriteLine("\nТочек пересечения бесконечно много - пямые совпадают!\n");
//     }
//     else{
//         Console.WriteLine("\nТочек пересечения нет - пямые параллельны!\n");
//     }
// }
// else{
//     Console.WriteLine("\nКоординаты точки пересечения двух прямых при заданных значениях:\n");
//     double x = (b1 - b2)/(k2 - k1);
//     double y = k1 * x + b1;
//     Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})\n");
// }


// ДЗ-7

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateArray(int rows, int columns){
//     double[,] RandomArray = new double [rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             RandomArray[i, j] = new Random().NextDouble()*10;
//         }
//     }
//     return RandomArray;
// }
// void ShowArray(double[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateArray(m, n);
// ShowArray(myArray);


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateArray(int rows, int columns, int start, int end){
//     int[,] RandomArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             RandomArray[i, j] = new Random().Next(start, end);
//         }
//     }
//     return RandomArray;
// }
// void ShowArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение начала диапазона для создания массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение конца диапазона для создания массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("\nВведите индекс строки элемента в массиве: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца элемента в массиве: ");
// int j = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(m, n, min, max);
// ShowArray(myArray);

// if (i >= m || j >= n){
//     Console.WriteLine("\nТакого элемента нет\n");
// }
// else{
//     Console.WriteLine($"\nЭлемент на позиции [{i}, {j}] -> {myArray[i, j]}\n");
// }


// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateArray(int rows, int columns, int start, int end){
//     int[,] RandomArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             RandomArray[i, j] = new Random().Next(start, end);
//         }
//     }
//     return RandomArray;
// }
// void ShowArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение начала диапазона для создания массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение конца диапазона для создания массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(m, n, min, max);
// ShowArray(myArray);

// Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
// for (int j = 0; j < myArray.GetLength(1); j++){
//     double sumElementI = 0;
//     for (int i = 0; i < myArray.GetLength(0); i++){
//         sumElementI = sumElementI + myArray[i, j];
//     }
//     double average = sumElementI / myArray.GetLength(0);
//     Console.Write($"{average:f1} ");
// }



// ДЗ-8

// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateArray(int rows, int columns, int start, int end){
//     int[,] RandomArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             RandomArray[i, j] = new Random().Next(start, end + 1);
//         }
//     }
//     return RandomArray;
// }
// void ShowArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение начала диапазона для создания массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение конца диапазона для создания массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(m, n, min, max);
// ShowArray(myArray);

// Console.WriteLine("\nВ итоге получается вот такой массив:");

// for (int i = 0; i < myArray.GetLength(0); i++){
//     for (int j = 0; j < myArray.GetLength(1); j++){
//         for (int newJ = 0; newJ < myArray.GetLength(1) - 1; newJ++){
//             if (myArray[i, newJ] < myArray[i, newJ + 1]){
//                 int bufer = myArray[i, newJ];
//                 myArray[i, newJ] = myArray[i, newJ + 1];
//                 myArray[i, newJ + 1] = bufer;
//             }
            
//         }
//     }
// }
// ShowArray(myArray);


// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateArray(int rows, int columns, int start, int end){
//     int[,] RandomArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             RandomArray[i, j] = new Random().Next(start, end + 1);
//         }
//     }
//     return RandomArray;
// }
// void ShowArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение начала диапазона для создания массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение конца диапазона для создания массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(m, n, min, max);
// ShowArray(myArray);

// int minSum = 0;
// int minRow = 1;
// for (int j = 0; j < myArray.GetLength(1); j++){
//     minSum = minSum + myArray[0, j];
// }
// for (int i = 1; i < myArray.GetLength(0); i++){
//     int sum = 0;
//     for (int j = 0; j < myArray.GetLength(1); j++){
//         sum = sum + myArray[i, j];
//     }
//     if (sum < minSum){
//         minSum = sum;
//         minRow = i + 1;
//     }
// }
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow} строка\n");


// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] InputArray(int rows, int columns){
//     int[,] matrixArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             Console.Write($"Введите элемент матрицы с индексом {i+1}{j+1}: ");
//             matrixArray[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return matrixArray;
// }
// void ShowArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] CreateMatrix(){
//     Console.Write("Введите количество строк матрицы: ");
//     int Y = Convert.ToInt32(Console.ReadLine());
//     if (Y < 1){
//         Console.Write("Введите минимум одну строку: ");
//         Y = Convert.ToInt32(Console.ReadLine());   
//     }
//     Console.Write("Введите количество столбцов матрицы: ");
//     int X = Convert.ToInt32(Console.ReadLine());
//     if (X < 1){
//         Console.Write("Введите минимум один столбец: ");
//         X = Convert.ToInt32(Console.ReadLine());
//     }
//     int[,] Matrix = InputArray(Y, X);
//     return Matrix;
// }
// Console.Clear();
// Console.WriteLine("Задайте и заполните матрицу A:");
// int[,] matrixA = CreateMatrix();
// Console.WriteLine("\nМатрица A:");
// ShowArray(matrixA);

// Console.WriteLine("Задайте и заполните матрицу B:");
// int[,] matrixB = CreateMatrix();
// Console.WriteLine("\nМатрица B:");
// ShowArray(matrixB);

// if (matrixA.GetLength(1) != matrixB.GetLength(0)){
//     Console.WriteLine($"Матрицы А и B нельзя перемножить, т.к количество строк матрицы А ({matrixA.GetLength(1)}) не соответствует количеству столбцов матрицы В ({matrixB.GetLength(0)})\n");
// }
// else{
//     int[,] matrixAxB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixAxB.GetLength(0); i++){
//         int jB = 0;
//         for (int j = 0; j < matrixAxB.GetLength(1); j++){
//             int sum = 0;
//             for (int jA = 0; jA < matrixA.GetLength(1); jA++){
//                 sum = matrixA[i, jA] * matrixB[jA, jB] + sum;
//             }
//             matrixAxB[i, j] = sum;
//             jB++;
//         }
//     }
//     Console.WriteLine("Произведение матриц А на В:");
//     ShowArray(matrixAxB);
// }


// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] CreateArray(int volume, int rows, int columns){
//     int[,,] RandomArray = new int [volume, rows, columns];
//     for (int k = 0; k < volume; k++){
//         for (int i = 0; i < rows; i++){
//             for (int j = 0; j < columns; j++){
//                 int RandomElement = new Random().Next(10, 100);
//                 while (FindElement(RandomArray, RandomElement)){
//                     RandomElement = new Random().Next(10, 100);
//                 }
//                 RandomArray[k, i, j] = RandomElement;
//             }
//         }
//     }
    
//     return RandomArray;
// }
// bool FindElement(int[,,] array, int element){
//     for (int k = 0; k < array.GetLength(0); k++){
//         for (int i = 0; i < array.GetLength(1); i++){
//             for (int j = 0; j < array.GetLength(2); j++){
//                 if (array[k, i, j] == element){
//                     return true;
//                 }
//             }
//         }
//     }
//     return false;
// }
// void ShowArray(int[,,] Array){
//     Console.WriteLine();
//     for (int k = 0; k < Array.GetLength(0); k++){
//         Console.WriteLine($"Слой {k + 1}:");
//         for (int i = 0; i < Array.GetLength(1); i++){
//             for (int j = 0; j < Array.GetLength(2); j++){
//                 Console.Write($"{Array[k, i, j]} ({k},{i},{j})\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите количество слоёв (объём) массива: ");
// int Z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк в массиве: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int X = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = CreateArray(Z, Y, X);
// ShowArray(myArray);


// Задача 5. Заполните спирально массив 4 на 4.

// void ShowArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("\n");
// }
// Console.Clear();
// Console.WriteLine("Количество строк в массиве: 4");
// int Y = 4;
// Console.WriteLine("Количество столбцов в массиве: 4");
// int X = 4;
// int start = 10;
// int end = 99;

// int[,] SnakeArray = new int[Y, X];
// Console.WriteLine("\nЗаполнение сверху вправо ->:\n");
// for (int i = 0; i < 1; i++){
//     for (int j = 0; j < SnakeArray.GetLength(1); j++){
//         SnakeArray[i, j] = new Random().Next(start, end + 1);
//         ShowArray(SnakeArray);
//     }
// }
// Console.WriteLine("Заполнение справа вниз:\n");
// for (int i = 1; i < SnakeArray.GetLength(0); i++){
//     for (int j = 3; j < SnakeArray.GetLength(1); j++){
//         SnakeArray[i, j] = new Random().Next(start, end + 1);
//         ShowArray(SnakeArray);
//     }
// }
// Console.WriteLine("Заполнение справа налево <-:\n");
// for (int i = 3; i < SnakeArray.GetLength(0); i++){
//     for (int j = 2; j >= 0; j--){
//         SnakeArray[i, j] = new Random().Next(start, end + 1);
//         ShowArray(SnakeArray);
//     }
// }
// Console.WriteLine("Заполнение слева вверх:\n");
// for (int i = 2; i > 0; i--){
//     for (int j = 0; j < 1; j++){
//         SnakeArray[i, j] = new Random().Next(start, end + 1);
//         ShowArray(SnakeArray);
//     }
// }
// Console.WriteLine("Заполнение центра слева направо ->:\n");
// for (int i = 1; i < 2; i++){
//     for (int j = 1; j < 3; j++){
//         SnakeArray[i, j] = new Random().Next(start, end + 1);
//         ShowArray(SnakeArray);
//     }
// }
// Console.WriteLine("Заполнение центра справа налево <-:\n");
// for (int i = 2; i < 3; i++){
//     for (int j = 2; j > 0; j--){
//         SnakeArray[i, j] = new Random().Next(start, end + 1);
//         ShowArray(SnakeArray);
//     }
// }



// ДЗ-9

// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

// Console.Clear();
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < M){
//     int X = N;
//     N = M;
//     M = X; 
// }
// if (N < 1){
//     Console.WriteLine($"\nВ промежутке от {M} до {N} натуральных чисел нет!\n");
//     return;
// }
// Console.Write($"\nНатуральные числа в промежутке от {M} до {N} -> ");
// if (M < 1){
//     for (int i = 1; i <= N; i++){
//         Console.Write(i);
//         if (i < N){
//             Console.Write(", ");
//         }
//     }
// }
// else{
//     for (int i = M; i <= N; i++){
//         Console.Write(i);
//         if (i < N){
//             Console.Write(", ");
//         }
//     }
// }
// Console.WriteLine("\n");


// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных чисел в промежутке от M до N

// Console.Clear();
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// if (N < M){
//     int X = N;
//     N = M;
//     M = X; 
// }
// if (N < 1){
//     Console.WriteLine($"\nВ промежутке от {M} до {N} натуральных чисел нет!\n");
//     return;
// }
// Console.Write($"\nСумма натуральных чисел в промежутке от {M} до {N} -> ");
// if (M < 1){
//     for (int i = 1; i <= N; i++){
//         sum = sum + i;
//     }
// }
// else{
//     for (int i = M; i <= N; i++){
//         sum = sum + i;
//     }
// }
// Console.WriteLine($"{sum}\n");


// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int A(int m, int n){
    if (m == 0){
        return n + 1;
    }
    if (m > 0 && n == 0){
        return A(m - 1, 1);
    }
    else{
        return A(m - 1, A(m, n - 1));
    }
}
int InputNumber(){
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 0){
        Console.Write("Введите неотрицательное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

Console.Clear();
Console.Write("Введите число m: ");
int m = InputNumber();
Console.Write("Введите число n: ");
int n = InputNumber();

int AckermanFunction = A(m, n);
Console.WriteLine($"\nФункция Аккермана A({m}, {n}) = {AckermanFunction}\n");
