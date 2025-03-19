
//Crie um programa que exiba os números de 1 a 20 na tela.

using System.Net.Mail;

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

