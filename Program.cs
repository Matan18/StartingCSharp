using System;

namespace StartingCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      ShowOptions();
    }
    static void ShowOptions()
    {
      IStartingSample[] listaDeExecucoes = {
        new PrimeiroCodigo(),
        new CriandoVariaveis(),
        new CriandoVariaveisPontoFlutuante(),
        new CaracteresETextos(),
        new TesteCaracteres(),
        new AtribuicoesDeVariaveis(),
        new Condicionais(),
        new Condicionais2(),
        new Escopo(),
        new CalculaPoupanca(),
        new CalculaPoupanca2(),
        new CalculandoInvestimentoLongoPrazo(),
        new ForEncadeado()
      };
      String variavel = "Escolha um número entre 1 e 13 para rodar um código diferente, aqui está a lista de execuções:";
      Console.WriteLine(variavel);
      for (int i = 0; i < listaDeExecucoes.Length; i++)
      {
        Console.WriteLine($"{i} - {listaDeExecucoes[i].Description}");
      }
      String selected = Console.ReadLine();
      int SelectedNumber = Int32.Parse(selected.ToString());
      Console.WriteLine($"Executando código {SelectedNumber}");
      listaDeExecucoes[SelectedNumber].Run();
    }
  }
}
