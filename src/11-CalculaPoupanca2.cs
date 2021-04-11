using System;

namespace StartingCSharp
{
    class CalculaPoupanca2:IStartingSample
    {
    public string Description {get
      {
        return "Vai fazer o cálculo do rendimento da poupança ao longo de 1 ano (12 meses)";
      }
    }

    static void Run(string[] args)
        {
            Console.WriteLine("Executando projeto 11");
            double valorInvestido = 1000;
            for (int contadorMes = 1;contadorMes <= 12;contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Após {contadorMes} mês, você terá R$ {valorInvestido}");
            }
            Console.ReadLine();
        }

    public void Run()
    {
      throw new NotImplementedException();
    }
  }
}
