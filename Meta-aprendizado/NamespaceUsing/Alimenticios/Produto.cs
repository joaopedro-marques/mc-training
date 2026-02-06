namespace NameespaceUsing.Alimenticios
{
  public class Produto
  {
    public string Nome { get; set; }
    public double PrecoBRL { get; set; }

    public decimal CalcularImposto(double precoBRL) => (decimal)precoBRL * 1.27m;
  }
}