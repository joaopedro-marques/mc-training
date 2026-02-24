using System.Reflection.Emit;

public class Candidato
{
  public string Nome { get; set; }
  public ushort Idade { get; set; }
  public string Stack { get; set; }

  public Candidato(string nome, ushort idade, string stack)
  { 

    Nome = nome;
    Idade = idade;
    Stack = stack;
  }

  public bool IsAproved()
  {
    if(Idade > 18 && Stack == "C#") return true;
    else return false;
  }

  public bool validateCadastro()
  {
    if (Idade < 0 || Nome == null || Nome == "") return false;
    return true;
  }
}