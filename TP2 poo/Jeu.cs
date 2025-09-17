using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_poo
{
    public class Jeu
    {
        public List<Joueur> joueurs;
        public List<Zone> zones;

        public Jeu()
        {
            this.joueurs = new List<Joueur>();
            this.zones = new List<Zone>(); 
        }

        public void AddJoueur(Joueur joueur)
        {
            this.joueurs.Add(joueur);
        }

        public void AddZones(Zone zone)
        {
            this.zones.Add(zone);
        }

        public override string ToString()
        {
            string chaine="";
            foreach (Joueur joueur in this.joueurs)
            {
                chaine += joueur.ToString + " ";
            }
            foreach(Zone zone in this.zones)
            {
                chaine += zone.ToString() + " ";
            }
            return chaine;
        }

        public void ChangerZone(Zone zone)
        {
            foreach(Joueur joueur in this.joueurs)
            {
                joueur.zone= zone;
            }
        }

        public void AfficherZones()
        {
            string chaine;
            foreach(Zone zone in this.zones)
            {
                
                chaine = "----------" + zone.Nom + "----------";
                foreach(Monstre monstre in zone.Lmonstre) 
                {
                    chaine+= monstre.ToString() + " ";
                }
                Console.WriteLine(chaine);
            }
        }

        public void rencontreAlea()
        {
            Random random = new Random();

            int J = random.Next(this.joueurs.Count() - 1);
            int combat = random.Next(joueurs[J].zone.Lmonstre.Count() - 1);
            Joueur J1=this.joueurs[J];
            Monstre J2 = J1.zone.Lmonstre[combat];
            bool rep = true;
            bool fuite = true;
            while((J2.estVaincu()==false && J1.EstMort() == false))
            {
                rep = true;
                Console.WriteLine("----Vie Monstre----");
                Console.WriteLine("Vie:" + J2.NivVieActuel + "PV");
                Console.WriteLine("----Joueur----");
                Console.WriteLine("Vie:" + J1.NivVieActuel + "pv");
                Console.WriteLine("Dégats:" + J1.NivAttaque);
                Console.WriteLine("3 choix:\n");
                Console.WriteLine("1- Attaquer");
                Console.WriteLine("2- Se Soigner");
                Console.WriteLine("3- fuir");
                while (rep)
                {

                    string reponse =Console.ReadLine();
                    Console.WriteLine(reponse);
                    if (reponse == "1")
                    {
                        rep = false;
                        J1.AttaquerMonstre(J2);
                    }
                    else if (reponse == "2")
                    {
                        rep = false;
                        J1.SeSoigner();
                    }
                    else if (reponse == "3")
                    {
                        rep = false;
                        if (J1.fuir() == true)
                        {
                            fuite = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERREUR saisie 1/2/3");
                    }
                }
                if (fuite == false)
                {
                    break;
                }
                J2.AttaqueJoueur(J1);
            }
            if(J2.estVaincu()==true)
            {
                Console.WriteLine(J1.Nom + " a gagné");
            }
            else if(J1.EstMort()==true)
            {
                Console.WriteLine("Vous avez perdu");
            }
            else
            {
                Console.WriteLine("Fuite réussite");
            }
        }
    }
}
