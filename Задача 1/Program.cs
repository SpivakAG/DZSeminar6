// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите длину массива");

int length = Convert.ToInt32(Console.ReadLine());
if (length <= 0) Console.WriteLine("Длина массива не может быть отрицательной или равняться нулю");
else
{
    int[] array = new int[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < length; i++)
    {

        if (array[i] > 0) count++;
    }

    Console.WriteLine($"Количество положительных чисел равно {count}");
}