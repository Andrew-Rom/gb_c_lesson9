/* Задача 66:
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

// Метод считывания.
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки введенного значения.
bool IsValidInput(int minValue, int maxValue)
{
    return (minValue >= 1 && maxValue >= minValue);
}

// Метод нахождения суммы чисел.
int GetSumOfItems(int firstItem, int lastItem)
{
    if (firstItem == lastItem)
    {
        return lastItem;
    }
    else
    {
        return lastItem + GetSumOfItems(firstItem, lastItem - 1);
    }
}

Console.WriteLine("Поиск суммы натуральных элементов в промежутке от M до N");
int minNum = GetNumFromUser("Введите число M: ");
int maxNum = GetNumFromUser("Введите число N: ");
bool isValid = IsValidInput(minNum, maxNum);
if (isValid)
{
    Console.WriteLine($"Сумма: {GetSumOfItems(firstItem: minNum, lastItem: maxNum)}");
}
else
{
    Console.WriteLine("Ошибка. Введены некорректные значение чисел.");
}