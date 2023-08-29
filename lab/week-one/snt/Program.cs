// See https://aka.ms/new-console-template for more information
int number = 0;
while (number <2)
{
    Console.WriteLine("Nhap 1 so  = ");
    number = int.Parse(Console.ReadLine());
}

for (int i = 2; i < number / 2; i++)
{
    if (number % i == 0)
    {
        Console.Write($"{number} khong phai so nguyen to.");
        return;
    }
}

Console.Write($"{number} la so nguyen to.");
