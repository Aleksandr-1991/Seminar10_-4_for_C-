// Дом №27. Прога принимает число и выдаёт сумму цифр в числе. 

int Input (string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    result = result >0 ? result : -result;
    return result;
}
int SumDigits (int number)
{
    int result = 0;
    while (number !=0)
    {
        result = result + number%10;
        number = number /10;
    }
    return result;
}
int input = Input ("Введите натуральное число (введённое отрицательное число будет взято по модулю) или ноль: ");
Console.Write($"Сумма цифр в числе {input} равна: {SumDigits (input)}");