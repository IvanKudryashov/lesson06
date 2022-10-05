void zadacha41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Введите число M:");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    PrintArray(array);
    for (int i = 0; i < m; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Чисел больше нуля: {count}");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void zadacha43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    Console.WriteLine("Введите число b1:");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число k1:");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b2:");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число k2:");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
    if (k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"({Math.Round(x,2)}, {Math.Round(y,2)})");
    }
}

zadacha41();
//zadacha43();