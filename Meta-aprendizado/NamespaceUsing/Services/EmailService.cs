namespace NameespaceUsing.Services;

public class EmailService
{
  public void EnviarEmail(string email, string assunto, string mensagem)
  {
    Console.WriteLine($"Enviando email para {email}:");
    Console.WriteLine($"Assunto: {assunto}");
    Console.WriteLine($"Mensagem: {mensagem}");
  }
}