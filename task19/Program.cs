﻿Console.Clear();
Console.WriteLine ("Введите 5-значное число"); 
int n = Convert.ToInt32(Console.ReadLine());
while (n<10000 || n>99999)
{
Console.WriteLine ("Вы ошиблись! Введите 5-значное число");
n = Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);
}

int n1=n/10000;
int n2=(n/1000)%10;
int n4=(n%100)/10;
int n5=(n%10);
if (n1==n5 && n2==n4)
Console.WriteLine("Да ");
else
Console.WriteLine("Нет");
