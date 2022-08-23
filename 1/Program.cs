// Начиная с этого семинара обязательно используем функции в решении!
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int foo(int a, int b)
{
    int res=a;
    for(int i=0; i < b-1; i++){
        res=res*a;
    }
    return res;
}

Console.Write("Введите переменную А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите переменную В: ");
int b = Int32.Parse(Console.ReadLine());
int result = foo(a,b);
Console.WriteLine("Результат " + a + "^" + b + " = " + result);

Console.WriteLine("Проверочные значения(3^5): " + foo(3,5));
Console.WriteLine("Проверочные значения(2^4): " + foo(2,4));