string nome,estadoCivil, sexo;
int idade;
double salario;

do
{
    Console.WriteLine("Digite o seu nome (maior que 3 caracteres): ");
    nome = Console.ReadLine(); // Não é necessário converter para int
    Console.WriteLine("Digite sua idade (entre 0 e 150): ");
    idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite seu salário (maior que 0):");
    salario = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sexo (f para feminino e m para masculino)");
    sexo = Console.ReadLine(); // Não é necessário converter para string
    Console.WriteLine("Digite seu estado civil: \ns = solteiro\nc = casado\nv = viúvo\nd = divorciado");
    estadoCivil = Console.ReadLine(); // Não é necessário converter para string
    if (nome.Length <= 3 || idade <= 0 || idade >= 150 || salario <= 0 || (sexo.ToLower() != "f" && sexo.ToLower() != "m") || (estadoCivil.ToLower() != "s" && estadoCivil.ToLower() != "c" && estadoCivil.ToLower() != "v" && estadoCivil.ToLower() != "d"))
        Console.WriteLine("Algumas das respostas anterioes está inválida. Insira os dados corretos para cadastrar.");
} while (nome.Length <= 3 || idade <= 0 || idade >= 150 || salario <= 0 || (sexo.ToLower() != "f" && sexo.ToLower() != "m") || (estadoCivil.ToLower() != "s" && estadoCivil.ToLower() != "c" && estadoCivil.ToLower() != "v" && estadoCivil.ToLower() != "d"));

Console.WriteLine("Cadastro Completo!");
Console.ReadLine();
