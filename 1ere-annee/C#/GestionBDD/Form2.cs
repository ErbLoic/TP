using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBDD
{
    public partial class Form2 : Form
    {

        basededonné bdd;
        int client;
        int commande;
        Form1 form;
        public Form2(basededonné bdd, int client, int commande, Form1 form)
        {
            this.bdd = bdd;
            this.client = client;
            this.commande = commande;

            this.form = form;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bdd.Client(client, label4);

            if (this.commande == 0)
            {
                bdd.ChargerListeProduit(checkedListBox1, client);
            }
            else if (this.commande == 1)
            {
                bdd.ChargerCommande(checkedListBox1, this.client, label5);
            }

        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            string produit;
            string[] produitsplit;
            List<int> idProduit = new List<int>();
            int nbr = Convert.ToInt32(textBox1.Text);
            foreach (string item in checkedListBox1.CheckedItems)
            {
                produit = item.ToString();
                produitsplit = produit.Split('-');

                idProduit.Add(Convert.ToInt32(produitsplit[0]));
            }


            if (this.commande == 0)
            {
                bdd.ajouterElement(this.client, idProduit, nbr);

            }
            else if (this.commande == 1)
            {
                bdd.ModifierQuantité(this.client, idProduit, nbr);
            }
            this.Close();
        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
            string produit = checkedListBox1.SelectedItem.ToString();
            string[] produitsplit = produit.Split("-");
            int idProduit = Convert.ToInt32(produitsplit[0]);
            if (this.commande == 1)
            {
                bdd.ChargementQuantité(this.client, idProduit, textBox1);
            }
        }
    }
}
