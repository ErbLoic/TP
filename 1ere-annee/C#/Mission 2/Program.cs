using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace Mission_2
{

    public class Program
    {

        static void simulation() {
            string connectionString = "Server=localhost;database=ap2-mission2;UserID=root;Password= ";

            MySqlConnection conexion= new MySqlConnection(connectionString);

            List<Centre> centres = new List<Centre>();
            try
            {
                conexion.Open();
                Console.WriteLine("Choisissez votre centre");
                string requete = "Select * from centres";
                MySqlCommand command = new MySqlCommand(requete, conexion);

                MySqlDataReader lecteur = command.ExecuteReader();
                int c = 0;
                while (lecteur.Read())
                {
                    Centre a = new Centre(Convert.ToInt32(lecteur["IDcentre"]), Convert.ToString(lecteur["nom"]), Convert.ToInt32(lecteur["IDcommune"]), Convert.ToInt32(lecteur["Remise2"]));
                    centres.Add(a);
                    Console.WriteLine(lecteur["IDcentre"] + "-" + lecteur["nom"]);
                    if (!DBNull.Value.Equals(lecteur["Remise3"]))
                    {
                        centres[c].Remise3 = Convert.ToInt32(lecteur["Remise3"]);
                    }
                    c++;
                }
                lecteur.Close();


                int reponse = Convert.ToInt32(Console.ReadLine());
                reponse--;
                requete = "Select S.ID,S.Nom from centres C join centre_spe CS on CS.IDcentre=C.IDcentre join spe S on S.ID=CS.IDspe where C.IDcentre=@id";
                MySqlCommand selectspe = new MySqlCommand(requete, conexion);
                selectspe.Parameters.AddWithValue("@ID", centres[reponse].ID);
                MySqlDataReader lecteurspe = selectspe.ExecuteReader();
                Console.WriteLine("\n");
                while (lecteurspe.Read())
                {
                    spe b = new spe(Convert.ToString(lecteurspe["Nom"]), Convert.ToInt32(lecteurspe["ID"]));
                    centres[reponse].spe.Add(b);
                }
                lecteurspe.Close();


                c = 1;
                foreach (spe spe in centres[reponse].spe)
                {
                    Console.WriteLine(c + "- " + spe.ToString());
                    c++;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Vous voulez combien de spé");
                int rep = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                List<int> option = new List<int>();

                for (int i = 0; i < rep; i++)
                {
                    Console.WriteLine("Donnez le numéro");
                    option.Add(Convert.ToInt32( Console.ReadLine()));
                }


                Console.WriteLine("\n");
                MySqlCommand selecttarif;



                if (option.Count() == 1)
                {
                    string requetetarif = " SELECT * FROM centres" +
                            " C JOIN payement p ON p.IDcentre = C.IDcentre" +
                            " JOIN tarif t ON t.ID = p.IDPrix " +
                            "JOIN centre_spe CS ON CS.IDcentre = C.IDcentre " +
                            "JOIN spe S ON S.ID = CS.IDspe " +
                            "WHERE C.IDcentre =@ID   and t.NomSpé =@nomspe  and S.Nom =@Nom ";

                    selecttarif = new MySqlCommand(requetetarif, conexion);

                    selecttarif.Parameters.AddWithValue("@ID", centres[reponse].ID);
                    selecttarif.Parameters.AddWithValue("@nomspe", centres[reponse].spe[option[0]-1].Nom);
                    selecttarif.Parameters.AddWithValue("@Nom", centres[reponse].spe[option[0]-1].Nom);

                    MySqlDataReader lecteurtarif = selecttarif.ExecuteReader();

                    lecteurtarif.Read();


                    Tarif d = new Tarif(Convert.ToString(lecteurtarif["NomSpé"]), Convert.ToInt32(lecteurtarif["Prix"]));
                    centres[reponse].tarif.Add(d);
                    lecteurtarif.Close();
                }
                else
                {
                    foreach(int y in option)
                    {
                        string requetetarif =" SELECT * FROM centres" +
                            " C JOIN payement p ON p.IDcentre = C.IDcentre" +
                            " JOIN tarif t ON t.ID = p.IDPrix " +
                            "JOIN centre_spe CS ON CS.IDcentre = C.IDcentre " +
                            "JOIN spe S ON S.ID = CS.IDspe " +
                            "WHERE C.IDcentre =@ID   and t.NomSpé =@nomspe  and S.Nom =@Nom ";

                        selecttarif = new MySqlCommand(requetetarif, conexion);

                        selecttarif.Parameters.AddWithValue("@ID", centres[reponse].ID);
                        selecttarif.Parameters.AddWithValue("@nomspe", centres[reponse].spe[y-1].Nom);
                        selecttarif.Parameters.AddWithValue("@Nom", centres[reponse].spe[y-1].Nom);

                        MySqlDataReader lecteurtarif = selecttarif.ExecuteReader();
                        while (lecteurtarif.Read())
                        {
                            Tarif d = new Tarif(Convert.ToString(lecteurtarif["NomSpé"]), Convert.ToInt32(lecteurtarif["Prix"]));
                            centres[reponse].tarif.Add(d);
                        }
                        lecteurtarif.Close();
                    }
                }

                int somme = 0;
                foreach (var tarif in centres[reponse].tarif)
                {
                    somme += tarif.prix;
                }

                Console.WriteLine("Total à payer sans remise :"+somme);

                if (option.Count() == 2)
                {
                    int sommeR = somme - (somme * centres[reponse].Remise2 / 100);
                    Console.WriteLine("Total à payer avec remise :" + sommeR);
                }
                else if (option.Count() == 3)
                {
                    int sommeR = somme - (somme * centres[reponse].Remise3 / 100);
                    Console.WriteLine("Total à payer avec remise :" + sommeR);
                }
                else
                {
                    Console.WriteLine("Pas de remise");
                }

                Console.WriteLine("Voulez-vous faire une autre simulation(O/N)");
                string relance = "N";
                relance = Console.ReadLine();
                if(relance.ToUpper()== "O" || relance.ToUpper() == "OUI")
                {
                    simulation();
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conexion.Close(); }


        }
        static void Main(string[] args)
        {
            simulation();
        }
    }
}
