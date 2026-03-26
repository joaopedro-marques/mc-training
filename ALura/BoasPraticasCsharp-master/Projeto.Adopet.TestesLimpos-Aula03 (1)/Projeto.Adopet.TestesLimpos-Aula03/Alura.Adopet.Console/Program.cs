using Alura.Adopet.Console;
using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;

var consoleUI = new ConsoleUI();
var httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().CreateClient("adopet"));
var leitorDeArquivos = new LeitorDeArquivo(caminhoDoArquivoASerLido: args[1]);
Dictionary<string, IComando> comandosDoSistema = new()
{
    {"help",new Help(consoleUI) },
    {"import",new Import(httpClientPet,leitorDeArquivos, consoleUI)},
    {"list",new List(httpClientPet, consoleUI) },
    {"show",new Show(leitorDeArquivos, consoleUI) },
};

consoleUI.WriteSuccess("Adopet CLI iniciado...");
try
{
    string comando = args[0].Trim();
    if (comandosDoSistema.ContainsKey(comando))
    {
        IComando? cmd = comandosDoSistema[comando];
        await cmd.ExecutarAsync(args);
    }
    else
    {
        consoleUI.WriteLine("Comando inválido!");
    }
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    consoleUI.WriteError($"Aconteceu uma exceção: {ex.Message}");
}
finally
{
    consoleUI.ResetColor();
    consoleUI.Dispose();
}
