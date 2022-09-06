/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и п
роверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int Сomp(int n)
{
    int i = 10000;
    int j = 10;
    int f = n / i;
    int l = n % j;
    int res = 0;
    for (int r = 0; r < 2; r++)
    {
        if ((f) == (l))
        {
            i = i / 10;
            f = n / i; //f - i-тое число от начала
            f = f % 10;
            j = j * 10;
            l = n % j;//l - j-тое число от конца
            l = l / 10;
            res = 1;
        }
    }
return res;
}

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (Сomp(n) == 1)
    Console.WriteLine("Введеное число палиндром");
else
    Console.WriteLine("Введеное число не палиндром");

