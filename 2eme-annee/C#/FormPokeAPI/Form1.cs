using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using FormPokeAPI.Modele;
namespace FormPokeAPI
{
    public partial class Form1 : Form
    {

        private readonly HttpClient client;
        static HttpClientHandler httpClientHandler;
        static WebProxy proxy;
        Equipe equip;

        public Form1()
        {
            InitializeComponent();

            equip = new Equipe();

            proxy = new WebProxy
            {
                Address = new Uri($"http://192.168.100.55:3128"),
                BypassProxyOnLocal = false,
                UseDefaultCredentials = false,
                // Proxy credentials
                Credentials = new NetworkCredential(
        userName: "lerbuer",
        password: "Mai140323.")
            };
            httpClientHandler = new HttpClientHandler
            {
                Proxy = proxy,
            };

            client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
        }

        private async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new
            MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            await StreamTaskPikachu();
            Pokedex pokedex = await StreamTaskAll();

        }

        private async Task<Pokedex> StreamTaskAll()
        {
            var stream = await client.GetStreamAsync("https://pokeapi.co/api/v2/pokemon?limit=10000");


            var response = await JsonSerializer.DeserializeAsync<PokeApiResponse>(stream);

            Pokedex pokedex = new Pokedex();

            foreach (var pokemon in response.results)
            {
                pokedex.AjouterEntree(pokemon);
                this.LstPoke.Items.Add(pokemon);
            }

            return pokedex;

        }

        private async void LstPoke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstPoke.SelectedItem is not Entree selected)
                return;

            // Appel API pour récupérer toutes les infos du Pokémon
            var stream = await client.GetStreamAsync(selected.url);
            var dto = await JsonSerializer.DeserializeAsync<PokemonDTO>(
                stream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            // Transformation DTO -> ton modèle Pokemon
            var pokemon = new Pokemon
            {
                name = dto.Name,
                type1 = dto.Types.ElementAtOrDefault(0)?.Type.Name,
                type2 = dto.Types.ElementAtOrDefault(1)?.Type.Name ?? "none",
                base_exp = dto.Base_Experience,
                height = dto.Height,
                weight = dto.Weight,
                sprite = dto.Sprites.Front_Default ?? "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/0.png"
            };

            // Utilise ta méthode existante pour remplir les contrôles
            ChargerPokemon(pokemon);
        }

        private void ChargerPokemon(Pokemon pokemon)
        {
            this.name.Text = pokemon.name;
            this.type1.Text = pokemon.type1;
            this.type2.Text = pokemon.type2;
            this.bsexp.Text = pokemon.base_exp.ToString();
            this.height.Text = pokemon.height.ToString();
            this.weight.Text = pokemon.weight.ToString();


            this.pctBPoke.Load(pokemon.sprite);
        }




        private async Task StreamTaskPikachu()
        {
            var stream = await client.GetStreamAsync("https://pokeapi.co/api/v2/pokemon/pikachu");
            var dto = await JsonSerializer.DeserializeAsync<PokemonDTO>(
                stream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            // Transformation DTO -> ton modèle actuel
            var pokemon = new Pokemon
            {
                name = dto.Name,
                type1 = dto.Types.ElementAtOrDefault(0)?.Type.Name,
                type2 = dto.Types.ElementAtOrDefault(1)?.Type.Name ?? "none",
                base_exp = dto.Base_Experience,
                height = dto.Height,
                weight = dto.Weight,
                sprite = dto.Sprites.Front_Default
            };

            this.name.Text = pokemon.name;
            this.type1.Text = pokemon.type1;
            this.type2.Text = pokemon.type2;
            this.bsexp.Text = pokemon.base_exp.ToString();
            this.height.Text = pokemon.height.ToString();
            this.weight.Text = pokemon.weight.ToString();


            this.pctBPoke.Load(pokemon.sprite);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ProcessRepositories();
        }

        private async void AddE_Click(object sender, EventArgs e)
        {
            if (LstPoke.SelectedItem is not Entree selected)
                return;

            // Appel API pour récupérer toutes les infos du Pokémon
            var stream = await client.GetStreamAsync(selected.url);
            var dto = await JsonSerializer.DeserializeAsync<PokemonDTO>(
                stream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            // Transformation DTO -> ton modèle Pokemon
            var pokemon = new Pokemon
            {
                name = dto.Name,
                type1 = dto.Types.ElementAtOrDefault(0)?.Type.Name,
                type2 = dto.Types.ElementAtOrDefault(1)?.Type.Name ?? "none",
                base_exp = dto.Base_Experience,
                height = dto.Height,
                weight = dto.Weight,
                sprite = dto.Sprites.Front_Default
            };

            equip.AjouterPokemon(pokemon);

        }

        private void consultE_Click(object sender, EventArgs e)
        {
            this.Hide();
            equipe f = new equipe(equip,this);
            f.ShowDialog();
        }
    }
}
