int number = 0, count = 0;

Console.Write("Diga um número inteiro para verificar se é primo: ");
number = int.Parse(Console.ReadLine());


for(int divider = number; divider > 0; divider--)
{
    if (number % divider == 0)
    {
        count++;
    }
    if (number < 1 || count > 2)
    {
        break;
    }  
}

if (count == 2)
{
    Console.WriteLine("\nO número é primo!");
}
else
{
    Console.WriteLine("\nO número não é primo.");
}

