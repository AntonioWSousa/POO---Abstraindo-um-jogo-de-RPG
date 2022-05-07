using DotNet_Project.src.Entities;

namespace dotnet_poo
{

  class Program
  {
    static void Main(string[] args)
    {
      Knight hero = new Knight("Cless", 5, "Hero");
      Cleric cleric = new Cleric("Mint", 4, "Cleric");

      Console.WriteLine(hero.Attack());
      Console.WriteLine(cleric.Attack());
      Console.WriteLine(cleric.Attack(9));
    }
  }
}

