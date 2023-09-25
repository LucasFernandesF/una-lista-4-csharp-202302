double num, soma = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o {0} número", i + 1);
    num = Convert.ToDouble(Console.ReadLine());
    soma = num + soma;
}
double media = soma / 5;

Console.WriteLine("A soma é {0}\nA media é {1}", soma, media);
Console.ReadLine();