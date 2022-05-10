// Console.WriteLine("Digite o seu nome.");

// var nome = Console.ReadLine();

// Console.WriteLine($"Olá, {nome}");

var umaString = "Essa é uma String";
var numeroInt = 5;
var numeroFloar = 5.4f;
var numeroDouble = 5.4;
var numeroDecimal = 5.3m;
var array = new int[3] { 1, 2, 3 };
var caractere = 'a'; //caractere com as aspas simples
var date = new DateTime(1992, 12, 1);

// Console.WriteLine("Digite uma opção de 1 a 3.");
// var opcao = Console.ReadLine();

// if (opcao == "1")
// {
//     Console.WriteLine("Você entrou no menu de Cadastro.");
// }
// else if (opcao == "2")
// {
//     Console.WriteLine("Você entrou no menu de Reclamação.");
// }
// else if (opcao == "3")
// {
//     Console.WriteLine("Você entrou no menu de Atendimento de Suporte.");
// }
// else
// {
//     Console.WriteLine("Opção inválida.");
// }

// switch (opcao)
// {
//     case "1":
//         Console.WriteLine("Você entrou no menu de Cadastro.");
//         break;
//     case "2":
//         Console.WriteLine("Você entrou no menu de Reclamação.");
//         break;
//     case "3":
//         Console.WriteLine("Você entrou no menu de Atendimento de Suporte.");
//         break;
//     default:
//         Console.WriteLine("Opção inválida.");
//         break;
// }


var valores = Console.ReadLine(); // 1 2 3 4 5
var valoresArray = valores.Split(" "); // [ "1", "2", "3", "4", "5" ] matriz, matriz começa na posição 0

for (var i = 0; i < valoresArray.Length; i++)
{
    Console.Write(valoresArray[i] + " ");
}

Console.WriteLine();



