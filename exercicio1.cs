
int num;
Console.WriteLine("Digite um nota de 0 a 10:");
num = Convert.ToInt32(Console.ReadLine());
while (num < 0 || num > 10)
{
  Console.WriteLine("Você digitou um número inválido, digite novamente um número válido!");
  Console.WriteLine("Digite um nota de 0 a 10:");
  num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("A sua nota é {0}", num);
Console.ReadLine();