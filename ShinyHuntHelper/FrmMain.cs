using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShinyHuntHelper
{
    public partial class FrmMain : Form
    {
        KeyboardHook hook = new KeyboardHook();
        private Keys TempAddKey = new Keys();
        private Keys TempSubKey = new Keys();
        private string imagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private int RadioValue = 5;

        private string FileNamePokemonList = "PokemonList.csv";

        private string FileNameNumRESR = "NumRESR.txt";

        private string FileNameTargetName = "TargetName.txt";
        private string FileNameTargetNum = "TargetNum.txt";

        private string FileNameLocal = "Local.txt";
        private string FileNameGameVersion = "GameVersion.txt";

        private double Probability = Math.Pow(8192, -1);

        private string FileNameLastShinyName = "LastShinyName.txt";
        private string FileNameLastShinyNum = "LastShinyNum.txt";
        private string FileNameLastShinyRE = "LastShinyRE.txt";
        #region Pokemon List
        Object[] Pokemons = new object[] {
            "Pokémon",
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "Nidoran?",
            "Nidorina",
            "Nidoqueen",
            "Nidoran?",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetch\'d",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "Mr. Mime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew",
            "Chikorita",
            "Bayleef",
            "Meganium",
            "Cyndaquil",
            "Quilava",
            "Typhlosion",
            "Totodile",
            "Croconaw",
            "Feraligatr",
            "Sentret",
            "Furret",
            "Hoothoot",
            "Noctowl",
            "Ledyba",
            "Ledian",
            "Spinarak",
            "Ariados",
            "Crobat",
            "Chinchou",
            "Lanturn",
            "Pichu",
            "Cleffa",
            "Igglybuff",
            "Togepi",
            "Togetic",
            "Natu",
            "Xatu",
            "Mareep",
            "Flaaffy",
            "Ampharos",
            "Bellossom",
            "Marill",
            "Azumarill",
            "Sudowoodo",
            "Politoed",
            "Hoppip",
            "Skiploom",
            "Jumpluff",
            "Aipom",
            "Sunkern",
            "Sunflora",
            "Yanma",
            "Wooper",
            "Quagsire",
            "Espeon",
            "Umbreon",
            "Murkrow",
            "Slowking",
            "Misdreavus",
            "Unown",
            "Wobbuffet",
            "Girafarig",
            "Pineco",
            "Forretress",
            "Dunsparce",
            "Gligar",
            "Steelix",
            "Snubbull",
            "Granbull",
            "Qwilfish",
            "Scizor",
            "Shuckle",
            "Heracross",
            "Sneasel",
            "Teddiursa",
            "Ursaring",
            "Slugma",
            "Magcargo",
            "Swinub",
            "Piloswine",
            "Corsola",
            "Remoraid",
            "Octillery",
            "Delibird",
            "Mantine",
            "Skarmory",
            "Houndour",
            "Houndoom",
            "Kingdra",
            "Phanpy",
            "Donphan",
            "Porygon2",
            "Stantler",
            "Smeargle",
            "Tyrogue",
            "Hitmontop",
            "Smoochum",
            "Elekid",
            "Magby",
            "Miltank",
            "Blissey",
            "Raikou",
            "Entei",
            "Suicune",
            "Larvitar",
            "Pupitar",
            "Tyranitar",
            "Lugia",
            "Ho-Oh",
            "Celebi",
            "Treecko",
            "Grovyle",
            "Sceptile",
            "Torchic",
            "Combusken",
            "Blaziken",
            "Mudkip",
            "Marshtomp",
            "Swampert",
            "Poochyena",
            "Mightyena",
            "Zigzagoon",
            "Linoone",
            "Wurmple",
            "Silcoon",
            "Beautifly",
            "Cascoon",
            "Dustox",
            "Lotad",
            "Lombre",
            "Ludicolo",
            "Seedot",
            "Nuzleaf",
            "Shiftry",
            "Taillow",
            "Swellow",
            "Wingull",
            "Pelipper",
            "Ralts",
            "Kirlia",
            "Gardevoir",
            "Surskit",
            "Masquerain",
            "Shroomish",
            "Breloom",
            "Slakoth",
            "Vigoroth",
            "Slaking",
            "Nincada",
            "Ninjask",
            "Shedinja",
            "Whismur",
            "Loudred",
            "Exploud",
            "Makuhita",
            "Hariyama",
            "Azurill",
            "Nosepass",
            "Skitty",
            "Delcatty",
            "Sableye",
            "Mawile",
            "Aron",
            "Lairon",
            "Aggron",
            "Meditite",
            "Medicham",
            "Electrike",
            "Manectric",
            "Plusle",
            "Minun",
            "Volbeat",
            "Illumise",
            "Roselia",
            "Gulpin",
            "Swalot",
            "Carvanha",
            "Sharpedo",
            "Wailmer",
            "Wailord",
            "Numel",
            "Camerupt",
            "Torkoal",
            "Spoink",
            "Grumpig",
            "Spinda",
            "Trapinch",
            "Vibrava",
            "Flygon",
            "Cacnea",
            "Cacturne",
            "Swablu",
            "Altaria",
            "Zangoose",
            "Seviper",
            "Lunatone",
            "Solrock",
            "Barboach",
            "Whiscash",
            "Corphish",
            "Crawdaunt",
            "Baltoy",
            "Claydol",
            "Lileep",
            "Cradily",
            "Anorith",
            "Armaldo",
            "Feebas",
            "Milotic",
            "Castform",
            "Kecleon",
            "Shuppet",
            "Banette",
            "Duskull",
            "Dusclops",
            "Tropius",
            "Chimecho",
            "Absol",
            "Wynaut",
            "Snorunt",
            "Glalie",
            "Spheal",
            "Sealeo",
            "Walrein",
            "Clamperl",
            "Huntail",
            "Gorebyss",
            "Relicanth",
            "Luvdisc",
            "Bagon",
            "Shelgon",
            "Salamence",
            "Beldum",
            "Metang",
            "Metagross",
            "Regirock",
            "Regice",
            "Registeel",
            "Latias",
            "Latios",
            "Kyogre",
            "Groudon",
            "Rayquaza",
            "Jirachi",
            "Deoxys",
            "Turtwig",
            "Grotle",
            "Torterra",
            "Chimchar",
            "Monferno",
            "Infernape",
            "Piplup",
            "Prinplup",
            "Empoleon",
            "Starly",
            "Staravia",
            "Staraptor",
            "Bidoof",
            "Bibarel",
            "Kricketot",
            "Kricketune",
            "Shinx",
            "Luxio",
            "Luxray",
            "Budew",
            "Roserade",
            "Cranidos",
            "Rampardos",
            "Shieldon",
            "Bastiodon",
            "Burmy",
            "Wormadam",
            "Mothim",
            "Combee",
            "Vespiquen",
            "Pachirisu",
            "Buizel",
            "Floatzel",
            "Cherubi",
            "Cherrim",
            "Shellos",
            "Gastrodon",
            "Ambipom",
            "Drifloon",
            "Drifblim",
            "Buneary",
            "Lopunny",
            "Mismagius",
            "Honchkrow",
            "Glameow",
            "Purugly",
            "Chingling",
            "Stunky",
            "Skuntank",
            "Bronzor",
            "Bronzong",
            "Bonsly",
            "Mime Jr.",
            "Happiny",
            "Chatot",
            "Spiritomb",
            "Gible",
            "Gabite",
            "Garchomp",
            "Munchlax",
            "Riolu",
            "Lucario",
            "Hippopotas",
            "Hippowdon",
            "Skorupi",
            "Drapion",
            "Croagunk",
            "Toxicroak",
            "Carnivine",
            "Finneon",
            "Lumineon",
            "Mantyke",
            "Snover",
            "Abomasnow",
            "Weavile",
            "Magnezone",
            "Lickilicky",
            "Rhyperior",
            "Tangrowth",
            "Electivire",
            "Magmortar",
            "Togekiss",
            "Yanmega",
            "Leafeon",
            "Glaceon",
            "Gliscor",
            "Mamoswine",
            "Porygon-Z",
            "Gallade",
            "Probopass",
            "Dusknoir",
            "Froslass",
            "Rotom",
            "Uxie",
            "Mesprit",
            "Azelf",
            "Dialga",
            "Palkia",
            "Heatran",
            "Regigigas",
            "Giratina",
            "Cresselia",
            "Phione",
            "Manaphy",
            "Darkrai",
            "Shaymin",
            "Arceus",
            "Victini",
            "Snivy",
            "Servine",
            "Serperior",
            "Tepig",
            "Pignite",
            "Emboar",
            "Oshawott",
            "Dewott",
            "Samurott",
            "Patrat",
            "Watchog",
            "Lillipup",
            "Herdier",
            "Stoutland",
            "Purrloin",
            "Liepard",
            "Pansage",
            "Simisage",
            "Pansear",
            "Simisear",
            "Panpour",
            "Simipour",
            "Munna",
            "Musharna",
            "Pidove",
            "Tranquill",
            "Unfezant",
            "Blitzle",
            "Zebstrika",
            "Roggenrola",
            "Boldore",
            "Gigalith",
            "Woobat",
            "Swoobat",
            "Drilbur",
            "Excadrill",
            "Audino",
            "Timburr",
            "Gurdurr",
            "Conkeldurr",
            "Tympole",
            "Palpitoad",
            "Seismitoad",
            "Throh",
            "Sawk",
            "Sewaddle",
            "Swadloon",
            "Leavanny",
            "Venipede",
            "Whirlipede",
            "Scolipede",
            "Cottonee",
            "Whimsicott",
            "Petilil",
            "Lilligant",
            "Basculin",
            "Sandile",
            "Krokorok",
            "Krookodile",
            "Darumaka",
            "Darmanitan",
            "Maractus",
            "Dwebble",
            "Crustle",
            "Scraggy",
            "Scrafty",
            "Sigilyph",
            "Yamask",
            "Cofagrigus",
            "Tirtouga",
            "Carracosta",
            "Archen",
            "Archeops",
            "Trubbish",
            "Garbodor",
            "Zorua",
            "Zoroark",
            "Minccino",
            "Cinccino",
            "Gothita",
            "Gothorita",
            "Gothitelle",
            "Solosis",
            "Duosion",
            "Reuniclus",
            "Ducklett",
            "Swanna",
            "Vanillite",
            "Vanillish",
            "Vanilluxe",
            "Deerling",
            "Sawsbuck",
            "Emolga",
            "Karrablast",
            "Escavalier",
            "Foongus",
            "Amoonguss",
            "Frillish",
            "Jellicent",
            "Alomomola",
            "Joltik",
            "Galvantula",
            "Ferroseed",
            "Ferrothorn",
            "Klink",
            "Klang",
            "Klinklang",
            "Tynamo",
            "Eelektrik",
            "Eelektross",
            "Elgyem",
            "Beheeyem",
            "Litwick",
            "Lampent",
            "Chandelure",
            "Axew",
            "Fraxure",
            "Haxorus",
            "Cubchoo",
            "Beartic",
            "Cryogonal",
            "Shelmet",
            "Accelgor",
            "Stunfisk",
            "Mienfoo",
            "Mienshao",
            "Druddigon",
            "Golett",
            "Golurk",
            "Pawniard",
            "Bisharp",
            "Bouffalant",
            "Rufflet",
            "Braviary",
            "Vullaby",
            "Mandibuzz",
            "Heatmor",
            "Durant",
            "Deino",
            "Zweilous",
            "Hydreigon",
            "Larvesta",
            "Volcarona",
            "Cobalion",
            "Terrakion",
            "Virizion",
            "Tornadus",
            "Thundurus",
            "Reshiram",
            "Zekrom",
            "Landorus",
            "Kyurem",
            "Keldeo",
            "Meloetta",
            "Genesect",
            "Chespin",
            "Quilladin",
            "Chesnaught",
            "Fennekin",
            "Braixen",
            "Delphox",
            "Froakie",
            "Frogadier",
            "Greninja",
            "Bunnelby",
            "Diggersby",
            "Fletchling",
            "Fletchinder",
            "Talonflame",
            "Scatterbug",
            "Spewpa",
            "Vivillon",
            "Litleo",
            "Pyroar",
            "Flabébé",
            "Floette",
            "Florges",
            "Skiddo",
            "Gogoat",
            "Pancham",
            "Pangoro",
            "Furfrou",
            "Espurr",
            "Meowstic",
            "Honedge",
            "Doublade",
            "Aegislash",
            "Spritzee",
            "Aromatisse",
            "Swirlix",
            "Slurpuff",
            "Inkay",
            "Malamar",
            "Binacle",
            "Barbaracle",
            "Skrelp",
            "Dragalge",
            "Clauncher",
            "Clawitzer",
            "Helioptile",
            "Heliolisk",
            "Tyrunt",
            "Tyrantrum",
            "Amaura",
            "Aurorus",
            "Sylveon",
            "Hawlucha",
            "Dedenne",
            "Carbink",
            "Goomy",
            "Sliggoo",
            "Goodra",
            "Klefki",
            "Phantump",
            "Trevenant",
            "Pumpkaboo",
            "Gourgeist",
            "Bergmite",
            "Avalugg",
            "Noibat",
            "Noivern",
            "Xerneas",
            "Yveltal",
            "Zygarde",
                "Diancie" };
        #endregion

        //private string FileName = "Template.txt";

        private string SavePath = ShinyHuntHelper.Properties.Settings.Default.SavePath;

        public FrmMain()
        {
            
            InitializeComponent();
            this.cbxTarget.Items.AddRange(Pokemons);
            this.cbxMissTarget.Items.AddRange(Pokemons);
            
            if (txtSavePath.Text == "")
            {
                // txtSavePath.Text = ShinyHuntHelper.Properties.Settings.Default.SavePath;

                if (SavePath != "")
                {
                    string encontros = "";
                    txtSavePath.Text = SavePath;

                    StreamReader arquivo = new StreamReader(SavePath + "\\" + FileNameNumRESR);
                    encontros = arquivo.ReadLine();
                    arquivo.Close();
                    txtEncontros.Text = encontros;
 #region Iniciar arquivos
            if (File.Exists(SavePath + "\\" + FileNamePokemonList))
            {
                StreamReader file = new StreamReader(SavePath + "\\" + FileNamePokemonList);
                file.Close();

            }
            else
            {
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNamePokemonList);
                newFile.Close();
            }
            if (File.Exists(SavePath + "\\" + FileNameLocal))
            {
                string aux = "";
                StreamReader file = new StreamReader(SavePath + "\\" + FileNameLocal);
                aux = file.ReadLine();
                file.Close();
                txtLocal.Text = aux;
            }
            else
            {
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameLocal);
                newFile.Close();
            }
            if (File.Exists(SavePath + "\\" + FileNameGameVersion))
            {
                string aux = "";
                StreamReader file = new StreamReader(SavePath + "\\" + FileNameGameVersion);
                aux = file.ReadLine();
                file.Close();
                txtGameVersion.Text = aux;
            }
            else
            {
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameGameVersion);
                newFile.Close();
            }
            if (File.Exists(SavePath + "\\"+ FileNameTargetNum))
            {
                string aux = "";
                StreamReader file = new StreamReader(SavePath + "\\" + FileNameTargetNum);
                aux = file.ReadLine();
                file.Close();
                cbxTarget.SelectedIndex = int.Parse(aux);
            }
            else
            {
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameTargetNum);
                newFile.Close();
            }
            #endregion

                }
            }

           

            if (txtAddKey.Text == "" && ShinyHuntHelper.Properties.Settings.Default.AddKey > 0)
                hook.RegisterHotKey(ShinyHuntHelper.Properties.Settings.Default.AddKey);
            if (txtSubKey.Text == "" && ShinyHuntHelper.Properties.Settings.Default.SubKey > 0)
                hook.RegisterHotKey(ShinyHuntHelper.Properties.Settings.Default.SubKey);

            if (txtEncontros.Text == "")
            {
                txtEncontros.Text = "0";
            }
            if (txtPhase.Text == "")
            {
                txtPhase.Text = "1";
            } 

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);

        }
        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
           
            if ((uint)e.Key == ShinyHuntHelper.Properties.Settings.Default.AddKey)
            {
                int result = int.Parse(txtEncontros.Text) + 1;
                int session = int.Parse(txtSessionRE.Text) + 1;
                txtEncontros.Text = result.ToString();
                txtSessionRE.Text = session.ToString();
            }
            if ((uint)e.Key == ShinyHuntHelper.Properties.Settings.Default.SubKey)
            {
                int result = int.Parse(txtEncontros.Text) - 1;
                int session = int.Parse(txtSessionRE.Text) - 1;
                txtEncontros.Text = result.ToString();
                txtSessionRE.Text = session.ToString();
            }
        }
        private void btnSavePathSearch_Click(object sender, EventArgs e)
        {
            if (fbdSavePath.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = fbdSavePath.SelectedPath;
            }
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {
            SavePath = txtSavePath.Text;
            ShinyHuntHelper.Properties.Settings.Default.SavePath = txtSavePath.Text;
            ShinyHuntHelper.Properties.Settings.Default.Save();
        }

        private void txtKeyIncrease_KeyDown(object sender, KeyEventArgs e)
        {
            TempAddKey = e.KeyData;
            txtAddKey.Text = e.KeyCode.ToString();
        }

        private void txtSubKey_KeyDown(object sender, KeyEventArgs e)
        {
            TempSubKey = e.KeyData;
            txtSubKey.Text = e.KeyCode.ToString();
        }

        private void btnSaveHotkeys_Click(object sender, EventArgs e)
        {
            hook.ResetHotKeys();
            if (txtAddKey.Text != "")
            {
                ShinyHuntHelper.Properties.Settings.Default.AddKey = (uint)TempAddKey;
                ShinyHuntHelper.Properties.Settings.Default.Save();
                hook.RegisterHotKey(ShinyHuntHelper.Properties.Settings.Default.AddKey);

            }
            if (txtSubKey.Text != "")
            {
                ShinyHuntHelper.Properties.Settings.Default.SubKey = (uint)TempSubKey;
                ShinyHuntHelper.Properties.Settings.Default.Save();
                hook.RegisterHotKey(ShinyHuntHelper.Properties.Settings.Default.SubKey);
            }

        }

        private void cbxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTarget.SelectedIndex > 0)
            {
                if (SavePath != "")
                {
                    StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameTargetName);
                    newFile.Write(cbxTarget.SelectedItem);
                    newFile.Close();

                    newFile = new StreamWriter(SavePath + "\\" + FileNameTargetNum);
                    newFile.Write(cbxTarget.SelectedIndex);
                    newFile.Close();
                }
                switch (RadioValue)
                {
                    case 2:
                    case 3:
                        pcbTarget.ImageLocation = imagePath + "\\Imgs\\gen" + RadioValue + "\\" + cbxTarget.SelectedIndex + ".gif"; break;
                    case 4:
                        pcbTarget.ImageLocation = imagePath + "\\Imgs\\gen" + RadioValue + "\\" + cbxTarget.SelectedIndex + ".png"; break;
                    case 5:
                        pcbTarget.ImageLocation = imagePath + "\\Imgs\\gen" + RadioValue + "\\" + String.Format("{0:000}",cbxTarget.SelectedIndex) + ".gif"; break;
                }
                    
            }
            
        }

        #region RadioButtons
        private void rdbGen2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGen2.Checked)
                RadioValue = 2;
            cbxTarget_SelectedIndexChanged(this, new EventArgs());
        }

        private void rdbGen3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGen3.Checked)
                RadioValue = 3;
            cbxTarget_SelectedIndexChanged(this, new EventArgs());
        }

        private void rdbGen4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGen4.Checked)
                RadioValue = 4;
            cbxTarget_SelectedIndexChanged(this, new EventArgs());
        }

        private void rdbGen5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGen5.Checked)
                RadioValue = 5;
            cbxTarget_SelectedIndexChanged(this, new EventArgs());
        } 
        #endregion

        private void txtEncontros_TextChanged(object sender, EventArgs e)
        {
            if (txtSavePath.Text != "")
            {
                SavePath = txtSavePath.Text;
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameNumRESR);
                newFile.Write(txtEncontros.Text);
                newFile.Close();
            }
            int num = int.Parse(txtEncontros.Text);
            double aux = (1 - Math.Pow((1 - Probability), num)) * 100;
            txtUnluck.Text = aux.ToString();
        }

        private void txtSavePath_Click(object sender, EventArgs e)
        {
            btnSavePathSearch_Click(sender,e);
        }

        private void txtGameVersion_TextChanged(object sender, EventArgs e)
        {
            if (txtSavePath.Text != "")
            {
                SavePath = txtSavePath.Text;
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameGameVersion);
                newFile.Write(txtGameVersion.Text);
                newFile.Close();

            }
        }

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {
            if (txtSavePath.Text != "")
            {
                SavePath = txtSavePath.Text;
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameLocal);
                newFile.Write(txtLocal.Text);
                newFile.Close();

            }
        }

        private void btnShinyGet_Click(object sender, EventArgs e)
        {
            string header = "Number" + "\t" +
                "Name" + "\t" +
                "Sprite" + "\t" +
                "Local" + "\t" +
                "Game Version" + "\t" +
                "RE / SR" + "\t" +
                "Phase" + "\t" +
                "Date";
            string mensagem = cbxTarget.SelectedIndex + "\t" +
                cbxTarget.SelectedItem + "\t" + "\t" +
                txtLocal.Text + "\t" +
                txtGameVersion.Text + "\t" +
                txtEncontros.Text + "\t" +
                txtPhase.Text + "\t" +
                DateTime.Now;
            Clipboard.SetText(mensagem);
            MessageBox.Show("Text sent to Clipboard:\r\n\r\n" +
                 header + "\r\n" +
                mensagem, "Congratz on the new Shiny");
            SaveLastShiny();

            txtEncontros.Text = "0";

            if (int.Parse(txtPhase.Text) > 1)
            {
                txtPhase.Text = "1";
            }
        }

        private void btnNotMyShiny_Click(object sender, EventArgs e)
        {
            string header = "Number" + "\t" +
                "Name" + "\t" +
                "Sprite" + "\t" +
                "Local" + "\t" +
                "Game Version" + "\t" +
                "RE / SR" + "\t" +
                "Phase" + "\t" +
                "Date";
            string mensagem = cbxMissTarget.SelectedIndex + "\t" +
                cbxMissTarget.SelectedItem + "\t" + "\t" +
                txtLocal.Text + "\t" +
                txtGameVersion.Text + "\t" +
                txtEncontros.Text + "\t" +
                txtPhase.Text + "\t" +
                DateTime.Now;
            Clipboard.SetText(mensagem);
            MessageBox.Show("Text sent to Clipboard:\r\n\r\n" +
                 header + "\r\n" +
                mensagem);

            SaveLastShiny(true);
            int result = int.Parse(txtPhase.Text) + 1;
            txtPhase.Text = result.ToString();

        }

        private void SaveLastShiny(bool notTarget = false)
        {
            if (SavePath != "")
            {
                StreamWriter newFile = new StreamWriter(SavePath + "\\" + FileNameLastShinyName);
                if (notTarget)
                {
                    newFile.Write(cbxMissTarget.SelectedItem);
                }
                else
                {
                    newFile.Write(cbxTarget.SelectedItem);
                }
                newFile.Close();

                newFile = new StreamWriter(SavePath + "\\" + FileNameLastShinyNum);
                if (notTarget)
                {
                    newFile.Write(cbxMissTarget.SelectedIndex);
                }
                else
                {
                    newFile.Write(cbxTarget.SelectedIndex);
                }

                newFile.Close();

                newFile = new StreamWriter(SavePath + "\\" + FileNameLastShinyRE);
                newFile.Write(txtEncontros.Text);
                newFile.Close(); 
            }
        }

        private void btnPopUp_Click(object sender, EventArgs e)
        {
            if (File.Exists(pcbTarget.ImageLocation))
            {
                frmPopup novo = new frmPopup(pcbTarget.ImageLocation);
                novo.Show();
            }
            else
            {
                MessageBox.Show("Please Select a pokémon first!");
            }
        }

        private void btnNewRE_Click(object sender, EventArgs e)
        {
            txtEncontros.Text = txtNewRE.Text;
        }

        private void txtNewRE_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void llbTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/LuizHMS22");
        }

        private void llbTwich_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/luizhms");
        }

        private void llbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LuizHMS");
        }
    }
}
