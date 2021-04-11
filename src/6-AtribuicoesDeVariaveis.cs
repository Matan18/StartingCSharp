using System;

namespace StartingCSharp
{
  class AtribuicoesDeVariaveis : IStartingSample
  {
    public String Description => "Faz teste para atualizar valores a variaveis";
    public void Run()
    {
      Console.WriteLine("Executando projeto 6 - Atribuições de variaveis");
      int idade = 32;
      int idadeGustavo = idade;
      idade = 20;

      Console.WriteLine(idade);
      Console.WriteLine(idadeGustavo);
      Console.ReadLine();
    }
  }
}
