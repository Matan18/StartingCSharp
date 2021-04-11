using System;

namespace StartingCSharp
{
  class CaracteresETextos : IStartingSample
  {
    public String Description => "Faz testes usando \' \' ou \" \"";
    public void Run()
    {
      Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
      Char primeiraLetra = ' ';
      Console.WriteLine(primeiraLetra);
      primeiraLetra = (char)65;
      Console.WriteLine(primeiraLetra);
      primeiraLetra = (char)(primeiraLetra + 1);
      Console.WriteLine(primeiraLetra);

      string titulo = "Alura Cursos de tecnologia " + 2019;
      string cursosProgramacao = @"  - .NET
  - Java
  - Javascript ";
      Console.WriteLine(titulo);
      Console.WriteLine(cursosProgramacao);
    }
  }
}
