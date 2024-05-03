class hero : Creature
{
  public hero()
  {
    intelligence = Random.Shared.Next(10, 25);
    toughness = Random.Shared.Next(10, 25);
    strength = Random.Shared.Next(10, 25);

    Console.WriteLine("Created dinosaur with intelligence " + intelligence + ", toughness " + toughness + " and strength " + strength);
  }
}