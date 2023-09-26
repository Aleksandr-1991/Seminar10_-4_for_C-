// Зад. 24. Напишите прогу, кот приним на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7->28,  4->10,  8->36.
// Ранее писали код так:

// Console.WriteLine("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= A; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// Декомпозируем задачу на подзадачи.
// 1. Ввод числа.
// 2. Поиск суммы.


// Синтаксис f-ции:
int Parse (string text, bool isTrue, int qwe) {
    Console.WriteLine(text);
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}
string abc = "Введите qwerty";
int number = Parse (abc, false, 12345);

int - тип возвращаемого значения;
Parse - Произвольное название ф-ции;
() - Аргументы, без кот f-ция не б-работать;
{} - Тело f-ции;
return - Возвращаемое значение;
Аргументы д-совпадать с типом вводимых данных ("Введите qwerty" это тип string;  false это тип bool isTrue, 12345 это тип int)