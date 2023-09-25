int num1, num2;
Console.WriteLine("Digite um número inteiro para ser o número inicial: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite um número inteiro para ser o número final: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------");
for (int i = num1; i <= num2; i++)
    Console.WriteLine(i);
Console.WriteLine("FIM!");
Console.ReadLine();