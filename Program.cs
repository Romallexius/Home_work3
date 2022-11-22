/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом*/

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int num = InputNum ($"Введите пятизначное число: ");

bool check = false;
while (check == false)
{
    if (num < 10000 || num >= 100000) // проверяем на пятизначность
    {
    int num2 = InputNum ($"Введите пятизначное число: ");
    num = num2;
    }
    else if (num / 10000 % 10 == num % 10 && num / 1000 % 10 == num / 10 % 10) // проверяем на палиндром
    {
    Console.WriteLine ($"Это палиндром");
    check = true;
    }
    else
    {
    Console.WriteLine ($"Это не палиндром");
    check = true; 
    }
}


/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве*/

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}
Console.WriteLine ("Введите координаты точки А");
double x1 = InputNum ($"X1 = ");
double y1 = InputNum ($"Y1 = ");
double z1 = InputNum ($"Z1 = ");

Console.WriteLine ("Введите координаты точки В");

double x2 = InputNum ($"X2 = ");
double y2 = InputNum ($"Y2 = ");
double z2 = InputNum ($"Z2 = ");

Console.WriteLine ($"Расстояние между точками A и В = {Math.Sqrt (Math.Pow (x1-x2, 2) +  Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2))}");


/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N*/

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}
int num = InputNum ($"Введите число: ");
Console.Write ($"Кубы чисел от 1 до {num}: ");
double count = 1;
while (count < num)
{
    Console.Write ($"{Math.Pow (count, 3)}, ");
    count++;
}
Console.WriteLine ($"{Math.Pow (count, 3)}");
