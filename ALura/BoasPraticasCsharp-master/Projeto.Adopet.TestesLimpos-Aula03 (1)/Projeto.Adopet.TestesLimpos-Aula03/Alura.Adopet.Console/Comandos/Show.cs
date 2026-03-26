using Alura.Adopet.Console;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComandoAttribute(instrucao: "show",
       documentacao: "adopet show <ARQUIVO> comando que exibe no terminal o conteúdo do arquivo importado.")]
    internal class Show:IComando
    {
        private readonly LeitorDeArquivo leitor;
        private readonly IConsoleUI consoleUI;

        public Show(LeitorDeArquivo leitor, IConsoleUI consoleUI)
        {
            this.leitor = leitor;
            this.consoleUI = consoleUI;
        }

        public Task<Result> ExecutarAsync(string[] args)
        {
            try
            {
                this.ExibeConteudoArquivo(caminhoDoArquivoASerExibido: args[1]);
                return Task.FromResult(Result.Ok());

            }
            catch (Exception exception)
            {
               return Task.FromResult(Result.Fail(new Error("Importação falhou!").CausedBy(exception)));
            }
        }

        private void ExibeConteudoArquivo(string caminhoDoArquivoASerExibido)
        {
            var listaDepets = leitor.RealizaLeitura();
            foreach (var pet in listaDepets)
            {
                consoleUI.WriteLine(pet.ToString());
            }


        }
    }
}
