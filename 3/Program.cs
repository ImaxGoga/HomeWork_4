// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void foo()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array1 = new int[8];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите число: "+ (i+1) + " ");
        array1[i] = int.Parse(Console.ReadLine());
    }
    Console.Write("Ваш массив: [");
    for(int i = 0; i<size; i++){
        if(i != size-1)
        {
            Console.Write(array1[i] + ", ");
        }
        else {
            Console.Write(array1[i] + "]");
        }
    }    
}

foo();