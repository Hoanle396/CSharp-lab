// See https://aka.ms/new-console-template for more information
int a, b, c;

double d, x1, x2;

Console.Write("Input a : ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b : ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c : ");
c = Convert.ToInt32(Console.ReadLine());

d = b * b - 4 * a * c;
if (d == 0)
{
    Console.Write("Both roots are equal.\n");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.Write("x1 = {0}\n", x1);
    Console.Write("x2 = {0}\n", x2);
}
else if (d > 0)
{
    Console.Write("Both roots are real and diff-2\n");

    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);

    Console.Write("x1 = {0}\n", x1);
    Console.Write("x2 = {0}\n", x2);
}
else
    Console.Write("No Solution. \n\n");
