using System;

namespace StartingCSharp
{
  class Escopo : IStartingSample
  {
    public string Description => "Faz teste se a mensagemAdicional é atualizada fora do if/else";
    public void Run()
    {
      Console.WriteLine("Executando projeto 9 - Escopo");
      int idadeJoao = 18;
      bool acompanhado = true;
      string mensagemAdicional;
      if (acompanhado == true)
      {
        mensagemAdicional = "João está acompanhado!";
      }
      else
      {
        mensagemAdicional = "João não está acompanhado";
      }

      if (idadeJoao >= 18 || acompanhado == true)
      {
        Console.WriteLine("Pode entrar.");
        Console.WriteLine(mensagemAdicional);
      }
      else
      {
        Console.WriteLine("João não pode entrar");
      }

      Console.ReadLine();
    }
  }
}
