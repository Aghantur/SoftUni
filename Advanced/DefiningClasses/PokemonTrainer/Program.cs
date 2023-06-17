using PokemonTrainer;

List<Trainer> trainers = new();

while (true)
{
	string command = Console.ReadLine();
	if (command == "Tournament")
	{
		break;
	}

	string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

	Trainer trainer = trainers.SingleOrDefault(x => x.Name == tokens[0]);

	if (trainer == null)
	{
		trainer = new(tokens[0]);
		trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
		trainers.Add(trainer);
	}
	else
	{
		trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
	}
}
while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    foreach (var trainer in trainers)
    {
        trainer.CheckPokemon(command);
    }
}

foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
{
    Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
}
    