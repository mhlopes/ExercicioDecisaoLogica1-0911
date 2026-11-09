float lado1;
float lado2;
float lado3;

Console.WriteLine("Digite o comprimento do primeiro lado:");
lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o comprimento do segundo lado:");
lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terceiro lado:");
lado3 = float.Parse(Console.ReadLine());

if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
{
    Console.WriteLine("Os lados do triângulo devem ser maiores que zero.");
}
else if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
{
    Console.WriteLine("Os lados fornecidos não formam um triângulo.");
}
else if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é equilátero.");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é isósceles.");
}
else
{
    Console.WriteLine("O triângulo é escaleno.");
}