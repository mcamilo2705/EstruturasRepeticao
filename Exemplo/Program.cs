//Estruturas de repeticao

//imprimir todos os numeros de 1 a 5 

//int numero = 1;

////repete uma acao, ENQUANTO algo for verdadeiro

//while (numero <= 5)
//{
//    Console.WriteLine($"Numero: {numero}");
//    //operacao de incremento
//    //numero = numero + 1;
//    numero++;
//}

//Enquanto

//Console.Write("Informe a idade: ");
//int idade = int.Parse(Console.ReadLine());

//while (idade != 22)
//{
//    Console.Write("Informe a idade: ");
//    idade = int.Parse(Console.ReadLine());
//}

//Faca - Enquanto (DO/WHILE)


//int idade;
//do
//{
//    Console.Write("Informe a idade: ");
//    idade = int.Parse(Console.ReadLine());
//}
//while (idade != 22);

//Para - FOR
//Quero imprimir os numeros do 1 ao 5

//1- cria uma variavel chamada "i"(indice)
//2- faz a comparacao de i com 5
//3- incremento
//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine(i);
//}


//Tratamento de excecoes

//Todo erro no C# vem do Exception

//Exception
//IOException --> Erro de um tipo especifico, neste caso, erro de entrada e saida
//Dentro do IOException, contem o FormatException, neste caso, erros no formato (tipo de dados)

//Para cuidar de erro, usar o try/catch --> Tentar/Pegar

//Exemplo de tratativa

Console.Write("Informe um numero: ");
StreamReader reader = null;
try //tentar, ou seja, vai tentar fazer a linha de codigo
{
    reader = new StreamReader("/meuarquivo.txt");
    int num = int.Parse(Console.ReadLine());
    int resultado = num / 0;
}
catch (FormatException ex) //dentro do catch, precisa informar que tipo de erro que quer pegar, neste caso, erro de formatacao
{
    Console.WriteLine("Erro: informe apenas numeros!");
}
catch (OverflowException ex) //tipo de erro especifico para numero muito grande, pois a variavel int nao consegue armazenar
{
    Console.WriteLine("Erro: numero muito grande");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: tentativa de dividir por 0");
}
finally //se deu erro, vai encerrar o processo, neste caso a leitura do meuarquivo.txt
{
    reader.Close();
}


//Lancar erros manualmente com o throw
Console.Write("Informe uma idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade > 120)
{
    throw new ArgumentOutOfRangeException("Idade invalida");
}
