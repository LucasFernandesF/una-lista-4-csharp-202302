
int par = 0, impar = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o {0} número: ", i + 1);
    double num = Convert.ToDouble(Console.ReadLine());

    if (num % 2 == 0)
        par++;
    else
        impar++;
}
Console.WriteLine("A quantidade de números pares é {0}\nA quantidade de números ímpares é {1}", par, impar);
Console.ReadLine();
