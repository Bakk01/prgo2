class demon : Creature
{
  public demon()
  {
    intelligence = Random.Shared.Next(2, 10);
    toughness = Random.Shared.Next(10, 18);
    strength = Random.Shared.Next(5, 15);

    Console.WriteLine("Created zombie with intelligence " + intelligence + ", toughness " + toughness + " and strength " + strength);
  }
}