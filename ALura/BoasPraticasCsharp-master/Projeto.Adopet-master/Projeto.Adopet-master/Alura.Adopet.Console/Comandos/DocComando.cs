namespace Alura.Adopet.Console.Comandos;

[AttributeUsage(AttributeTargets.Class)]
class DocComando : System.Attribute
{
  public string Instrucao { get; }
  public string Documentacao { get; }
  internal DocComando(string instrucao, string documentacao)
  {
    Instrucao = instrucao;
    Documentacao = documentacao;
  }
}