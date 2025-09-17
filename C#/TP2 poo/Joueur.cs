using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_poo
{
    public class Joueur
    {
        public List<Monstre> Lmonstre;

        public Zone zone { get; set; }

        public string Nom { get; set; }

        public double NivVieActuel { get; set; }

        public double NivVieMax { get; set; }

        public double NivAttaque { get; set; }
        public Joueur(string Nom, double NivVieActuel, double NivVieMax, double NivAttaque,Zone zone)
        {
            this.Nom = Nom;
            this.NivVieActuel = NivVieActuel;
            this.NivVieMax = NivVieMax;
            this.NivAttaque = NivAttaque;
            this.Lmonstre = new List<Monstre>();
            this.zone = zone;
        }

        public override string ToString()
        {
            string chaine = this.Nom + " " + this.NivVieActuel + " " + this.NivVieMax + " " + this.NivAttaque + " "+this.zone.ToString()+" ";
            foreach (Monstre monstre in this.Lmonstre)
            {
                chaine += monstre.ToString() + " ";
            }
            return chaine;
        }

        public void AddMonstre(Monstre monstre)
        {
            this.Lmonstre.Add(monstre);
        }

        public void AttaquerMonstre(Monstre monstre)
        {
            monstre.NivVieActuel -= this.NivAttaque;
            if (monstre.NivVieActuel <= 0)
            {
                this.Lmonstre.Add(monstre);
            }
        }

        public void SeSoigner()
        {
            double restauration = this.NivVieActuel * 10/100;
            if (this.NivVieActuel + restauration > this.NivVieMax)
            {
                restauration = this.NivVieMax - this.NivVieActuel;
            }
            this.NivVieActuel += restauration;
        }

        public bool fuir()
        {
            Random random = new Random();
            int nombre = random.Next(101);
            if (nombre < 70)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool EstMort()
        {
            if (this.NivVieActuel <= 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}
