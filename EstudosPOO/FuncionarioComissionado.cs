public class FuncionarioComissionado: Funcionario, IBeneficios
{
  public decimal Comissao {get; set;}

  protected override decimal CalcularSalario()
  {
    return SalarioBase + Comissao ;
  }

  public decimal CalcularBeneficio()
  {
    return Comissao;
  }

  public void ExibirBeneficio()
  {
    Console.WriteLine(Comissao);
  }

}