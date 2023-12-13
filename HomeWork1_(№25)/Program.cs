// Зад. 25: Нап цикл, кот приним на вход два числа (A и B) и возводит число A в натуральную степень B.
double GetNumberA (string text)
{
    Console.Write(text);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
double GetNumberB (string text) {
    inputNumberB:  
    Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    if (number %1 != 0 || number < 1)
    {
        Console.WriteLine("Введённое число не натуральное. Повторите ввод.");
        goto inputNumberB;
    }
    return number;
}
double Exponent (double A, double B)
{
    double result = A;
    for (int i=1; i<B; i++)  result *= A;
    return result;
}
double numberA = GetNumberA("Введите число A (которое будем возводить в степень): ");
double numberB = GetNumberB("Введите натуральное число B (та самая степень): ");
Console.WriteLine($"Результат возведения в степень равен: {Exponent(numberA, numberB)}");