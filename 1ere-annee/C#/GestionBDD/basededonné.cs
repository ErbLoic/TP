using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace GestionBDD
{
    public class basededonné
    {
        private MySqlConnection laConnexion;
        public basededonné(string serv, string bdd, string port, string nomU, string mdp)
        {
            string maChaineConnexion = "";
            {
                maChaineConnexion = "server=" + serv + ";Database=" + bdd +
                ";port=" + port + ";uid=" + nomU + ";pwd=" + mdp;
            }
            laConnexion = new MySqlConnection();
            laConnexion.ConnectionString = maChaineConnexion;
            laConnexion.Open();
            MessageBox.Show("Connexion établie");

        }

        public void ChargerListeClient(ComboBox combo)
        {
            string maRequete = "Select * from client";
            MySqlCommand macommande;
            MySqlDataReader mesresult;
            macommande = new MySqlCommand(maRequete, laConnexion);
            mesresult=macommande.ExecuteReader();
            while (mesresult.Read())
            {
                combo.Items.Add((mesresult.GetInt32("num")+1)+"-"+mesresult.GetString("nom")+" "+mesresult.GetString("prenom"));
            }
            mesresult.Close();
        }

        public void ChargerCommande(ListBox listBox,int ID,Label lbl)
        {
            listBox.Items.Clear();
            string marequete = "Select * from achat join produit p on p.num = achat.numProduit where numClient=@num";
            MySqlDataReader mesresult;
            MySqlCommand commande= new MySqlCommand(marequete, laConnexion);
            commande.Parameters.AddWithValue("@num", ID);
            mesresult=commande.ExecuteReader();
            int prix=0;
            while (mesresult.Read())
            {
                    listBox.Items.Add(mesresult.GetInt32("num") + "-" + mesresult.GetString("nom") + " " + mesresult.GetInt32("prix") + "€. Quantité: " + mesresult.GetInt32("nombre"));
                    prix += mesresult.GetInt32("prix")* mesresult.GetInt32("nombre");  
            }
            mesresult.Close();
            lbl.Text = "Total=" + prix + "€";
        }

        public void Delcommand(int ID, int Produit)
        {
            string marequete = "Delete from achat where numClient=@numclient and numProduit=@produit";
            MySqlCommand commande = new MySqlCommand(marequete, laConnexion);
            commande.Parameters.AddWithValue("@numClient", ID);
            commande.Parameters.AddWithValue("@produit", Produit);
            commande.ExecuteNonQuery();
            

        }

        public void ChargerListeProduit(CheckedListBox lst, int id)
        {
            string marequete = "SELECT * FROM produit WHERE produit.num NOT IN (SELECT achat.numProduit FROM achat WHERE achat.numClient=@client);";
            MySqlDataReader mesresult;
            MySqlCommand commande = new MySqlCommand(marequete, laConnexion);
            commande.Parameters.AddWithValue("@client", id);

            mesresult = commande.ExecuteReader();
            while (mesresult.Read())
            {
                lst.Items.Add(mesresult.GetInt32("num") + "-" + mesresult.GetString("nom") + " " + mesresult.GetInt32("prix") + "€");
            }
            mesresult.Close();
        }

        public void ajouterElement(int client, List<int> produit, int nbr)
        {
            foreach (int id in produit)
            {
                string marequete = "Insert Into achat Values(@numclient , @numproduit , @date , @nbr)";
                MySqlCommand commande = new MySqlCommand(marequete, laConnexion);
                commande.Parameters.AddWithValue("@numclient", client);
                commande.Parameters.AddWithValue("@numproduit", id);

                commande.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                commande.Parameters.AddWithValue("@nbr", nbr);

                commande.ExecuteNonQuery();
            }
        }



        public void Client(int id,Label lb)
        {
            string marequete = "Select * from client where num=@num";
            MySqlCommand commande = new MySqlCommand(marequete, laConnexion);
            commande.Parameters.AddWithValue("@num", id);
            MySqlDataReader mesresult;
            mesresult = commande.ExecuteReader();
            while (mesresult.Read())
            {
                lb.Text=mesresult.GetString("nom") + " " + mesresult.GetString("prenom") ;

            }
            mesresult.Close();
        }

        public void ChargementQuantité(int id, int product, TextBox text)
        {
            string marequete = "Select * from achat where numClient=@id and numProduit=@num";
            MySqlCommand commande = new MySqlCommand(marequete, laConnexion);
            commande.Parameters.AddWithValue("@id", id);
            commande.Parameters.AddWithValue("@num", product);
            MySqlDataReader mesresult;
            mesresult = commande.ExecuteReader();
            while (mesresult.Read())
            {
                text.Text = mesresult.GetInt32("nombre").ToString() ;

            }
            mesresult.Close();
        }

        public void ModifierQuantité(int id, List<int> product,int nbr)
        {
            foreach (int i in product)
            {
                string marequete = "Update achat set date = @date , nombre=@nombre where numClient=@client and numProduit=@produit";
                MySqlCommand commande = new MySqlCommand(marequete, laConnexion);
                commande.Parameters.AddWithValue("@client", id);
                commande.Parameters.AddWithValue("@produit", i);

                commande.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                commande.Parameters.AddWithValue("@nombre", nbr);

                commande.ExecuteNonQuery();
            }
        }

     }
            

}