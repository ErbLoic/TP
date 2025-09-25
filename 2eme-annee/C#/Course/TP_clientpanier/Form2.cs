using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_clientpanier.modele;

namespace TP_clientpanier
{
    public partial class Form2 : Form
    {
        private Basededonne bdd;
        public int id { get; set; }
        public Form2(int Id)
        {
            this.id = Id;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bdd = new Basededonne("localhost", "pcshop", "root", "");
            bdd.Ouvrir();
            List<Produit> produit = bdd.ChargerProduit();
            cbProduit.DataSource = produit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = cbProduit.SelectedItem.ToString();
            int split = Convert.ToInt32(selected.Split('-')[0].Trim());

            string a =bdd.Add_Panier(split, this.id, Convert.ToInt32(textBox1.Text));
            if (a=="c bon")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(a);
            }
        }
    }
}
