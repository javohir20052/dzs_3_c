// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// Console.WriteLine(" Ввведите число");


// int N = Convert.ToInt32(Console.ReadLine());

// if (N % 10 == N / 10000)
// {
//     if (((N % 100) - (N / 10000)) / 10 == (N / 1000) - ((N % 10) * 10))
//     {
//         Console.WriteLine(" да ^_^");
//     }
// }
// else
// {
//      Console.WriteLine(" нет ...");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine( "X1");

// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine( "Y1");

// int Y1 = Convert.ToInt32(Console.ReadLine());
 
// Console.WriteLine( "Z1");

// int Z1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine( "X2");

// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine( "Y2");

// int Y2 = Convert.ToInt32(Console.ReadLine());
 
// Console.WriteLine( "Z2");

// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + (Math.Pow(Y1 - Y2, 2)) + (Math.Pow(Z1 - Z2, 2))), 2);

// Console.WriteLine( d);


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write(" Введите число ");

// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N ; i++)
// {
//     Console.WriteLine(Math.Pow(i , 3));
// }
