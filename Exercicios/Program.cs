
//Crie um programa que exiba os números de 1 a 20 na tela.

using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;

for (int i = 0; i <= 20; i++)
{
    Console.WriteLine(i);
}

//Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

string senha;

do
{
    Console.Write("Informe a senha: ");
    senha = Console.ReadLine();
}
while (senha != "1234");

Console.WriteLine("Senha correta !");

//Peça ao usuário um número e exiba a tabuada dele de 1 a 10.

int numero = 0;

Console.Write("Digite o numero: ");
numero = int.Parse(Console.ReadLine());
Console.WriteLine($"#### TABUADA DO {numero} ####");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"[{numero}] X [{i}] = {numero*i} ");
}

//Peça um número ao usuário e faça uma contagem regressiva até 0.

int n1;
Console.Write("Digite o numero: ");
n1 = int.Parse(Console.ReadLine());

for (int i = n1; i > 0; i--)
{
    Console.WriteLine(i);
}

//Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.


int nota = 0;
int cont = 0;
int media = 0;
do
{
    Console.Write("Digite a nota: ");
    nota = int.Parse(Console.ReadLine());
    if (nota <= 10)
    {
        media += nota;
        cont++;
    }
   
}
while (nota >= 0 && nota <= 10);

if(media == 0 || cont == 0)
{
    Console.WriteLine("Nao foi possivel calcular divisao por zero");
}
else
Console.WriteLine($"A media de {cont} nota(s) e {media / cont}");


//Escreva um programa que peça números ao usuário e some-os, parando quando o usuário inserir um número negativo.

int n2 = 0;
int cont2 = 0;

do
{
    Console.Write("Digite o numero: ");
    n2 = int.Parse(Console.ReadLine());
    if (n2 > 0)
    {
        cont2 += n2;
    }

}
while (n2 > 0);
Console.WriteLine($"A soma e {cont2}");

//O programa escolhe um número aleatório entre 1 e 100. O usuário tenta adivinhar e o programa dá dicas.


//Random randNum = new Random();
//randNum.Next();
//Console.WriteLine(randNum.Next());

int n3 = 0;
int n4 = 0;
Random randNum = new Random();
for (int i = 0; i < 1; i++)

n3 = randNum.Next(0, 100);

while (n3 != n4)
{

    Console.Write("Digite o numero: ");
    n4 = int.Parse(Console.ReadLine());

    if (n4 == n3)
    {
        Console.WriteLine($"Acertou o numero e: {n4}");
    }
    else if (n4 > n3) 
    {
        Console.WriteLine("O numero aleatorio e menor");
    }
    else
        Console.WriteLine("O numero aleatorio e maior ");

}


//EXERCICIOS DE EXCECOES

//Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve usar `try/catch` para garantir que o usuário insira um número válido.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)


try
{
    Console.Write("Digite um número inteiro: ");
    int n5 = int.Parse(Console.ReadLine());

}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida, digite um número inteiro válido.");
}


//Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use `try/catch` para evitar divisão por zero e entrada inválida.

//**Erros a serem tratados:**

//-Usuário digitar um valor não numérico. (`FormatException`)
//- Tentativa de divisão por zero. (`DivideByZeroException`)

try
{
    Console.Write("Digite o primeiro número: ");
    int n6 = int.Parse(Console.ReadLine());
   
    Console.Write("Digite o segundo número: ");
    int n7 = int.Parse(Console.ReadLine());

    int calc = n6 / n7;

}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Dados invalidos, usar numeros.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: Não é possível dividir por zero.");
}

//Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)

int idade =0;

try
{
    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade >= 12 )
    {
        Console.WriteLine("Menor de idade");
    }
    else
    {
        Console.WriteLine("Maior de idade");
    }
}
catch (FormatException ex )
{
    Console.WriteLine("Erro: Dados invalidos, usar numeros.");
}
catch (OverflowException ex)
{
    Console.WriteLine("Erro: Dados muito grande.");
}
if (idade < 0)
{
    throw new ArgumentOutOfRangeException("A idade nao pode ser negativa");
}
else if (idade > 120)
{
    throw new ArgumentOutOfRangeException("A idade nao pode ser maior que 120 anos");
}



//Peça ao usuário para inserir um número inteiro positivo. O programa deve contar de 1 até esse número. Se a entrada for inválida ou negativa, exiba um erro.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)
//- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)

int n8 = 0; ;

try
{
    Console.Write("Inserir um numero positivo: ");
    n8 = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n8; i++)
    {
        Console.WriteLine($"Numero informado {i} de {n8} ");
    }
}
catch (FormatException ex)
{
    Console.Write("Erro: Dados invalidos, informar numero positivo.");
}
catch (OverflowException ex)
{
    Console.Write("Erro: valor informado muito grande.");
}

if (n8 < 0)
{
    throw new ArgumentOutOfRangeException("Erro: O número deve ser positivo.");
}

//Crie um programa que peça ao usuário para inserir 5 números e some-os. Use `try/catch` para lidar com entradas inválidas.

//**Erros a serem tratados:**

//-Usuário digitar um valor não numérico. (`FormatException`)
//- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)


//Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.

//**Erros a serem tratados:**

//-Usuário digitar um texto ao invés de um número. (`FormatException`)
//- Usuário inserir um número muito grande. (`OverflowException`)

