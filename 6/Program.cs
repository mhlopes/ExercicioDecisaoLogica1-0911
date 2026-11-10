uint ano;

Console.WriteLine("Digite o ano de nascimento:");
ano = uint.Parse(Console.ReadLine());
    if(ano > 2026 || ano < 0)
    {
        Console.WriteLine("Ano de nascimento inválido.");
        return;
    }

uint idade = 2026 - ano;

if (idade < 13)
{
    Console.WriteLine($"sua idade é {idade} e você é uma criança");
}
else if (idade >= 13 && idade < 18)
{
    Console.WriteLine($"sua idade é {idade} e você é um adolescente");
}
else if (idade >= 18 && idade < 60)
{
    Console.WriteLine($"sua idade é {idade} e você é um adulto");
}
else
{
    Console.WriteLine($"sua idade é {idade} e você é um idoso");
}