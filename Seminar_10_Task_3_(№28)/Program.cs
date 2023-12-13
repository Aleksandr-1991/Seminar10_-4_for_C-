// Зад 28:  Прога приним число N и выдаёт произведение чисел от 1 до N.
double GetNatureNumber (string text)
{//(начало блока:) 
/*
double n = 1;
while (true)
    {
    Console.Write(text);
    n = Convert.ToDouble(Console.ReadLine());
    if (n>0 && n%1 == 0)  break;
    else Console.WriteLine("Введённое число не натуральное.  Туебень, число необходимо ввести натуральное.");
    }                           //(конец блока)*/

/*  // bool one = n > 0;
    // bool two = n%1 == 0;
    // if(one && two) break;  - для примера записи*/
//(начало блока:) /*
inputNumber:  Console.Write(text);
double n = double.Parse (Console.ReadLine());
if (n<1 || n%1 != 0)
    {
        Console.WriteLine("Введённое число не натуральное. Повторите ввод.");
        goto inputNumber;
    }                           //(конец блока)*/
return n;
}
double Factorial (double number)
{
    double factorial = 1;
    for (int i = 2; i <= number; i++)  factorial *= i;
    return factorial;
}
double number2 = GetNatureNumber (" Введите натуральное число N: ");
Console.Write($"Произведение чисел от 1 до N: {Factorial (number2) }");