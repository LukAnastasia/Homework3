// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int length = number.Length;

// if (length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - не является пятизначным");
// }

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату x1 первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1 первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z1 первой точки");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2 второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2 второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2 второй точки");
// int z2 = Convert.ToInt32(Console.ReadLine());

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");

// int ReadInt(string message)
// {
// 	Console.Write(message);
// 	return Convert.ToInt32(Console.ReadLine());
// }

// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
return;