float n1;
float n2;

Console.WriteLine("--Calculadora--/n");

Console.WriteLine("digite o primeiro número");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo número");
n2 = float.Parse(Console.ReadLine());

float soma = n1 + n2;
float subtracao = n1 - n2;
float multiplicacao = n1 * n2;
float divisao = 0;

if (n2 == 0)
{
    Console.WriteLine("Erro: Divisão por zero não é permitida.");
}
else
{
    divisao = n1 / n2;
}

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");