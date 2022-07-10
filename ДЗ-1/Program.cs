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
//         Console.WriteLine($"Массив пустой!");
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

double[] CreateArray(int N, int start, int end){
    double[] RandomArray = new double[N];
    for (int i = 0; i < RandomArray.Length; i++){
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(double[] Array){
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++){
        Console.Write(Array[i]);
        if (i < Array.Length - 1){
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] InputArray(){
    Console.Clear();
    Console.Write("Введите количество элементов в массиве: ");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 2){
        Console.WriteLine("Необходимо минимум 2 элемента в массиве для решения данной задачи!");
        Console.Write("Введите количество элементов в массиве: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Задайте значения диапазона для создания массива:");
    Console.Write("1. Введите начальное значение диапазона: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. Введите конечное значение диапазона: ");
    int max = Convert.ToInt32(Console.ReadLine());
    while (max < min){
        Console.WriteLine("Конечное значение диапазона не может быть меньше начального значения!");
        Console.Write("2. Введите конечное значение диапазона: ");
        max = Convert.ToInt32(Console.ReadLine());
    }
    int[] InArray = {number, min, max};
    return InArray;
}
int[] InArray = InputArray();
double[] RandomArray = CreateArray(InArray[0], InArray[1], InArray[2]);
double minArray = RandomArray[0];
double maxArray = RandomArray[0];
for (int i = 0; i < RandomArray.Length; i++){
    if (RandomArray[i] > maxArray) maxArray = RandomArray[i];
    if (RandomArray[i] < minArray) minArray = RandomArray[i];
}
double DifMaxMin = maxArray - minArray;
Console.WriteLine("Разница между максимальным и минимальным значениями элементов массива:");
ShowArray(RandomArray);
Console.WriteLine($" -> {DifMaxMin}");
