using System;

class Program {
  public static void Main (string[] args) {
    string novoCalculo = "Sim";
    while(novoCalculo.Equals("Sim") || novoCalculo.Equals("sim")) {
    Console.Write("Informe o valor da gasolina: R$");
      double pG = double.Parse(Console.ReadLine());
    Console.Write("Informe o valor do álcool: R$");
      double pA = double.Parse(Console.ReadLine());
        double divisaoPaPg = pA/pG;
    if(divisaoPaPg > 0.7) {
      Console.WriteLine("A gasolina é mais vantajosa do que o álcool.");
    }
    else if(divisaoPaPg < 0.7) {
      Console.WriteLine("O álcool é mais vantajoso do que a gasolina.");
    }
    else {
      Console.WriteLine("Pode escolher tanto o álcool quanto a gasolina, nenhum dos dois possui uma vantagem sobre o outro.");
    }
      Console.Write("Deseja efetuar um novo cálculo? ");
      novoCalculo = Console.ReadLine();
    }
    Console.WriteLine("Até logo!");
  }
}