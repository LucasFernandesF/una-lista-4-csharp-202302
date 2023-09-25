string usuario = "", senha = "";
do
{
    Console.WriteLine("Digite seu usuario: ");
    usuario = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Digite sua senha: ");
    senha = Convert.ToString(Console.ReadLine());
    if (usuario == senha)
        Console.WriteLine("A sua senha não pode ser a mesma que o usuario");
} while (usuario == senha);
Console.WriteLine("Você foi cadastrado com sucesso!");
Console.ReadLine();