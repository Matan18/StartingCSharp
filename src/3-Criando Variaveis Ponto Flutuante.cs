using System;

namespace StartingCSharp
{
  class CriandoVariaveisPontoFlutuante : IStartingSample
  {
    public String Description => "Faz teste com variáveis de ponto Flutuante";
    public void Run()
    {
      Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

      double salario;
      salario = 1200.70;

      Console.WriteLine(salario);
      double idade;
      idade = 15 / 2.0;
      Console.WriteLine(idade);
      Console.WriteLine("5/3= " + idade);
      idade = 5.0 / 3;
      Console.WriteLine("5.0/3 = " + idade);
      Console.WriteLine("meu salario é " + salario);
      Console.WriteLine("A execução acabou. Tecle enter para sair...");
      Console.ReadLine();
    }
  }
}
