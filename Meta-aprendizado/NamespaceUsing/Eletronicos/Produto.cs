namespace NameespaceUsing.Eletronicos
{
  public class Produto
  {
    public string Nome { get; set; }
    public double PrecoUSD { get; set; }

    public decimal convertToReal(double precoUSD) => (decimal)precoUSD * 3.5m;
  }
}