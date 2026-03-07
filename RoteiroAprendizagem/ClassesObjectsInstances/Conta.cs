internal class Conta
{
  private string _titular;
  private decimal _saldo;

   private int _numConta;
  

  public Conta(string titular, decimal saldo)
  {
    _titular = titular;
    _saldo = saldo;
    _numConta = GerarNumeroConta();
  }

 private int GerarNumeroConta()
  {
    Random random = new Random();
    return random.Next(1000, 9999);
  }

  public void Sacar(decimal valor)
  {
    if (valor > _saldo)
    {
      Console.WriteLine("Saldo insuficiente para saque.");
      return;
    }
    _saldo -= valor;
  }

  public void Depositar(decimal valor)
  {
    _saldo += valor;
  }

  public void ExibirDados()
  {
    Console.WriteLine($"Titular: {_titular}, Saldo: {_saldo}, NumConta: {_numConta}");
  }

  public void Transferir(Conta contaDestino, decimal valor)
  {
    Sacar(valor);
    contaDestino.Depositar(valor);
    Console.WriteLine($"Transferência de R${valor} feita para {contaDestino._titular}");
  }
}