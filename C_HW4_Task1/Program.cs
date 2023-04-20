// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message) //ReadInt - функция ввода данных пользователем с консоли, message - параметр
{
    Console.Write($"{message}"); // Вызов функции печати в консоль
    return Convert.ToInt32(Console.ReadLine()); ; // Возвращаемое значение
}

int numberA = ReadInt("Введите основание степени -> A = ");
int numberB = ReadInt("Введите показатель степени -> B = ");

bool ValdaiteNumberBNatural(int number)   // проверяем является ли введенное число показателя степени натуральным
{
    if (number < 1)
    {
        System.Console.WriteLine("Вы ввели не натуральный показатель степени, пожалуйста повторите ввод");
        return false;
    }
    return true;
}

int numberC = numberA;

int j = 1;
while (j < numberB)
    {
    numberC = numberC * numberA;
    j++;
    }
if (ValdaiteNumberBNatural(numberB))   //Если по результатам проверки на натуральность показателя все ок
{
    System.Console.WriteLine($"Введеное Вами число {numberA} в степени {numberB} = {numberC}");
}

