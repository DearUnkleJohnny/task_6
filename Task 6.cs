// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
Console.WriteLine("Введите числа массива:");
for (int i = 0; i < count; i++)
{

    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
Console.WriteLine("Введённый массив:");
for (int i = 0; i < array.Length; i++)
{

    Console.Write(array[i] + " | ");
}
int PositiveNumbers = 0;
for (int i = 0; i < count; i++)
{
    int arrayNum = array[i];
    if (arrayNum > 0)
    {
        PositiveNumbers = PositiveNumbers + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"В массиве чисел больше нуля: -> {PositiveNumbers}");




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




Console.WriteLine("Вычесление точки пересечения 2-х прямых:");
Console.WriteLine("Введите координату b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({y1}; {y2})");