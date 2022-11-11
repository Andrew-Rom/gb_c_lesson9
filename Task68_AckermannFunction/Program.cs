/* Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */

// Метод считывания.
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки введенного значения.
bool IsValidInput(int mValue, int nValue)
{
    return (mValue >= 0 && nValue >= 0);
}

// Метод вычисления функции Аккермана.
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}


Console.WriteLine("Вычисление функции Аккермана");
int mNum = GetNumFromUser("Введите число m: ");
int nNum = GetNumFromUser("Введите число n: ");
bool isValid = IsValidInput(mNum, nNum);
if (isValid)
{
    Console.WriteLine($"Результат: {Ackermann(mNum, nNum)}");
}
else
{
    Console.WriteLine("Ошибка. Введены некорректные значение чисел.");
}