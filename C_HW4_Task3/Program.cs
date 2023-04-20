// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


//Ввод числа с экрана
int Prompt(string message) // Функция приема и перевода данных от юзера в интежер
{
    System.Console.Write(message);// выводим приглашение к вводу
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); // переводим строку в число
    return result;
}

// метод для получения случайных элементов массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // заполняем массив случайными числами от мин до макс
    }
    return array;
}

// вывод массива на печать в консоль
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}


int length = Prompt("Введите длинну массива = ");
int min = Prompt("Введите минимальное значение диаазона = ");
int max = Prompt("Введите максимальное значение диапазона = ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
System.Console.WriteLine();