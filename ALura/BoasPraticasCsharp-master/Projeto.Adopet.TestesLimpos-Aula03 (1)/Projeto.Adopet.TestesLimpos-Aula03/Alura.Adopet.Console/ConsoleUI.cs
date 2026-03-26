using System;

namespace Alura.Adopet.Console
{
    /// <summary>
    /// Interface para abstrair a comunicação com o console.
    /// Facilita testes e separa a responsabilidade de exibição.
    /// </summary>
    public interface IConsoleUI
    {
        void WriteLine(string message);
        void WriteLine(ConsoleColor color, string message);
        void WriteError(string message);
        void WriteSuccess(string message);
        void ResetColor();
    }

    /// <summary>
    /// Implementação concreta que encapsula todas as operações de console.
    /// Responsável apenas por exibir informações no terminal.
    /// </summary>
    public class ConsoleUI : IConsoleUI, IDisposable
    {
        private bool _disposed = false;

        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        public void WriteLine(ConsoleColor color, string message)
        {
            var previousColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(message);
            System.Console.ForegroundColor = previousColor;
        }

        public void WriteError(string message)
        {
            WriteLine(ConsoleColor.Red, message);
        }

        public void WriteSuccess(string message)
        {
            WriteLine(ConsoleColor.Green, message);
        }

        public void ResetColor()
        {
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                ResetColor();
                _disposed = true;
            }
        }
    }
}
