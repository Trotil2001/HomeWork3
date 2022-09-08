/*
Задача 23
Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void cube(int n1)
{
    for (int i = 1; i <= n1; i++)
    {
        double cub = Math.Pow(i, 3);
        if (i == 1)
            Console.Write(cub);
        else
        {
            Console.Write(", ");
            Console.Write(cub);
        }
    }
}
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
cube(n);