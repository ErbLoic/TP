using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_poo
{
    public class Monstre
    {
        public List<Zone> zones;
        public string Nom { get; set; }

        public int NivDifficulte { get; set; }

        public double NivVieActuel { get; set; }

        public double NivVieMax { get; set; }

        public double NivAttaque { get; set; }
        public Monstre(string Nom, int NivDifficulte, double NivVieActuel, double NivVieMax, double NivAttaque)
        {
            this.Nom = Nom;
            this.NivVieActuel = NivVieActuel;
            this.NivVieMax = NivVieMax;
            this.NivAttaque = NivAttaque;
            this.NivDifficulte = NivDifficulte;
            this.zones=new List<Zone>();
        }

       
        public override string ToString()
        {
            string chaine= this.Nom + " " + this.NivDifficulte + " " + this.NivVieActuel + " " + this.NivVieMax + " " + this.NivAttaque;
            foreach (Zone zone in this.zones)
            {
                chaine += " " + zone.ToString();
            }
            return chaine;
        }

        public void AddZone(Zone zone)
        {
            this.zones.Add(zone);  
        }

        public void AttaqueJoueur(Joueur joueur)
        {
            joueur.NivVieActuel -= this.NivAttaque;
        }

        public bool estVaincu()
        {
            if (this.NivVieActuel <= 0)
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
