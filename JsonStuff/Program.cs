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
    Console.WriteLine(pokemon);
}
