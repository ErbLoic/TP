using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPokeAPI.Modele;

namespace FormPokeAPI
{
    public partial class equipe : Form
    {
        Equipe e;
        Form1 f;

        public equipe(Equipe e,Form1 f)
        {
            this.f=f;
            this.e = e;
            InitializeComponent();
        }



        private void equipe_Load(object sender, EventArgs e)
        {
            int image = 1;  // Pour les pictureBox
            int labelIndex = 1;  // Pour les labels

            foreach (Pokemon p in this.e.Pokemons)
            {
                // --- IMAGE ---
                PictureBox pb = this.Controls.Find($"pictureBox{image}", true).FirstOrDefault() as PictureBox;
                if (pb != null && !string.IsNullOrEmpty(p.sprite))
                {
                    pb.Load(p.sprite);
                }

                // --- LABEL TYPE2 ---
                Label lblType2 = this.Controls.Find($"label{labelIndex}", true).FirstOrDefault() as Label;
                if (lblType2 != null)
                {
                    lblType2.Text = !string.IsNullOrEmpty(p.type2) ? "Type2: " + p.type2 : "";
                    lblType2.Visible = true;
                }

                labelIndex++;

                // --- LABEL TYPE1 ---
                Label lblType1 = this.Controls.Find($"label{labelIndex}", true).FirstOrDefault() as Label;
                if (lblType1 != null)
                {
                    lblType1.Text = "Type1: " + p.type1;
                    lblType1.Visible = true;
                }

                labelIndex++;

                // --- LABEL NOM ---
                Label lblNom = this.Controls.Find($"label{labelIndex}", true).FirstOrDefault() as Label;
                if (lblNom != null)
                {
                    lblNom.Text = p.name.ToUpper();
                    lblNom.Visible = true;
                }
                labelIndex++;

                // --- INCRÉMENT POUR LE SUIVANT ---
                image++;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }

    }

}
