// Зад 24. Прога приним на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.WriteLine("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= A; i++) sum += i;
// Console.WriteLine(sum);

// Декомпозируем задачу на подзадачи.
// 1. Ввод числа.
// 2. Поиск суммы.

// Синтаксис f-ции:
int Parse (string text) {
    Console.Write(text);
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}
// int - тип возвращаемого значения;
// Parse - Произвольное название ф-ции;
// () - Аргументы, без кот f-ция не б-работать;
// {} - Тело f-ции;
// return - Возвращаемое значение;
// Аргументы д-совпадать с типом вводимых данных 
// "Введите qwerty" это тип string;  false это тип bool isTrue, 12345 это тип int.

int Sum (int number2)
{
    int sum = 0;
    for (int i = 0; i <= number2; i++)  sum += i;
    return sum;
}
// int a = Sum(4); //10
// int b = Sum(5); //15
// int c = Sum(6); //21
// Console.WriteLine("{0}, {1}, {2}", a, b, c);

int number1 = Parse ("Введите число: ");
int result = Sum (number1);
Console.Write($"Сумма чисел от 1 до {number1} равна: {result}");