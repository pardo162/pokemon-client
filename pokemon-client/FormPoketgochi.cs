using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace pokemon_client
{
    public partial class FormPoketgochi : Form
    {
        private string name;
        private string password;
        private bool loading;
        private int slectedPk;
        private string[] pokemons;
        private List<int> pokemonsId = new List<int>();
        private List<int> pokemonsHealth = new List<int>();
        private List<int> pokemonsLevel = new List<int>();
        private List<string> pokemonsName = new List<string>();
        private List<string> pokemonsType = new List<string>();
        private List<int> pokemonsMaxHealth = new List<int>();
        private List<int> pokemonsAttack = new List<int>();
        public FormPoketgochi()
        {
            InitializeComponent();
        }

        private void FormPoketgochi_Load(object sender, EventArgs e)
        {
            InitializeGui();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            buttonLogIn.Hide();
            if(!loading)
            {
                name = textName.Text;
                password = textPassword.Text;
                if (name.Length > 0 && password.Length > 0)
                {
                    loading = true;
                    _ = GetPokedex();
                }
            }
        }

        private async Task GetPokedex()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("pokeapi.co/api"));
            client.DefaultRequestHeaders.Add("User-pokemon", "pokemon api");
            var stringResponse = client.GetStringAsync("https://europe-west1-pokegotchi-alejo.cloudfunctions.net/getPokedex?text=" + name + "," + password);
            string ponkemonsData = await stringResponse;
            pokemons = ponkemonsData.ToString().Split('/');
            string[] pokemonInfo;
            for (int i = 0; i < pokemons.Length; i++)
            {
                pokemonInfo = pokemons[i].Split(',');   
                pokemonsId.Add(int.Parse(pokemonInfo[0]));
                pokemonsHealth.Add(int.Parse(pokemonInfo[1]));
                pokemonsLevel.Add(int.Parse(pokemonInfo[2]));
            }
            _ = ConsultAPI(0);
        }

        private async Task ConsultAPI(int n)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("pokeapi.co/api"));
            client.DefaultRequestHeaders.Add("User-pokemon", "pokemon api");
            var ponkemonApi = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + pokemonsId[n]);
            var pokemonInfo = await ponkemonApi;
            dynamic infoJason = JObject.Parse(pokemonInfo);
            string aux = infoJason.forms[0].name;
            comboBoxPokemons.Items.Add(aux);
            pokemonsName.Add(aux);
            int i = 0;
            aux = "";
            while (i < infoJason.types.Count)
            {
                aux += infoJason.types[i].type.name + " ";
                i += 1;
            }
            aux = aux.Substring(0, aux.Length - 1);
            pokemonsType.Add(aux);
            aux = infoJason.stats[0].base_stat;
            pokemonsMaxHealth.Add(int.Parse(aux));
            aux = infoJason.stats[1].base_stat;
            pokemonsAttack.Add(int.Parse(aux));
            if(n < pokemonsId.Count - 1)
            {
                _ = ConsultAPI(n + 1);
            }
            else
            {
                loading = false;
                HideLoginGui();
            }
        }

        public void InitializeGui()
        {
            pictureMain.Controls.Add(picturePokemon);
            picturePokemon.BackColor = Color.Transparent;
            picturePokemon.Hide();
            buttonFeed.Hide();
            buttonFight.Hide();
            comboBoxPokemons.Hide();
            labelType.Hide();
            labelHP.Hide();
            labelAttack.Hide();
            labelLevel.Hide();
        }

        public void HideLoginGui()
        {
            labelName.Hide();
            labelPassword.Hide();
            textName.Hide();
            textPassword.Hide();
            comboBoxPokemons.Show();
            labelType.Show();
            labelHP.Show();
            labelAttack.Show();
            picturePokemon.Show();
            buttonFeed.Show();
            buttonFight.Show();
            comboBoxPokemons.SelectedIndex = 0;
            labelType.Text = pokemonsType[0];
            labelHP.Text = "HP: " + (int)(pokemonsMaxHealth[0] *(pokemonsHealth[0]/100)) + "/" + pokemonsMaxHealth[0];
            labelAttack.Text = "Att: " + pokemonsAttack[0];
            labelLevel.Text = "Exp: " + pokemonsLevel[0];
            Image imagePokemon = Image.FromFile("pokemon1.png");
            picturePokemon.Image = imagePokemon;
        }

        private void comboBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            slectedPk = comboBoxPokemons.SelectedIndex;
            labelType.Text = pokemonsType[slectedPk];
            labelHP.Text = "HP: " + (int)(pokemonsMaxHealth[slectedPk] * (pokemonsHealth[slectedPk] / 100)) + "/" + pokemonsMaxHealth[slectedPk];
            labelAttack.Text = "Att: " + pokemonsAttack[slectedPk];
            labelLevel.Text = "Exp: " + pokemonsLevel[slectedPk];
            Image imagePokemon = Image.FromFile("pokemon"+ pokemonsId[slectedPk] + ".png");
            picturePokemon.Image = imagePokemon;
        }
    }
}
