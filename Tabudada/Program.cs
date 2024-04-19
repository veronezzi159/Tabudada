int number = 0, mult = 0;

Console.WriteLine("Digite um número");
number = int.Parse(Console.ReadLine());

for (int i = 0; i < 11 && number >0; i++)
{
    mult = number * i;
    Console.WriteLine($"{number}x{i} = {mult}");
}