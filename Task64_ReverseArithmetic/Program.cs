/* Задача 64:
Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии. */

// Метод считывания.
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки введенного значения.
bool IsValidInput(int checkValue)
{
    return (checkValue >= 1);
}

// Метод формирования выводимого ряда чисел.
string reverseArithmeticSeries(int value, int start = 0)
{
    if (value > start)
    {
        return reverseArithmeticSeries(value, ++start) + $"{start}, ";
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine("Поиск всех натуральных чисел в промежутке от N до 1");
int n = GetNumFromUser("Введите число N: ");
bool isValid = IsValidInput(n);
if (isValid)
{
    string output = reverseArithmeticSeries(n);
    Console.WriteLine(output.Remove(output.Length - 2));
}
else
{
    Console.WriteLine("Ошибка. Введено некорректное значение числа N.");
}