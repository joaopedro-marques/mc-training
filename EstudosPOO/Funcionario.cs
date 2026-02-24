public abstract class  Funcionario
{ 
  private string _nome;
   public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            _nome = value;
        }
  }

  private string _cpf;
   public string Cpf
    {
        get { return _cpf; }
        set
        {
            if (value.Length < 11)
            {
                throw new ArgumentException("O cpf tem menos do que 11 digitos");
            }
            _cpf = value;
        }
    }
  private decimal _salarioBase;

   public decimal SalarioBase
    {
        get { return _salarioBase; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O salário não pode ser negativo.");
            }
            _salarioBase = value;
        }
    }


  protected virtual decimal CalcularSalario()
  {
    return SalarioBase;
  }

  public void ExibirDados()
  {
    Console.WriteLine($" Nome: {Nome}, Cpf: {Cpf}, Salário: {CalcularSalario()}");
  }
}