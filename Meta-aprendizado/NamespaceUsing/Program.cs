using ProdutoEletronico = NameespaceUsing.Eletronicos.Produto;
using ProdutoAlimento = NameespaceUsing.Alimenticios.Produto;
using NameespaceUsing.Models;
using ProdutoSoftware = NameespaceUsing.Models.Produto;
using NameespaceUsing.Services;
using RealConsole = global::System.Console;




Console.WriteLine("=== Teste SIMPLES de Namespaces ===\n");

// Método 1: Usando QUALIFICAÇÃO COMPLETA (nunca falha)
var eletronico = new NameespaceUsing.Eletronicos.Produto();
eletronico.Nome = "Smartphone";
eletronico.PrecoUSD = 1000;

var alimento = new NameespaceUsing.Alimenticios.Produto();
alimento.Nome = "Banana";
alimento.PrecoBRL = 5.0;

Console.WriteLine($"Método 1 - Qualificação completa:");
Console.WriteLine($"Eletrônico: {eletronico.Nome}");
Console.WriteLine($"Alimento: {alimento.Nome}");

// Vamos agora testar os diferentes usos de 'using'
TestarUsings();
TestesCalculadoras.TestarAbordagens();

static void TestarUsings()
{
  Console.WriteLine("\n=== Testando diferentes usos de 'using' ===\n");

  // Cenário A: Usando apenas UM namespace (sem conflito)
  // Descomente apenas UMA linha abaixo por vez:
  // using Alimenticios;

  // Se apenas um using estiver ativo, isso funciona:
  // var p = new Produto(); // É claro qual Produto usar

  // Cenário B: Usando DOIS namespaces (CONFLITO!)
  // using Eletronicos;
  // using Alimenticios;
  // var p = new Produto(); // ❌ ERRO: Qual Produto?

  // Cenário C: Usando alias para namespaces
  // using Eletron = Eletronicos;
  // using Aliment = Alimenticios;
  //  var e = new Eletron.Produto(); // ✅ Funciona com namespace alias
  // var a = new Aliment.Produto(); // ✅

  // Cenário D: Usando alias para TIPOS (forma mais comum)
  
  var e = new ProdutoEletronico(); // ✅
  var a = new ProdutoAlimento(); // ✅

  Console.WriteLine("(Teste os cenários um por um!)");

}

class Teste
{
    void Metodo()
    {
        // Estrutura A - mais conciso
        var p = new ProdutoSoftware();
        var u = new Usuario();
        var s = new EmailService();
        
        // Estrutura B - mais verboso
        // Precisa de qualificação completa ou muitos usings
    }
}

class TesteConflito
{
    void Testar()
    {
        // ❌ Ambiguidade - qual System.Console?
        // Console.WriteLine("Teste");
        
        // ✅ Solução 1: global:: qualifier
        global::System.Console.WriteLine("Acesso ao Console real");
        
        // ✅ Solução 2: extern alias (avançado)
        
        // ✅ Solução 3: using alias
        RealConsole.WriteLine("Via alias");
    }
}