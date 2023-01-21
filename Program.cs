// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(n));
string PrintNumber(int n)
{

    if (n <= 1) return "1";

    return PrintNumber (n - 1)  + n;

}

// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int summ(int m, int n)
{
return (m==n)?n:m + summ(m+1,n);
}
Console.WriteLine("Сумма чисел от " + m + " до " + n + " равна " + summ(m, n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkermanFunc(m - 1, 1);
    else
      return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
Console.WriteLine(AkkermanFunc(3, 2));
