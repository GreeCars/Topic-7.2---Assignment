// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Counting Down");
for (int i = 10; i >= 0; i = i - 1)
{
    Console.WriteLine(i);
}
Console.WriteLine("Blast Off");
Console.WriteLine();

Console.WriteLine("2. X and Y");
Console.WriteLine(" X\tY");
Console.WriteLine("-----------");
for (int i = -10; i <= 10; i = i + 2)
{
    Console.WriteLine(i + "\t" +  (i * i));
}
Console.WriteLine();

Console.WriteLine("3. For Loop Fun");