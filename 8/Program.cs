float salario;

Console.WriteLine("Digite seu salário:");
salario = float.Parse(Console.ReadLine());

float aumento = 0;

if (salario <= 2000)
{
    aumento = 0.15f;
    salario *= (1 + aumento);
    Console.WriteLine($"Seu novo salário é {salario:F2}");
}
else if (salario > 2000 && salario <= 4000)
{
    aumento = 0.10f;
    salario *= (1 + aumento);
    Console.WriteLine($"Seu novo salário é {salario:F2}");
}
else
{
    aumento = 0.05f;
    salario *= (1 + aumento);
    Console.WriteLine($"Seu novo salário é {salario:F2}");
}