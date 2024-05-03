
class Program
{
    static void Main(string[] args)
    {
        List<Hero> heroes = new List<Hero>();
        List<Demon> demons = new List<Demon>();

        // Get number of heroes/demons
        int num = -1;
        bool success = false;
        while (!success || num < 1)
        {
            Console.Write("Please type in the number of demons and heroes to create for each team: ");
            string inputNum = Console.ReadLine();
            success = int.TryParse(inputNum, out num);

            if (!success || num < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }
        }

        // Create heroes & demons
        for (int i = 0; i < num; i++)
        {
            Hero newHero = new Hero();
            Demon newDemon = new Demon();
            heroes.Add(newHero);
            demons.Add(newDemon);
        }

        // Type out the number of hero/demon
        Console.WriteLine("Created " + heroes.Count + " heroes.");
        Console.WriteLine("Created " + demons.Count + " demons.");

        Console.ReadLine();
    }
}

class Hero
{
    // Hero class definition
}

class Demon
{
    // Demon class definition
}
