Console.WriteLine("Введите значение a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение c");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b == 0 || b + c == 0 || a + c == 0)
{
    Console.WriteLine("Одна из пар взаимно противоположна ");
}
else
{
    Console.WriteLine("Они взаимно не противоположны");
}
