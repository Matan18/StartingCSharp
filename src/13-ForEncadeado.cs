using System;

namespace StartingCSharp
{
  class ForEncadeado : IStartingSample
  {
    public string Description { get => "Executa um exemplo de for dentro de outro for"; }
    public void Run()
    {
      Console.WriteLine("Projeto 13:");

      for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
      {
        for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
        {
          Console.Write("*");
          if (contadorColuna >= contadorLinha)
            break;
        }
        Console.WriteLine();
      }

      Console.ReadLine();
    }
  }
}
