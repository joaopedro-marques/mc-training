// using System;

// Console.WriteLine("Qual o seu nome?");
// string? nomeUsuario = Console.ReadLine();
// Console.WriteLine("Qual a sua idade?");
// int? idade = Int32.Parse(Console.ReadLine());
// string entradaPreco = "250"; // O preço veio como TEXTO do sistema
// Console.WriteLine("Você é premium? S ou N");
// bool premium = Console.ReadLine() == "S" ? true : false;

// Console.WriteLine($"Olá, {nomeUsuario}. Bem-vindo ao sistema!");

// // --- O PROBLEMA ---
// // Tente rodar o código. Ele apresentará um erro de compilação na linha abaixo.
// // O C# é uma linguagem FORTEMENTE TIPADA. 
// // O que acontece quando tentamos multiplicar um NÚMERO por um TEXTO?

// var totalComDesconto = Double.Parse(entradaPreco) * 0.90; 

// // --- ESTRUTURA DE CONTROLE ---
// if (premium)
// {
//     Console.WriteLine("Aplicando desconto de 10%...");
//     Console.WriteLine("O valor final é: " + totalComDesconto);
// }
// else
// {
//     Console.WriteLine("O valor final é: " + entradaPreco);
// }

// /* DICA PARA A FASE 2 (Observação Reflexiva):
//    Olhe para a mensagem de erro no console. 
//    Ela mencionará algo sobre "Operator '*' cannot be applied to operands of type 'string' and 'double'".
// */

// //tive dificuldades de entender a conversão e executá-la, soube muito bem que o erro era esse.
// // O texto inclusive estava explicativo demais.
// // Percebi que tenho que revisar type casting que é muito importante nessa área. Acho que foi meu principal erro.
// // Em relação a estrutura if, é uma estrutura condicional que valida se a pessoa possui premium ou não.
// // Posso melhorar o código colocando input do usuário agora, na fase de observação, já que terminei minha reflexão. 

// //DOIS
// // --- CONFIGURAÇÃO INICIAL ---
// int nivelDificuldade = 5;
// bool possuiItemEspecial = true;
// int calculoFinal;

// Console.WriteLine("Iniciando processamento de recompensa...");

// // --- LÓGICA DE CÁLCULO ---
// if (possuiItemEspecial)
// {
//     int multiplicador = 10;
//     calculoFinal = nivelDificuldade * multiplicador;
//     Console.WriteLine("Item detectado! Multiplicador ativo.");
// }
// else
// {
//     calculoFinal = nivelDificuldade * 2;
//     Console.WriteLine("Sem itens extras.");
// }

// // --- O ERRO ---
// // O compilador vai reclamar desta linha abaixo:
// Console.WriteLine($"O resultado do processamento é: {calculoFinal}");

// /* DICA PARA FASE 2: 
//    O erro será: "The name 'calculoFinal' does not exist in the current context".
//    Aqui o erro tem a ver com escopo. Toda vez que a variável está em escopo de if ou método ou func
//    aquela variável é inacessível. Se ela é declarada dentro do bloco, não tem como utiza-la fora pois o ciclo de vida
//    Está fora.
// */



// // --- DADOS INICIAIS ---
// string[] tecnologias = { "C#", ".NET", "Web API" };
// int versaoDotNet = 8;

// Console.WriteLine("Iniciando Verificação...");

// // --- DESAFIO 1: COLEÇÕES ---
// foreach (string item in tecnologias)
// {
//     Console.WriteLine("Tecnologia: " + item);
// }

// // --- DESAFIO 2: LÓGICA ---
// if (versaoDotNet == 9)
// {
//     Console.WriteLine("Você está usando a versão mais recente.");
// }
// else
// {
//     Console.WriteLine("Versão estável detectada.");
// }


// //O C# é fortemente tipado, por isso, não se deve tratar string como int nunca. Para isso
// // É necessário sempre fazer a conversão de tipo. Nesse caso, bastava ttratar como string
// // Assim o foreach iria funcionar normalmente.

//Desafio final
Console.WriteLine("Escreva seu nome:");
string nomeCliente = Console.ReadLine();
decimal saldo = 1700;
decimal[] transacoes = new decimal[5];
decimal somaTransacoes = 0m;
decimal taxaCustodia = 0.95m;

for (int i =0 ; i <2 ; i++)
{
  Console.WriteLine($"Bem vindo, {nomeCliente}! Seuu saldo é de: {saldo} Escreve um pix recebido: ");
  transacoes[i] = Decimal.Parse(Console.ReadLine());
}

for (int i =0 ; i <3 ; i++)
{
  Console.WriteLine("Agora escreva um gasto:");
  transacoes[i+2] = Decimal.Parse(Console.ReadLine());
}

foreach(var transacao in transacoes)
{
  somaTransacoes += transacao;
}

saldo += somaTransacoes - (somaTransacoes *taxaCustodia);

if (saldo > 1000)
{
  Console.WriteLine("Parabéns você é um cliente Prime! Ganhou 5% de cashback");
  saldo *= 1.05m;
  Console.WriteLine($"Seu saldo é de: {saldo}");
} else
{
  Console.WriteLine($"Seu saldo é de: {saldo}");
}