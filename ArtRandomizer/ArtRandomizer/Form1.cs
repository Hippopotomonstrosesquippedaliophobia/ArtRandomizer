using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRandomizer
{
    public partial class Form1 : Form
    {
        const int ARRAY_SIZE = 20;

        public string[] mood =
        {
            "angry",
            "happy",
            "mysterious",
            "sad",
            "moody",
            "smirky",
            "jealous",
            "in love",
            "bubbly",
            "annoyed",
            "nervous",
            "embarrassed",
            "proud",
            "surprised",
            "disgusted",
            "afraid",
            "frustrated",
            "judgey",
            "remorseful",
            "vulnerable"
        };

        public string[] colour =
        {
            "red",
            "blue",
            "green",
            "purple",
            "pink",
            "yellow",
            "black",
            "white",
            "cyan",
            "magenta",
            "gold",
            "silver",
            "brown",
            "orange",
            "violet",
            "navy blue",
            "indigo",
            "aquamarine",
            "light coral",
            "olive"
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Insert blank for both combos
            moodCombo.Items.Add("None");
            colourCombo.Items.Add("None");

            moodCombo.SelectedIndex = 0;
            colourCombo.SelectedIndex = 0;

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                moodCombo.Items.Add(mood[i]);
                colourCombo.Items.Add(colour[i]);
            }
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            int moodRng = rng.Next(20);
            int colourRng = rng.Next(20);

            moodCombo.SelectedIndex = moodRng;
            colourCombo.SelectedIndex = colourRng;
        }

        private void colourCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (colourCombo.Text)
            {
                case "None":
                    colourPalette.BackColor = Color.White;
                    break;
                case "red":
                    colourPalette.BackColor = Color.Red;
                    break;
                case "blue":
                    colourPalette.BackColor = Color.Blue;
                    break;
                case "green":
                    colourPalette.BackColor = Color.Green;
                    break;
                case "purple":
                    colourPalette.BackColor = Color.Purple;
                    break;
                case "pink":
                    colourPalette.BackColor = Color.Pink;
                    break;
                case "yellow":
                    colourPalette.BackColor = Color.Yellow;
                    break;
                case "black":
                    colourPalette.BackColor = Color.Black;
                    break;
                case "white":
                    colourPalette.BackColor = Color.White;
                    break;
                case "cyan":
                    colourPalette.BackColor = Color.Cyan;
                    break;
                case "magenta":
                    colourPalette.BackColor = Color.Magenta;
                    break;
                case "gold":
                    colourPalette.BackColor = Color.Gold;
                    break;
                case "silver":
                    colourPalette.BackColor = Color.Silver;
                    break;
                case "brown":
                    colourPalette.BackColor = Color.Brown;
                    break;
                case "orange":
                    colourPalette.BackColor = Color.Orange;
                    break;
                case "violet":
                    colourPalette.BackColor = Color.Violet;
                    break;
                case "navy blue":
                    colourPalette.BackColor = Color.Navy;
                    break;
                case "indigo":
                    colourPalette.BackColor = Color.Indigo;
                    break;
                case "aquamarine":
                    colourPalette.BackColor = Color.Aquamarine;
                    break;
                case "light coral":
                    colourPalette.BackColor = Color.LightCoral;
                    break;
                case "olive":
                    colourPalette.BackColor = Color.Olive;
                    break;
            }
        }
    }
}
