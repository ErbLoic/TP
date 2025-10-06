using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokéAPI
{
    internal class Program
    {
        static WebProxy proxy = new WebProxy
        {
        Address = new Uri($"http://192.168.100.55:3128"),
        BypassProxyOnLocal = false,
        UseDefaultCredentials = false,
        // Proxy credentials
        Credentials = new NetworkCredential(
        userName: "lerbuer",
        password:"Mai140323.")
        };

        static HttpClientHandler httpClientHandler = new HttpClientHandler
        {
        Proxy = proxy,
        };

        private static readonly HttpClient client = new HttpClient(handler: httpClientHandler,disposeHandler: true);

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            Console.WriteLine("Donner un id de pokemon");
            int id = Convert.ToInt32(Console.ReadLine());
            await StreamTaskone(id);
        }
        private static async Task StringTaskPikachu()
        {
            //Cette méthode permet de récupèrer tout le resultat retourné par l'api sur le
            //pokemon pikachu avec tout le detail sur le JSON
            //Le JSON est retourné sous forme de texte brut puis affiché dans la console.
            //ça peut être utile pour analyser ce que l'api retourne et tester si ça fonctionne bien
            var stringTask = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/pikachu");
            var msg = await stringTask;
            Console.Write(msg);
        }

        private static async Task StreamTaskPikachu()
        {

            var streamTask = client.GetStreamAsync("https://pokeapi.co/api/v2/pokemon/pikachu");
            var pokemon = await JsonSerializer.DeserializeAsync<Pokemon>(await
            streamTask);
            Console.WriteLine(pokemon.ToString());
        }


        private static async Task StreamTaskone(int id)
        {

            var url = $"https://pokeapi.co/api/v2/pokemon/{id}";
            var streamTask = await client.GetStreamAsync(url);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Objet temporaire qui reflète la structure JSON de PokeAPI
            var rawPokemon = await JsonSerializer.DeserializeAsync<JsonPokemon>(streamTask, options);

            // Conversion vers TA classe
            var pokemon = new Pokemon
            {
                id = rawPokemon.id,
                name = rawPokemon.name,
                base_experience = rawPokemon.base_experience,
                height = rawPokemon.height,
                abilities = rawPokemon.abilities.Select(a => a.ability.name).ToList(),
                types = rawPokemon.types.Select(t => t.type.name).ToList(),
                sprites = new List<string> { rawPokemon.sprites.front_default }
            };

            Console.WriteLine(pokemon.ToString());
        }

        public class JsonPokemon
        {
            public int id { get; set; }
            public string name { get; set; }
            public double base_experience { get; set; }
            public double height { get; set; }
            public List<AbilityWrapper> abilities { get; set; }
            public List<TypeWrapper> types { get; set; }
            public Sprites sprites { get; set; }
        }

        public class AbilityWrapper
        {
            public Ability ability { get; set; }
        }
        public class Ability
        {
            public string name { get; set; }
        }

        public class TypeWrapper
        {
            public TypeInfo type { get; set; }
        }
        public class TypeInfo
        {
            public string name { get; set; }
        }

        public class Sprites
        {
            public string front_default { get; set; }
        }



        static async Task Main(string[] args)
        {
            await ProcessRepositories();

        }
    }
}
