Console.Clear();
Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine()!);
if (a < b)
    Console.WriteLine("max = " + b);
else if (a > b)
    Console.WriteLine("max = " + a);    