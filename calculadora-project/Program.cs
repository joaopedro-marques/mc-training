using System.Runtime.InteropServices;

Console.WriteLine("=== CONVERSOR COMPLETO ===");

while(true) {
    Console.WriteLine("\nOpções:");
    Console.WriteLine("1. Temperatura (C↔F)");
    Console.WriteLine("2. Distância (m↔ft)");
    Console.WriteLine("3. Peso (kg↔lb)");
    Console.WriteLine("4. Sair");
    Console.WriteLine("Escolha a opção:");

    string? escolha = Console.ReadLine();
    
    if (escolha == "4")
    {
      Console.WriteLine("Até mais!");
      break;
    }
        
    
    if (escolha == "1"){
        Console.WriteLine("Converter para (C ou F)?");
        string tipo = Console.ReadLine();
        float valor = float.Parse(Input("Valor: "));
        if (tipo == "C")
        {
          valor = (valor -32) * 5/9;
          Console.WriteLine($"Temperatura é {valor} ºC. ");
        }
        else
        {
          valor = (valor * 5/9) + 32;
          Console.WriteLine($"Temperatura é {valor} ºF");
        }

        string continuar = Input("Escolha: 1- Sair 2- Continuar convertendo");
        if (continuar == "2")  {Console.WriteLine("Continuando");} else {Console.WriteLine("Até logo"); break;} 
     }

       if (escolha == "2"){
        Console.WriteLine("Converter para (m ou ft)?");
        string tipo = Console.ReadLine();
        float valor = float.Parse(Input("Valor: "));
        if (tipo == "m")
        {
          valor = valor / 3.281f;
          Console.WriteLine($"A Metragem é {valor} . ");
        }
        else
        {
          valor = valor * 3.281f;
          Console.WriteLine($"Pés é {valor} ");
        }

        string continuar = Input("Escolha: 1- Sair 2- Continuar convertendo");
        if (continuar == "2")  {Console.WriteLine("Continuando");} else {Console.WriteLine("Até logo"); break;} 
     }

     if (escolha == "3"){
        Console.WriteLine("Converter para (kg ou lb)?");
        string tipo = Console.ReadLine();
        float valor = float.Parse(Input("Valor: "));
        if (tipo == "kg")
        {
          valor = valor / 2.205f;
          Console.WriteLine($"O peso é {valor} lbs. ");
        }
        else
        {
          valor = valor * 2.205f;
          Console.WriteLine($"O peso é {valor} kgs");
        }

        string continuar = Input("Escolha: 1- Sair 2- Continuar convertendo");
        if (continuar == "2")  {Console.WriteLine("Continuando");} else {Console.WriteLine("Até logo"); break;} 
     }
 
  }

    static string Input(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }