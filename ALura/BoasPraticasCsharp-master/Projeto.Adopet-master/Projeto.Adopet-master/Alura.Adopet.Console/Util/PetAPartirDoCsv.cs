using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util;

public static class PetAPartirDoCsv
{
  public static Pet ConverteDoTexto(this string? linha)
  { 
    if (linha == null) throw new ArgumentNullException("Arguemnto não pode ser nulo!");
    if (string.IsNullOrEmpty(linha)) throw new ArgumentException("texto naõ pode ser vazio");
    string[]? propriedades = linha.Split(';');
    return new Pet(Guid.Parse(propriedades[0]),
    propriedades[1],
    int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
    );
  }
}