// Зад. 25: Нап цикл, кот приним на вход два числа (A и B) и возводит число A в натуральную степень B.
int NumberA (string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int NumberB (string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number %1 != 0 || number < 1)
    {
    Console.WriteLine("Нужно было ввести натуральное число. Введённая Cтепень будет условно приравнена к 1!");
    } 
    return number;
}

int Exponent (int A, int B)
{
    int result = A;
    for (int i=1; i<B; i++)
    {
        result *= A;
    }
    return result;
}
int numberA = NumberA("Введите число A (которое будем возводить в степень): ");
int numberB = NumberB("Введите натуральное число B (та самая степень): ");
Console.WriteLine($"Результат возведения в степень равен: {Exponent(numberA, numberB)}");