float n1;
float n2;

Console.WriteLine("escreva um numero decimal");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("escreva outro numero decimal");
n2 = float.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"{n1} é maior que {n2}");
}
else if (n1 < n2)
{
    Console.WriteLine($"{n2} é maior que {n1}");
}
else
{
    Console.WriteLine("Os numeros são iguais");
}