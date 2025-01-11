using System;

//  Declarando Variaveis
int a, b;

//  Inputs iniciais
Console.WriteLine("Digite seu numero 1: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite seu numero 2: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Soma(a, b));


//  Decisório
if (a == b)
{
    Console.WriteLine("os dois são inguaul");
}
else
{
    Console.WriteLine("naum é inguaul");
}


//      Condição em uma linha:
//Console.WriteLine(a == b ? "os dois são iguais" : "naum é igual");


//      Laço de repetição
//while (a < 5)
//{
//    a++;
//    Console.WriteLine("Seu numero: " + a);
//}

//for (int i = 0; i < 2; i++)
//{
//    Console.WriteLine(a + i);
//}


//  Função
static string Soma(int num1, int num2)
{
    int r = num1 + num2;
    return "Seu numero é: "+ r;
}
