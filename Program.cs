// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Enter the value of the first point on the X coordinate axis: ");
float X1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the value of the first point on the Y coordinate axis: ");
float Y1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the value of the first point on the Z coordinate axis: ");
float Z1 = Convert.ToSingle(Console.ReadLine());

Console.Write("Enter the value of the second point along the X coordinate axis: ");
float X2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the value of the second point on the Y coordinate axis: ");
float Y2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the value of the second point on the Z coordinate axi: s");
float Z2 = Convert.ToSingle(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine($"Estimated distance: {distance}");