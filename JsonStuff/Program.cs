// See https://aka.ms/new-console-template for more information

using JsonStuff;
using Newtonsoft.Json;

Console.WriteLine("Pokédex World!");

String file = "pokedex.json";
StreamReader sr = new StreamReader(file);

// test that the file opens
// Console.WriteLine(sr.ReadLine());

List<Pokemon> pokemons;

pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(sr.ReadToEnd());

Console.WriteLine(pokemons.Count);

foreach (Pokemon pokemon in pokemons)
{
    if (pokemon.id == 1)
    {
        Console.WriteLine(pokemon);
        if (pokemon.stats != null)
        {
            Console.WriteLine(pokemon.stats.HP);
        }

        foreach (string[] abils in pokemon.profile.ability)
        {
            Console.Write(abils[0] + " ");
            if (abils[1] == "true")
            {
                Console.Write("✅ \n"); 
            }
            else
            {
                Console.Write("❌ \n"); 
            }
        }
        
    }
}
