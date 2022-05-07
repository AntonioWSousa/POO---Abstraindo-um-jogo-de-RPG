namespace DotNet_Project.src.Entities
{
  public class Cleric : Hero
  {
    public Cleric(string name, int level, string heroType)
    {
      this.name = name;
      this.level = level;
      this.heroType = heroType;
    }
    public override string Attack()
    {
      return this.name + " Use magic";
    }

    public string Attack(int Bonus)
    {
      if (Bonus > 8)
        return this.name + " Use effective cure " + Bonus;
    } else {
      return this.name + " Use weak magic" + Bonus;
    }

}

}