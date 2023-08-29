

Console.WriteLine("Hello, World!");

Dice dice = new Dice();

Console.WriteLine("Number of slides :");
dice.Slides = int.Parse(Console.ReadLine());
int luckyNumber = dice.roll();
Console.WriteLine($"Lucky Number is : {luckyNumber}");
