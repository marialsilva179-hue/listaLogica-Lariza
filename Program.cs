// See https://aka.ms/new-console-template for more information

//Nível 1: Variáveis e Operações Básicas
#region 1. Calculadora de média Simples
//Console.Write("Digite a primeira nota: ");
//double notal1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digite a segunda nota: ");
//double notal2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Digita a terceira nota: ");
//double notal3 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("\nDigite a primeira nota: " + notal1 + "\nDigite a segunda nota: " + notal2 + "\nDigite a terceira nota: " + notal3);

//double soma = notal1 + notal2 + notal3;
//double media = soma / 3;

//Console.WriteLine("A sua média é: " + media);
#endregion

#region 2. Conversor de Idade
//Console.Write("Digite a sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//int dias = idade * 365;

//Console.WriteLine("Digite a sua idade: " + dias);
#endregion

#region 3. Troca de Valores
//int A = 10;
//int B = 20;

//Console.WriteLine("Valores originais: ");
//Console.WriteLine("A = " + A);
//Console.WriteLine("B = " + B);

//int temp = A;
//A = B;
//B = temp;

//Console.WriteLine("Valores após a troca: ");
//Console.WriteLine("A = " + A);
//Console.WriteLine("B = " + B);
#endregion

//Nível 2: Estruturas Condicionais (if, else if, else)
#region 1. Verificador de Maioridade
//Console.Write("Digite sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Entrada autorizada: ");
//}
//else
//{
//    Console.WriteLine("Entrada não autorizada: ");
//}
#endregion

#region 2. Classificador de Número
//Console.Write("Digite um número inteiro: ");
//int numero = int.Parse(Console.ReadLine());

//if (numero == 0)
//{
//    Console.WriteLine("Zero. ");
//}
//else if (numero > 0 && numero % 2 == 0)
//{
//    Console.WriteLine("Par e positivo. ");
//}
//else if (numero > 0 && numero % 2 != 0)
//{
//    Console.WriteLine("Ímpar e positivo. ");
//}
//else
//{
//    Console.WriteLine("Negativo. ");
//}
#endregion

#region 3. Validação de Login Simples
//string usuarioCorreto = "admin";
//string senhaCorreta = "12345";

//Console.Write("Digite o seu usuário: ");
//string usuario = Console.ReadLine();

//Console.Write("Digite a sua senha: ");
//string senha = Console.ReadLine();

//if (usuario == usuarioCorreto && senha == senhaCorreta)
//{
//    Console.WriteLine("Login efetuado com sucesso! ");
//}
//else
//{
//    Console.WriteLine("Usuário ou senha inválidos. ");
//}
#endregion

//Nível 3: Estruturas de Repetição (Loops)
#region 1.Contagem Regressiva
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Lançar! ");
#endregion

#region 2. Soma de Ímpares (Loop While)
//int soma = 0;
//int numero;

//Console.Write("Dígite um número (0 para parar): ");
//numero = int.Parse(Console.ReadLine());

//while (numero !=0)
//{
//    if (numero % 2 != 0)
//    {
//        soma += numero;
//    }

//    Console.Write("Digite um número (0 para parar): ");
//    numero = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("A soma dos números Ímpares é: " + soma);
#endregion

#region 3. Tabuada Personalizada
//Console.Write("Digite um número inteiro: ");
//int numero = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(numero + "x" + i + "=" + (numero * i));
//}
#endregion

//Nível 4: Coleções (Arrays e Listas)
#region 1. Inversão de Array
//string[] nomes = new string[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Digite o " + (i + 1) + "° nome: ");
//    nomes[i] = Console.ReadLine();
//}

//Console.WriteLine("\nLista original: ");
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(nomes[i]);
//}

//Console.WriteLine("\nlista invertida: ");
//for (int i = 4; i >= 0; i--)
//{
//    Console.WriteLine(nomes[i]);
//}
#endregion

#region 2. Busca e Contagem em Lista (foreach)
//List<string> cores = new List<string>()
//{
//    "azul", "vermelho", "verde", "azul", "preto", "verde", "azul"
//};

//Console.Write("Digite uma cor para buscar: ");
//string corBusca = Console.ReadLine();

//int contador = 0;

//foreach (string cor in cores)
//{
//    if (cor == corBusca)
//    {
//        contador++;
//    }
//}

//Console.WriteLine("A cor aparece " + contador + "vez(es) na lista. ");
#endregion

#region 3. Gerenciador de Tarefas Simples (CRUD Básico em Memória)
List<string> tarefas = new List<string>();
int opcao = 0;

while (opcao != 3)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Digite a tarefa: ");
        string tareafa = Console.ReadLine();
        tarefas.Add("tarefa");

        Console.WriteLine("Tarefa adicionada com sucesso! ");
    }
    else if (opcao == 2)
    {
        Console.WriteLine("\n===== LISTA DE TAREFAS =====");

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada. ");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine((i + 1) + "-" + tarefas[i]);
            }
        }
    }
    else if (opcao == 3)
    {
        Console.WriteLine("saindo... ");
    }
    else
    {
        Console.WriteLine("Opção inválida! ");
    }
}
#endregion