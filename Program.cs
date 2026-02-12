// See https://aka.ms/new-console-template for more information

//Nível 1: Variáveis e Operações Básicas
#region 1. Calculadora de média Simples
Console.Write("Digite a primeira nota: ");
double notal1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
double notal2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digita a terceira nota: ");
double notal3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a primeira nota " + notal1 + "Digite a segunda nota " + notal2 + "Digite a terceira nota " + notal3);

double soma = notal1 + notal2 + notal3;
double media = soma /3;

Console.WriteLine("A sua média é: " + media);
#endregion

