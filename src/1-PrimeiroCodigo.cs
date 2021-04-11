using System;

namespace StartingCSharp
{
  class PrimeiroCodigo : IStartingSample
  {
    public string Description => "Faz um Console simples";

    public void Run()
    {
      Console.WriteLine("Hello, World, Write in Visual Studio Code!");
      Console.WriteLine("A execução acabou. Tecle enter para finalizar...");
      Console.ReadLine();
    }
  }
}
