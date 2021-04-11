using System;

namespace StartingCSharp
{
  class CalculaPoupanca : IStartingSample
  {
    public string Description => "Calcula o rendimento da poupança em 12 meses usando while";

    static void Run(string[] args)
    {
      Console.WriteLine("Executando projeto 10 - Calcula Poupança");
      double valorInvestido = 1000;
      int contadorMes = 1;
      while (contadorMes <= 12)
      {
        valorInvestido = valorInvestido + valorInvestido * 0.0036;
        Console.WriteLine("Após " + contadorMes + " mês, você terá R$ " + valorInvestido);
        //contadorMes += 1;
        contadorMes++;
      }


      Console.ReadLine();
    }

    public void Run()
    {
      throw new NotImplementedException();
    }
  }
}
