﻿   //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
   
    using System;
Console.WriteLine("Введите положительное число");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    Console.Write($" {(long)Math.Pow(i, 3)}");

//double i=1;
//while (i<=N)
//{
  //  Console.Write($"{Math.Pow(i,3)} ");