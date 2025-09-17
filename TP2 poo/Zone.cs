using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_poo
{
    public class Zone
    {
        public List<Monstre> Lmonstre;
        public string Nom { get; set; }
        public int NivMin {  get; set; }
        public int NivMax { get; set; }

        public Zone(string Nom, int NivMin,int NivMax) 
        { 
            this.Nom = Nom;
            this.NivMin = NivMin;
            this.NivMax = NivMax;
            this.Lmonstre = new List<Monstre>();
        }



        public override string ToString()
        {
            string chaine= this.Nom+" "+this.NivMin+" "+this.NivMax;
            foreach(Monstre monstre in this.Lmonstre)
            {
                chaine+=" "+monstre.ToString();
            }
            return chaine;

        }

        public void AddMonstre(Monstre monstre)
        {
            this.Lmonstre.Add(monstre);
        }

        public void RetirerMonstre(Monstre monstre)
        {
            this.Lmonstre.Remove(monstre);
        }


    }
}
