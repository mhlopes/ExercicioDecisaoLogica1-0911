int n1;
Console.WriteLine("escreva um numero inteiro");
n1 = int.Parse(Console.ReadLine());

bool isInteiro = n1 % 2 == 0;
if(isInteiro)
{
    Console.WriteLine("O numero é par");
}
else
{
    Console.WriteLine("O numero é impar");
}