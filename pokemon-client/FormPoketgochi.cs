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
        private int selectedPk;
        private string[] pokemons;
        private List<int> pokemonsId = new List<int>();
        private List<string> pokemonsName = new List<string>();
        private List<string> pokemonsType = new List<string>();
        private List<int> pokemonsHealth = new List<int>();
        private List<int> pokemonsMaxHealth = new List<int>();
        private List<int> pokemonsAttack = new List<int>();
        private List<int> pokemonsLevel = new List<int>();
        private int rivalId;
        private string rivalName;
        private string rivalType;
        private int rivalHealt;
        private int rivalMaxHealt;
        private int rivalAttack;
        private int fighterMaxHealth;
        private int fighterHealth;
        private int fighterAttack;
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
            if(!loading)
            {
                buttonLogIn.Hide();
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
            _ = ConsultPokedexAPI(0);
        }

        private async Task ConsultPokedexAPI(int n)
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
                _ = ConsultPokedexAPI(n + 1);
            }
            else
            {
                HideLoginGui();
                loading = false;
            }
        }

        private void comboBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                selectedPk = comboBoxPokemons.SelectedIndex;
                labelType.Text = pokemonsType[selectedPk];
                labelHP.Text = "HP: " + (int)((pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]) * ((float)pokemonsHealth[selectedPk] / 100)) +
                    "/" + (int)(pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]);
                labelAttack.Text = "Att: " + (int)(pokemonsAttack[selectedPk] + 0.05f * pokemonsLevel[selectedPk]);
                labelLevel.Text = "Exp: " + pokemonsLevel[selectedPk];
                Image imagePokemon = Image.FromFile("pokemon" + pokemonsId[selectedPk] + ".png");
                picturePokemon.Image = imagePokemon;
            }
        }

        private void buttonFight_Click(object sender, EventArgs e)
        {
            if(!loading && pokemonsHealth[selectedPk] > 10)
            {
                loading = true;
                buttonFight.Hide();
                buttonFeed.Hide();
                fighterHealth = (int)((pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]) * ((float)pokemonsHealth[selectedPk] / 100));
                fighterMaxHealth = (int)(pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]);
                fighterAttack = (int)(pokemonsAttack[selectedPk] + 0.05f * pokemonsLevel[selectedPk]);
                _ = GetRival();
            }
        }

        private async Task GetRival()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("pokeapi.co/api"));
            client.DefaultRequestHeaders.Add("User-pokemon", "pokemon api");
            var stringResponse = client.GetStringAsync("https://europe-west1-pokegotchi-alejo.cloudfunctions.net/startFight?text=" + name + "," + password);
            string ponkemonsRival = await stringResponse;
            rivalId = int.Parse(ponkemonsRival);
            _ = ConsultRivalAPI();
        }

        private async Task ConsultRivalAPI()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("pokeapi.co/api"));
            client.DefaultRequestHeaders.Add("User-pokemon", "pokemon api");
            var ponkemonApi = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + rivalId);
            var pokemonInfo = await ponkemonApi;
            dynamic infoJason = JObject.Parse(pokemonInfo);
            string aux = infoJason.forms[0].name;
            rivalName = aux;
            int i = 0;
            aux = "";
            while (i < infoJason.types.Count)
            {
                aux += infoJason.types[i].type.name + " ";
                i += 1;
            }
            aux = aux.Substring(0, aux.Length - 1);
            rivalType = aux;
            aux = infoJason.stats[0].base_stat;
            rivalHealt = int.Parse(aux);
            rivalMaxHealt = rivalHealt;
            aux = infoJason.stats[1].base_stat;
            rivalAttack = int.Parse(aux);
            HideMainGui();
            loading = false;
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            if (!loading && pokemonsHealth[selectedPk] < 100)
            {
                loading = true;
                _ = FeedPokemon();
            }
        }

        private async Task FeedPokemon()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("pokeapi.co/api"));
            client.DefaultRequestHeaders.Add("User-pokemon", "pokemon api");
            var stringResponse = client.GetStringAsync("https://europe-west1-pokegotchi-alejo.cloudfunctions.net/feedPokemon?text=" + name + "," + password + "," + pokemonsId[selectedPk]);
            string response = await stringResponse;
            string[] pokemonInfo = response.Split(",");
            pokemonsHealth[selectedPk] = int.Parse( pokemonInfo[1]);
            pokemonsLevel[selectedPk] = int.Parse(pokemonInfo[2]);
            pictureHeart.Show();
            await Task.Delay(TimeSpan.FromSeconds(1));
            labelHP.Text = "HP: " + (int)((pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]) * ((float)pokemonsHealth[selectedPk] / 100)) +
                "/" + (int)(pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]);
            labelLevel.Text = "Exp: " + pokemonsLevel[selectedPk];
            labelAttack.Text = "Att: " + (int)(pokemonsAttack[selectedPk] + 0.05f * pokemonsLevel[selectedPk]);
            pictureHeart.Hide();
            loading = false;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (!loading)
            {
                buttonAttack.Hide();
                loading = true;
                _ = Attack();
            }
        }

        private async Task Attack()
        {
            int damage = 0;
            Random random = new Random();
            pictureHit2.Show();
            damage = random.Next(1, fighterAttack);
            rivalHealt = rivalHealt - damage;
            if (rivalHealt < 0) { rivalHealt = 0; }
            labelHealth2.Text = "HP: " + rivalHealt + "/" + rivalMaxHealt;
            await Task.Delay(TimeSpan.FromSeconds(1));
            pictureHit2.Hide();

            if(rivalHealt > 0)
            {
                pictureHit1.Show();
                damage = random.Next(1, rivalAttack);
                fighterHealth = fighterHealth - damage;
                if (fighterHealth < 0) { fighterHealth = 0; }
                labelHealth1.Text = "HP: " + fighterHealth + "/" + fighterMaxHealth;
                await Task.Delay(TimeSpan.FromSeconds(1));
                pictureHit1.Hide();
                if(fighterHealth == 0)
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    _ = EndFight();
                }
                else
                {
                    buttonAttack.Show();
                    loading = false;
                }
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
                _ = EndFight();
            }
        }

        private async Task EndFight()
        {
            int fighterId = pokemonsId[selectedPk];
            float healthAux = ((float)fighterHealth / (float)fighterMaxHealth) * 100;
            int healthPercentage = (int)healthAux;
            pokemonsHealth[selectedPk] = healthPercentage;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("pokeapi.co/api"));
            client.DefaultRequestHeaders.Add("User-pokemon", "pokemon api");
            var stringResponse = client.GetStringAsync("https://europe-west1-pokegotchi-alejo.cloudfunctions.net/endFight?text=" + name + "," + password + "," + fighterId + "," + healthPercentage);
            string response = await stringResponse;
            if (response.Equals("win"))
            {
                if (!pokemonsId.Contains(rivalId))
                {
                    pokemonsId.Add(rivalId);
                    pokemonsType.Add(rivalType);
                    pokemonsName.Add(rivalName);
                    comboBoxPokemons.Items.Add(rivalName);
                    pokemonsHealth.Add(100);
                    pokemonsMaxHealth.Add(rivalMaxHealt);
                    pokemonsAttack.Add(rivalAttack);
                    pokemonsLevel.Add(0);
                }
            }
            loading = false;
            HideFightGui();
        }

        public void InitializeGui()
        {
            loading = false;
            pictureMain.Controls.Add(pictureFighter1);
            pictureFighter1.BackColor = Color.Transparent;
            pictureMain.Controls.Add(pictureFighter2);
            pictureFighter2.BackColor = Color.Transparent;
            pictureFighter1.Controls.Add(pictureHit1);
            pictureHit1.Location = new Point(60, 60);
            pictureHit1.BackColor = Color.Transparent;
            pictureFighter2.Controls.Add(pictureHit2);
            pictureHit2.Location = new Point(60, 60);
            pictureHit2.BackColor = Color.Transparent;
            picturePokemon.Controls.Add(pictureHeart);
            pictureHeart.Location = new Point(60, 60);
            pictureHeart.BackColor = Color.Transparent;
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
            pictureFighter1.Hide();
            pictureFighter2.Hide();
            pictureHit1.Hide();
            pictureHit2.Hide();
            pictureHeart.Hide();
            labelHealth1.Hide();
            labelHealth2.Hide();
            buttonAttack.Hide();
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
            labelLevel.Show();
            picturePokemon.Show();
            buttonFeed.Show();
            buttonFight.Show();
            comboBoxPokemons.SelectedIndex = 0;
            labelType.Text = pokemonsType[0];
            labelHP.Text = "HP: " + (int)((pokemonsMaxHealth[0] + 0.1f * pokemonsLevel[0]) * ((float)pokemonsHealth[0] / 100)) +
                "/" + (int)(pokemonsMaxHealth[0] + 0.1f * pokemonsLevel[0]);
            labelAttack.Text = "Att: " + (int)(pokemonsAttack[0] + 0.05f * pokemonsLevel[0]);
            labelLevel.Text = "Exp: " + pokemonsLevel[0];
            Image imagePokemon = Image.FromFile("pokemon1.png");
            picturePokemon.Image = imagePokemon;
        }

        public void HideMainGui()
        {
            comboBoxPokemons.Hide();
            labelType.Hide();
            labelName.Hide();
            labelHP.Hide();
            labelAttack.Hide();
            picturePokemon.Hide();
            pictureFighter1.Show();
            pictureFighter2.Show();
            labelHealth1.Show();
            labelHealth2.Show();
            buttonAttack.Show();
            labelLevel.Hide();
            Image imagePokemon = Image.FromFile("pokemonForest.jpg");
            pictureMain.Image = imagePokemon;
            imagePokemon = Image.FromFile("pokemon"+ pokemonsId[selectedPk] + ".png");
            pictureFighter1.Image = imagePokemon;
            labelHealth1.Text = "HP: " + fighterHealth + "/" + fighterMaxHealth;
            imagePokemon = Image.FromFile("pokemon" + rivalId + ".png");
            pictureFighter2.Image = imagePokemon;
            labelHealth2.Text = "HP: " + rivalHealt + "/" + rivalMaxHealt;
        }

        public void HideFightGui()
        {
            pictureFighter1.Hide();
            pictureFighter2.Hide();
            labelHealth1.Hide();
            labelHealth2.Hide();
            buttonAttack.Hide();
            comboBoxPokemons.Show();
            buttonFight.Show();
            buttonFeed.Show();
            labelType.Show();
            labelLevel.Show();
            labelHP.Show();
            labelHP.Text = "HP: " + (int)((pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]) * ((float)pokemonsHealth[selectedPk] / 100)) +
                "/" + (int)(pokemonsMaxHealth[selectedPk] + 0.1f * pokemonsLevel[selectedPk]);
            labelAttack.Show();
            picturePokemon.Show();
            Image imagePokemon = Image.FromFile("pokemonHose.jpg");
            pictureMain.Image = imagePokemon;
        }
    }
}
