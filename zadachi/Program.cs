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

zadacha41();