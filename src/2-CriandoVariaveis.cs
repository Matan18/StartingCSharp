using System;

namespace StartingCSharp
{
  class CriandoVariaveis : IStartingSample
  {
    public String Description => "Demonstra criação e alteração de variáveis";
    public void Run()
    {
      Console.WriteLine("Executando projeto 2 - Criando Variaveis");

      int idade;
      idade = 32;
      Console.WriteLine(idade);
      idade = 10;
      Console.Write(idade);
      idade = 10 + 5;
      Console.WriteLine(idade);
      idade = 10 + 5 * 2;
      Console.WriteLine("Sua idade é " + idade);
      idade = (10 + 5) * 2;
      Console.WriteLine(idade);
      Console.WriteLine("Execução finalizada. Tecle enter para sair...");
      Console.ReadLine();
    }
  }
}
