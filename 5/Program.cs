int ano;

Console.WriteLine("Digite o ano:");
ano = int.Parse(Console.ReadLine());

if (ano < 0)
{
    Console.WriteLine("Ano inválido. Por favor, insira um ano positivo.");
}
else
{
    if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
    {
        Console.WriteLine("O ano é bissexto");
    }
    else
    {
        Console.WriteLine("O ano não é bissexto");
    }
}