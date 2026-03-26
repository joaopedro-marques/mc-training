using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.UI;
using Alura.Adopet.Console.Util;
using FluentResults;


// var httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().CreateClient("adopet"));
// LeitorDeArquivo leitorDeArquivos = args.Length == 2 ? new(args[1]) : null;

IComando? comando = FabricaDeComandos.CriarComando(args);
if (comando is not null)
{
    var resultado = await comando.ExecutarAsync();
    ConsoleUI.ExibeResultado(resultado);
}
else
{
    ConsoleUI.ExibeResultado(Result.Fail("Comando inválido!"));
}
      

