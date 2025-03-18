
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
Console.Write("Digite a nota: ");
nota = int.Parse(Console.ReadLine());

while (nota < 11)
{
    Console.Write("Digite a nota: ");
    nota = int.Parse(Console.ReadLine());
    nota += nota;
    cont++;
}
Console.WriteLine($"A media de {cont} notas e {nota}");
