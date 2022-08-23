// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int foo(string a){
    int lng = a.Length;
    int result=0;
    for(int i = 0; i < lng ; i++ ){
        result = int.Parse(a[i].ToString()) + result; 
    }
    return result;
}

Console.Write("Введите число: ");
string a1 = Console.ReadLine();
Console.WriteLine("Сумма цифр Вашего числа: " + foo(a1));
Console.WriteLine("Проверочное число 452. Сумма цифр числа 452: " + foo("452"));
Console.WriteLine("Проверочное число 82. Сумма цифр числа 82: " + foo("82"));
Console.WriteLine("Проверочное число 9012. Сумма цифр числа 9012: " + foo("9012"));