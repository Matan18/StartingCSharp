using System;

namespace StartingCSharp
{
  class TesteCaracteres : IStartingSample
  {
    public String Description => "Faz teste atribuição de caracres, sintaxe: (char)número baseado na tabela ASCII";
    public void Run()
    {
      System.Console.WriteLine("Escrevendo vários caracteres em linha!");
      char v = (char)77;
      Console.Write(v);
      v = (char)97;
      Console.Write(v);
      v = (char)116;
      Console.Write(v);
      v = (char)97;
      Console.Write(v);
      v = (char)110;
      Console.Write(v);
      Console.ReadLine();
    }
  }
}
