using NameespaceUsing.Calculadora;
using static System.Math;
using static NameespaceUsing.Calculadora.Calculadora;
using static NameespaceUsing.Calculadora.Matematica;
using static NameespaceUsing.Calculadora.MatematicaExtensions;



public static class TestesCalculadoras
{
    public static void TestarAbordagens()
    {
        double x = 2, y = 3;
        
        // 1. Tradicional (mais verboso)
        var resultado1 = Math.Pow(x, y);
        
        // 2. using static (mais conciso)
        var resultado2 = Pow(x, y);
        
        // 3. Classe estática customizada
        var resultado3 = Calculadora.Potencia(x, y);
        
        // 4. using static custom
        var resultado4 = Potencia(x, y); // ← Potencia vem de Calculadora
        
        // 5. Método de instância
        var mat = new Matematica();
        var resultado5 = mat.Potencia(x, y);
        
        // 6. Extension method
        var resultado6 = x.ElevadoA(y);
        
        Console.WriteLine($"Todos devem ser 8: {resultado1}, {resultado2}, {resultado3}, {resultado4}, {resultado5}, {resultado6}");
    }
}