// See https://aka.ms/new-console-template for more information
int lootbox = new Random().Next(0, 101);

int number;
for (int i = 1; i <= 7; i++)
{
    Console.WriteLine("Nhap vao so");
    number = int.Parse(Console.ReadLine());

    if(number == lootbox)
    {
        Console.WriteLine($"Congratulation! con so may man la {lootbox}");
        break;
    }
    else if (number < lootbox)
    {
        Console.WriteLine($"Lucky number greater than {number}");
    }
    else if (number > lootbox)
    {
        Console.WriteLine($"Lucky number less than {number}");
    }
}
