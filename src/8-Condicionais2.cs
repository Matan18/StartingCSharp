using System;

namespace StartingCSharp
{
  class Condicionais2 : IStartingSample
  {
    public String Description => "Faz teste de condicionais (if/else)";
    public void Run()
    {
      Console.WriteLine("Executando projeto 8 - Condicionais 2");
      int idadeJoao = 18;
      int quantidadePessoas = 2;

      bool acompanhado = quantidadePessoas >= 2;

      if (idadeJoao >= 18 && acompanhado == true)
      {
        Console.WriteLine(acompanhado);
      }
      else
      {
        Console.WriteLine("João não pode entrar");
      }

      Console.ReadLine();
    }
  }
}
