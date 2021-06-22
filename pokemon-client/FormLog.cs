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
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace pokemon_client
{
    public partial class FormPoketgochi : Form
    {
        private readonly HttpClient client = new HttpClient();
        private string name;
        private string password;
        private bool loadin;
        private string[] pokemons;
        private List<int> pokemonsId = new List<int>();
        private List<int> pokemonsHealth = new List<int>();
        private List<int> pokemonsLevel = new List<int>();
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
            if(!loadin)
            {
                name = textName.Text;
                password = textPassword.Text;
                if (name.Length > 0 && password.Length > 0)
                {
                    loadin = true;
                    _ = GetPokedex();
                }
            }
        }

        private async Task GetPokedex()
        {
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
                comboBoxPokemons.Items.Add(pokemonInfo[0]);   
                pokemonsId.Add(int.Parse(pokemonInfo[0]));
                pokemonsHealth.Add(int.Parse(pokemonInfo[1]));
                pokemonsLevel.Add(int.Parse(pokemonInfo[2]));
            }
            loadin = false;
            HideLoginGui();
        }

        public void InitializeGui()
        {
            comboBoxPokemons.Hide();
        }

        public void HideLoginGui()
        {
            labelName.Hide();
            labelPassword.Hide();
            textName.Hide();
            textPassword.Hide();
            buttonLogIn.Hide();
            comboBoxPokemons.Show();
        }
    }
}
