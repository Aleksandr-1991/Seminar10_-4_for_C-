// Зад. 28:  Нап прогу, кот приним на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Parse (string text) {
    Console.Write(text);
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}
int Factorial (int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
int number2 = Parse ("Введите число N: ");
int result = Factorial (number2);
Console.Write($"Произведение всех чисел от 1 до N:  {result}");