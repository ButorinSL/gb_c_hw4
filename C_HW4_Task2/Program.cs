// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message) // Функция приема и перевода данных от юзера в интежер
{
    System.Console.Write(message);// выводим приглашение к вводу
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); // переводим строку в число
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число:");
System.Console.WriteLine($"Сумма всех чисел в числе {number} равна = {SumAllDigit(number)}");
