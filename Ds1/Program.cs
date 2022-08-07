Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (a < min ) min = a;
if (b < min ) min = b;

Console.WriteLine("Результат:");

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);