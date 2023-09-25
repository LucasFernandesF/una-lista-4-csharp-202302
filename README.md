# una-lista-4-csharp-202302

## Lucas Fernandes Firmino 622122322  

### 1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
```
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
```
### 2 - Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
```
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
```
### 2 - Faça um programa que leia e valide as seguintes informações:
 ### -Nome: maior que 3 caracteres;
 ### Idade: entre 0 e 150;
 ### Salário: maior que zero;
 ### Sexo: 'f' ou 'm';
 ### Estado Civil: 's', 'c', 'v', 'd';
```
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

```
### 4. Faça um programa que leia 5 números e informe a soma e a média dos números.
```  
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
```
### 5 - Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.
```
for (int i = 1; i < 50; i++)
{
    Console.WriteLine(i);
    i++;
}
Console.ReadLine();
```
### 6 - Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles. 
```
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
```
### 7 - Faça um programa que peça 10 números inteiros, calcule e mostre a quantidade de números pares e a quantidade de números impares.
```
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
```
