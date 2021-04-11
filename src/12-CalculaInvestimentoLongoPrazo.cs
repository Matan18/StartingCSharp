using System;

namespace StartingCSharp
{
  class CalculandoInvestimentoLongoPrazo : IStartingSample
  {
    public string Description
    {
      get
      {
        return "Calcula o rendimento de um investimento durante 5 anos";
      }
    }

    public void Run()
    {
      Console.WriteLine("Executando projeto 12");
      double fatorRendimento = 1.0036;
      double valorInvestido = 1000;
      int contadorAno;
      for (contadorAno = 1; contadorAno <= 5; contadorAno++)
      {
        for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
        {
          valorInvestido *= fatorRendimento;

        }


        fatorRendimento += 0.0010;
      }

      Console.WriteLine("tempo de investimento foi de " + contadorAno);
      Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

      Console.ReadLine();
    }
  }
}
