// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.WriteLine("Please Write Numbers with space");
string[] M = Console.ReadLine().Split(" ");
int[] Numbers = new int[M.Length];

for (int i = 0; i < M.Length; i++)
{
    Numbers[i] = int.Parse(M[i]);
}
int ShowPositiveNumbers(int[] arr)
{
    int sum = 0;
    foreach (var item in arr)
    {
        if (item > 0)
        {
            sum++;
        }
    }
    return sum;
}
Console.WriteLine($"PositiveNumbers = {ShowPositiveNumbers(Numbers)}");


