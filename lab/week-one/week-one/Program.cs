// See https://aka.ms/new-console-template for more information
double a, b, result =0;
string opera= "";
Console.WriteLine("Nhap a = ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Nhap b = ");
b = double.Parse(Console.ReadLine());

while (opera != "+" && opera != "-" && opera != "*" &&opera != "/")
{
    Console.WriteLine("Nhap operator (+,-,*,/) = ");
    opera = Console.ReadLine();
}
if (opera == "+") result = a + b;
if (opera == "-") result = a - b;
if (opera == "*") result = a * b;
if (opera == "/")
{
    if (b == 0) return;
    result = a / b;
}
Console.WriteLine($"Ket Qua {a} {opera} {b} = {result}");


