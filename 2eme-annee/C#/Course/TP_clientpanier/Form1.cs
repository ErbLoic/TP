using TP_clientpanier.modele;
namespace TP_clientpanier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Basededonne bdd;

        private void Form1_Load(object sender, EventArgs e)
        {
            bdd = new Basededonne("localhost", "pcshop", "root", "");
            bdd.Ouvrir();
            List<Client> clients = bdd.ChargerClient();
            cbClients.DataSource = clients;
            //parametrage de la listView
            lvPanier.View = View.Details;
            lvPanier.FullRowSelect = true;
            lvPanier.GridLines = true;
            lvPanier.Columns.Clear();
            lvPanier.Columns.Add("Produit", 150);
            lvPanier.Columns.Add("Prix Unitaire (€)", 100);
            lvPanier.Columns.Add("Quantité", 80);
            lvPanier.Columns.Add("Total Ligne (€)", 100);
        }

        private void chargerpanierclient_Click(object sender, EventArgs e)
        {
            if (cbClients.SelectedItem is Client client)
            {
                lvPanier.Items.Clear();
                var paniers = bdd.ChargerPanierClient(client.ID);
                decimal prixT = 0;
                foreach (var panier in paniers)
                {
                    var item = new ListViewItem(panier.Produit.Nom);
                    item.SubItems.Add(panier.Produit.Prix.ToString("C2"));
                    item.SubItems.Add(panier.Quantite.ToString());
                    item.SubItems.Add((panier.Quantite *
                    panier.Produit.Prix).ToString("C2"));
                    prixT += (panier.Quantite *
                    panier.Produit.Prix);
                    lvPanier.Items.Add(item);

                }
                prixto.Text = "Prix Total=" + prixT.ToString() + "€";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = cbClients.SelectedItem.ToString(); 
            int split = Convert.ToInt32(selected.Split('-')[0].Trim());


            Form2 f = new Form2(split);
            f.Show();
        }
    }
}
