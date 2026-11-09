float kg;
float altura;

Console.WriteLine("Digite seu peso em kg:");
kg = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura em centímetros:");
altura = float.Parse(Console.ReadLine());

float imc = (kg / ((altura / 100) * (altura / 100)));

if(imc <= 18.5)
{
    Console.WriteLine($"Seu IMC é {imc:F2} e você está abaixo do peso");
}
else if (imc > 18.5 && imc < 25)
{
    Console.WriteLine($"Seu IMC é {imc:F2} e você está com peso normal");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine($"Seu IMC é {imc:F2} e você está com sobrepeso");
}
else if (imc >= 30 && imc < 40)
{
    Console.WriteLine($"Seu IMC é {imc:F2} e você está com obesidade");
}
else
{
    Console.WriteLine($"Seu IMC é {imc:F2} e você está com obesidade severa" +
        $"");
}