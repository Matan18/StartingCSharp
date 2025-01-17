﻿using System;

namespace StartingCSharp
{
  class Condicionais : IStartingSample
  {
    public String Description => "Faz teste de condicionais (if/else)";
    public void Run()
    {
      Console.WriteLine("Executando projeto 7 - Condicionais");
      int idadeJoao = 16;
      int quantidadePessoas = 2;
      if (idadeJoao >= 18)
      {
        Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar");
      }
      else
      {
        if (quantidadePessoas >= 2)
        {
          Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
        }
        else
        {
          Console.WriteLine("João não possui mais de 18 anos de idade. Não pode entrar");
        }

      }

      Console.ReadLine();
    }
  }
}
