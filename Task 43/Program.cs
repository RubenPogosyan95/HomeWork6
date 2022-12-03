// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Please Write Values with space");
string[] Num = Console.ReadLine().Split(" ");
float b1 = Convert.ToInt64(Num[0]);
float k1 = Convert.ToInt64(Num[1]);
float b2 = Convert.ToInt64(Num[2]);
float k2 = Convert.ToInt64(Num[3]);


Console.WriteLine($"{(b2 - b1) / (k1 - k2)}, {k1 * ((b2 - b1) / (k1 - k2)) + b1}");
