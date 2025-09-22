using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TP_clientpanier.modele;

namespace TP_clientpanier
{
    public class Basededonne
    {
        private MySqlConnection connexion;

        public Basededonne(string serveur,string bdd, string user,string mdp, string port = "3306")
        {
            string chaine = $"server={serveur};Database={bdd};port={port};uid={user};pwd={mdp}";
            connexion = new MySqlConnection(chaine) ;
        }

        public void Ouvrir() => connexion.Open();
        public void Fermer() => connexion.Close();

        public MySqlConnection Connexion => connexion;

        public List<Client> ChargerClient()
        {
            List<Client> clients = new List<Client>();
            string requete = "Select * from client";
            MySqlCommand commande = new MySqlCommand(requete, connexion);
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32("id");
                string Nom = reader.GetString("nom");
                string Prenom = reader.GetString("prenom");
                string Adresse = reader.GetString("adresse");

                Client c = new Client(ID, Nom, Prenom, Adresse);
                clients.Add(c);
            }
            reader.Close();
            return clients;
        }

        public List<Panier> ChargerPanierClient(int idClient)
        {
            var panier = new List<Panier>();
            string requete = @"Select p.id, p.nom,p.prix,p.description,pa.quantite
                               From panier pa
                               Join Produit p on pa.idProduit = p.id
                               Where pa.idClient = @idClient";
            var commande = new MySqlCommand(requete,connexion);
            commande.Parameters.AddWithValue("@idClient", idClient);
            using var reader = commande.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32("id");
                string Nom = reader.GetString("nom");
                decimal Prix = reader.GetDecimal("prix");
                string Description = reader.GetString("description");
                Produit p = new Produit(ID, Nom, Prix, Description);

                int quantite = reader.GetInt32("quantite");

                Panier pa = new Panier(p, quantite);
                panier.Add(pa);
            }
            reader.Close();
            return panier;
        }

        public List<Produit> ChargerProduit()
        {
            var produit = new List<Produit>();
            string requte = @"Select * from Produit";
            var commande = new MySqlCommand(requte,connexion);
            using var reader = commande.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32("id");
                string nom = reader.GetString("nom");
                decimal prix = reader.GetDecimal("prix");
                string description = reader.GetString("description");
                Produit p = new Produit(ID, nom, prix, description);

                produit.Add(p); 
            }
            reader.Close();
            return produit;
        }

        public bool Add_Panier(int id_P,int id_C,int quantite)
        {
            string requete = @"Insert into Panier Values( @id_P,@id_C,@quantite);";
            var commande= new MySqlCommand(requete,connexion);
            commande.Parameters.AddWithValue("@id_P",id_P );
            commande.Parameters.AddWithValue("@id_C", id_C);
            commande.Parameters.AddWithValue("@quantite", quantite);
            int row= commande.ExecuteNonQuery();
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
