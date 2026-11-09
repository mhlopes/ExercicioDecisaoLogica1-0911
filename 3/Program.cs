float n1;
float n2;
float n3;
float n4;

Console.WriteLine("digite a primeira nota");
n1 = float.Parse(Console.ReadLine());
    if(n1 < 0 || n1 > 10)
    {
        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 10.");
        return;
    }
Console.WriteLine("digite a segunda nota");
n2 = float.Parse(Console.ReadLine());
    if(n2 < 0 || n2 > 10)
    {
        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 10.");
        return;
    }
Console.WriteLine("digite a terceira nota");
n3 = float.Parse(Console.ReadLine());
    if(n3 < 0 || n3 > 10)
    {
        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 10.");
        return;
    }
Console.WriteLine("digite a quarta nota");
n4 = float.Parse(Console.ReadLine());
    if(n4 < 0 || n4 > 10)
    {
        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 10.");
        return;
    }

float media = (n1 + n2 + n3 + n4) / 4;

if (media >= 7)
{
    Console.WriteLine($"A media é {media:F2} e o aluno foi aprovado");
}
else if (media > 5 && media < 7)
{
    Console.WriteLine($"A media é {media:F2} e o aluno está de recuperação");
}
else
{
    Console.WriteLine($"A media é {media:F2} e o aluno foi reprovado");
}